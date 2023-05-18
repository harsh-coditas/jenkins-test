using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.API.Constants.Response;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.API.Models.Payload.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using ConnectAndSellSupport.Services.CsvMapper;
using ConnectAndSellSupport.Domain.Models.Custom.User;
using System.Collections.Generic;
using ConnectAndSellSupport.Domain.ViewModels;
using ConnectAndSellSupport.API.Models.Response.User;
using Microsoft.AspNetCore.Authorization;

namespace ConnectAndSellSupport.API.Controllers
{

    [Route(Routes.GenericControllerV1)]
    [ApiController]
    [Authorize(Policy = Policies.AdminAndEngineering)]
    public class UserBulkUploadController : ControllerBase
    {
        private readonly ICSVService _csvService;
        private readonly IResponseFactory _responseFactory;
        private readonly ILogger<UserBulkUploadController> _logger;
        private readonly IUserBulkUploadService _userBulkUploadService;

        public UserBulkUploadController(ICSVService csvService, IResponseFactory responseFactory, ILogger<UserBulkUploadController> logger, IUserBulkUploadService userBulkUploadService)
        {
            _responseFactory = responseFactory;
            _logger = logger;
            _csvService = csvService;
            _userBulkUploadService = userBulkUploadService;
        }
        /// <summary>
        /// User Csv will get catched here for further processing
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [Route(Routes.ReadUserBulkCsv)]
        [HttpPost]
        public UserBulkUploadResponse ReadUserBulkCSV([FromForm] IFormFileCollection file, [FromForm] int companyId, [FromForm] Roles[] roleIds)
        {
            try
            {
                (bool status, List<UserUploadError> data) = this._userBulkUploadService.BulkSaveUser(file, companyId, roleIds);
                return new UserBulkUploadResponse()
                {
                    status = status,
                    ErrorDetails = data,
                    message = ""
                };
            }
            catch (Exception ex)
            {
                return new UserBulkUploadResponse()
                {
                    status = false,
                    ErrorDetails = null,
                    message = ex.Message.ToString()
                };
            }
        }

        /// <summary>
        /// This Method will dynamically generate sample csv data, To change the data please make changes in CSVSampleData.cs file
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Route(Routes.GetSampleCsvData)]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ExportV2()
        {
            try
            {
                CSVSampleData data = new CSVSampleData();
                var list = data.UserCsvData;
                var stream = new MemoryStream();

                using (var package = new ExcelPackage(stream))
                {
                    var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                    workSheet.Cells.LoadFromCollection(list, true);
                    package.Save();
                }
                stream.Position = 0;
                string excelName = $"UserList-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";

                //return File(stream, "application/octet-stream", excelName);  
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to generate csv");
                return _responseFactory.GetErrorResponse(
                    StatusCodes.Status500InternalServerError, APIErrorCodes.InternalServerException);
            }
        }
    }
}
