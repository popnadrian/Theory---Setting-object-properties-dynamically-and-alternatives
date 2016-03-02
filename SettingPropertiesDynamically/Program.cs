using System;
using System.Linq;
using System.Reflection;

namespace SettingPropertiesDynamically
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Subject();
            var properties = typeof(Subject).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // adding some different values to those properties on obj
            int item = 0;
            foreach (var prop in properties.OrderByDescending(p => p.Name))
            {
                if (prop.Name.StartsWith("Date"))
                    prop.SetValue(obj, DateTime.Now.AddDays(-1 * (++item)));
            }

            // controlling specific item index-like:
            var prop2 = properties.Single(p => p.Name.Contains("2"));
            prop2.SetValue(obj, DateTime.Now.AddDays(-1000));



            // and the prove that it works:
            Console.WriteLine("Subject: \r\n{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}"
                , obj.Date1, obj.Date2, obj.Date3, obj.Date4, obj.Date5);
            
            Console.ReadKey();
        }
    }
}
