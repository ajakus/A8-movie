using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public abstract class IJsonService 
    {
        public abstract string Read();
        public abstract string Write();
    }
}
