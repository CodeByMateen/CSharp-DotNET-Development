using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect25_W3_LA.DTO
{
    public class SectionDTO
    {
        string _sectionId;
        string _sectionName;
        string _courseId;
        string _facultyId;
        string _capacity;
        string _strength;
        string _status;

        public string SectionId { get => _sectionId; set => _sectionId = value; }
        public string SectionName { get => _sectionName; set => _sectionName = value; }
        public string CourseId { get => _courseId; set => _courseId = value; }
        public string FacultyId { get => _facultyId; set => _facultyId = value; }
        public string Capacity { get => _capacity; set => _capacity = value; }
        public string Strength { get => _strength; set => _strength = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
