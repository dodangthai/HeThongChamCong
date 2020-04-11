using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATINTimekeeping.Common
{
    public static class Utils
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties) table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public static int StringToInt(string value)
        {
            try
            {
                return Int32.Parse(value);
            }
            catch
            {
                return 0;
            }
        }

        public static bool GetRadidoCheckboxValue(bool radioChecked)
        {
            return radioChecked ? true : false;
        }

        public static ObjectParameter DBNullParameter (string paramName, object value)
        {
            if (value == null)
            {
                return new ObjectParameter(paramName, DBNull.Value);
            }

            var strValue = value.ToString();
            if (strValue == "" || strValue == "0")
            {
                return new ObjectParameter(paramName, DBNull.Value);
            }

            return new ObjectParameter(paramName, value);
        }

        public static int GetComboboxValue(object selectedValue)
        {
            if (selectedValue == null)
            {
                return 0;
            }

            return (int)selectedValue;
        }

        public static DateTime StringToDate (string input, string dateFormat)
        {
            try
            {
                if (string.IsNullOrEmpty(input))
                {
                    return DateTime.MinValue;
                }
                return DateTime.ParseExact(input, dateFormat, null);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }
    }
}
