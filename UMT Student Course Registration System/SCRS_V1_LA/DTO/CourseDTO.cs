using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect25_W3_LA.DTO
{
    class CourseDTO
    {
        string _courseId;
        string _courseName;
        string _creditHrs;
        string _departmentId;

        public string CourseId { get => _courseId; set => _courseId = value; }
        public string CourseName { get => _courseName; set => _courseName = value; }
        public string CreditHrs { get => _creditHrs; set => _creditHrs = value; }
        public string DepartmentId { get => _departmentId; set => _departmentId = value; }
    }
}
