using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
