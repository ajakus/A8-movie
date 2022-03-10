using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public class Video : Media
    {
        public override string Display()
        {
            string file = "C:/Users/jakus/Downloads/ApplicationTemplate-master/ApplicationTemplate-master/videos.csv";


            StreamReader sr = new StreamReader(file);

            string line = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                var column = line.Split(',');
                var sv = string.Join(',', column);
                Console.WriteLine(sv);

            }
            sr.Close();
            throw new NotImplementedException();
        }
        public static string Write()
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };
            
            Install-Package Newtonsoft.Json
            string json = JsonConvert.SerializeObject(product);

            Console.WriteLine(json);

            return json;
        }

        public static void Read(string json)
        {
            Product p = JsonConvert.DeserializeObject<Product>(json);

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Expiry);
            Console.WriteLine(p.Sizes);

        }
    }
}
