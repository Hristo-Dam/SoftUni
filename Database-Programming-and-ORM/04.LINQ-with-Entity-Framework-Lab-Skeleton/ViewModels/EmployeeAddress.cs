using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni.ViewModels
{
    public class EmployeeAddress
    {
        public int EmployeeId { get; set; }

        public string JobTitle { get; set; }

        public int? AddressId { get; set; }

        public string AddressText { get; set; }
    }
}
