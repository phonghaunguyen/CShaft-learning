using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaft_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //Console.WriteLine("Today's exercise");
            //Cach ep kieu 1
            float fSize = 1.0f;
            int uRet = (int)fSize / 2; // =0


            //Cach ep kieu 2
            //string  str_read = Console.ReadLine();
            //bool    type_bool = Convert.ToBoolean(str_read);
            //Int16   type_Int16 = Convert.ToInt16(str_read);
            //Int32   type_Int32 = Convert.ToInt32(str_read);
            //Int64   type_Int64 = Convert.ToInt64(str_read);
            //float   type_float = Convert.ToSingle(str_read);
            //double  type_double = Convert.ToDouble(str_read);

            //Cach ep kieu 3
            //bool type_bool = bool.Parse(str_read);
            //Int16 type_Int16 = Int16.Parse(str_read);
            //Int32 type_Int32 = Int32.Parse(str_read);
            //Int64 type_Int64 = Int64.Parse(str_read);
            //float type_float = float.Parse(str_read);
            //double type_double = double.Parse(str_read);

            //Cach ep kieu 4
            //bool.TryParse(str_read, out bool ret_bool);
            //Int16.TryParse(str_read, out Int16 ret_int16);
            //Int32.TryParse(str_read, out Int32 ret_int32);
            //Int64.TryParse(str_read, out Int64 ret_int64);
            //float.TryParse(str_read, out float ret_float);
            //double.TryParse(str_read, out double ret_double);

            //kiem tra kieu du lieu
            var vNumber = 123.333;
            Console.WriteLine(vNumber.GetType());


            //kiem tra vung gia tri
            Console.WriteLine($"Min: {float.MinValue},Max: {float.MaxValue}");
            Console.ReadLine();
        }
    }
}
