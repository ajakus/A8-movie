using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public class Movie : Media
    {
        public override string Display()
        {
            string file = "C:/Users/jakus/Downloads/ApplicationTemplate-master/ApplicationTemplate-master/movies.csv";


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

    }
}
