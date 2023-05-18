using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Extensions
{
    public static class DataTableExtensions
    {
        public static DataTable ToDataTable<T>(this List<T> items, string tableName)
        {
            DataTable dataTable = new DataTable(tableName);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties().Where(p => !p.GetGetMethod().IsVirtual).ToArray();

            // Get the property info for the property you want to fetch the "Column" attribute for
            foreach (PropertyInfo prop in typeof(T).GetProperties().Where(p => !p.GetGetMethod().IsVirtual))
            {
                // Fetch the "Column" attribute for the property using reflection
                ColumnAttribute columnAttribute = prop.GetCustomAttribute<ColumnAttribute>();
                dataTable.Columns.Add(columnAttribute?.Name ?? prop.Name);
            }


            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    if (!Props[i].GetGetMethod().IsVirtual || Attribute.IsDefined(Props[i], typeof(NotMappedAttribute)))
                        values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
