using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFilterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Projects\Education\HwPhotoSdk\PhotoFilterApp\bin\Debug";
            string appExt = "BurcuPhotoFilters.dll";

            var asmPath = Path.Combine(path, appExt);
            Assembly asm = Assembly.LoadFile(asmPath);

            Object o = asm.CreateInstance("BurcuPhotoFilters.Filter");
            if (o != null)
            {
                MethodInfo mi = o.GetType().GetMethod("ApplyFilter");
                Object[] ob = { };

                PropertyInfo name = o.GetType().GetProperty("FilterName");
                name.SetValue(o, "name");
                var nameValue = name.GetValue(o);
                Console.WriteLine(nameValue.ToString());

                mi.Invoke(o, ob);
            }
            
            Console.ReadLine();
        }
    }
}
