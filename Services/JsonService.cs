using System;
using System.IO;
using Newtonsoft.Json;


namespace ApplicationTemplate.Services;

/// <summary>
///     This concrete service and method only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public class JsonService : IJsonService
{
    

    public abstract class Movie
    {
        public static void Read(string json)
        {
            Product p = JsonConvert.DeserializeObject<Product>(json);

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Expiry);
            Console.WriteLine(p.Sizes);

        }

        public void Write()
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            // Install-Package Newtonsoft.Json
            string json = JsonConvert.SerializeObject(product);

            Console.WriteLine(json);

            return json;
        }
        internal class Product()
        {
            public string Name { get; set; }
            public DateTime Expiry { get; set; }

            public string[] Sizes { get; set; }
        }
    }
    
}
