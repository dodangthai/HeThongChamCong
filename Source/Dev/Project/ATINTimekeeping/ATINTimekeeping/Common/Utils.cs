using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static DateTime GetDatetimePickerValue(DateTimePicker component)
        {
            try
            {
                if (component == null)
                {
                    return DateTime.MinValue;
                }

                if (component.Checked)
                {
                    return component.Value.Date;
                }

                return DateTime.MinValue;
            }
            catch
            {
                return DateTime.MinValue;
            }
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

        public static string DateTimeToString(DateTime dateTime)
        {
            try
            {
                return dateTime.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }

        public static byte[] ImageToByte( Image image)
        {
            if(image == null)
            {
                return new byte[0];
            }

            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(image);
                bmp.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            using (var ms = new MemoryStream())
            {
                byte[] pData = blob;
                ms.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(ms, false);
                return bm;
            }           
        }

        public static string ByteToStringBase64 (byte[] blob)
        {
            string imageBase64 = "";

            if ( blob != null || blob.Length > 0)
            {
                imageBase64 = Convert.ToBase64String(blob);
            }

            return imageBase64;
        }

        public static int NVLInt(object input)
        {
            try
            {
                if (input == null) return 0;

                return (int) input;
            }
            catch
            {
                return 0;
            }
        }

        public static bool NotNullValue(object value)
        {
            bool valueIsNotNull = false;

            if(value == null)
            {
                return valueIsNotNull;
            }

            Type type = value.GetType();
            if(type.Equals(typeof(string)))
            {
                string strValue = (string) value;
                if (strValue != null && strValue.Length > 0)
                {
                    valueIsNotNull = true;
                }
            }
            else if (type.Equals(typeof(int)))
            {
                int intValue = (int) value;
                if (intValue != 0)
                {
                    valueIsNotNull = true;
                }
            }
            else if (type.Equals(typeof(bool)))
            {
                bool blValue = (bool) value;
                if (blValue)
                {
                    valueIsNotNull = true;
                }
            }
            else if (type.Equals(typeof(byte[])))
            {
                byte[] arrByteValue = (byte[]) value;
                if (arrByteValue != null && arrByteValue.Length > 0)
                {
                    valueIsNotNull = true;
                }
            }
            else if (type.Equals(typeof(DateTime)))
            {
                DateTime date = (DateTime) value;
                if (date != null && date != DateTime.MinValue && date != DateTime.MaxValue)
                {
                    valueIsNotNull = true;
                }
            }

            return valueIsNotNull;
        }

        public static int ConvertBitToInt(bool value)
        {
            return value ? 1 : 0;
        }
    }
}
