using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect25_W3_LA.DTO
{
    public class CourseRegisterDTO
    {
        private string _secID;
        private string _stdID;
        public CourseRegisterDTO()
        { }

        public string SecID { get => _secID; set => _secID = value; }
        public string StdID { get => _stdID; set => _stdID = value; }
    }
}
