using AutoMapper;
using NUnit.Framework;

using ApiMapper = ConnectAndSellSupport.API.Automapper;
using ServiceMapper = ConnectAndSellSupport.Services.Automapper;

namespace ConnectAndSellSupport.Tests
{
	[TestFixture]
	public class AutomapperTests
	{
		private MapperConfiguration _config;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{

			_config = new MapperConfiguration(cfg =>
			{
				#region Api mappers
				cfg.AddProfile(new ApiMapper.CallProfile());

				cfg.AddProfile(new ApiMapper.CompanyProfile());

				cfg.AddProfile(new ApiMapper.ListProfile());

				cfg.AddProfile(new ApiMapper.PenaltyBoxProfile());

				cfg.AddProfile(new ApiMapper.UserProfile());
				
				cfg.AddProfile(new ApiMapper.JobsProfile());
				#endregion

				#region Service mappers
				cfg.AddProfile(new ServiceMapper.Call.CallProflile());

				cfg.AddProfile(new ServiceMapper.Company.CompanyConfigurationProfile());
				cfg.AddProfile(new ServiceMapper.Company.CompanyProfile());

				cfg.AddProfile(new ServiceMapper.List.ListProfile());

				cfg.AddProfile(new ServiceMapper.PenaltyBox.PenaltyBoxProfile());

				cfg.AddProfile(new ServiceMapper.User.UserProfile());
				cfg.AddProfile(new ServiceMapper.job.JobProfile());
				#endregion
			});
		}

		[Test]
		public void VerifyConversationProfiles()
		{
			_config.AssertConfigurationIsValid();

			Assert.Pass();
		}
	}
}
