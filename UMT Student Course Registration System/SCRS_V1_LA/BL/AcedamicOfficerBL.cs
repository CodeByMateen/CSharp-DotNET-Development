using Lect25_W3_LA.DL;
using Lect25_W3_LA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect25_W3_LA.BL
{
    class AcedamicOfficerBL
    {
        AcedamicOfficerDL dl;

        public AcedamicOfficerBL()
        {
            dl = new AcedamicOfficerDL();
        }

        public DataTable GetCourses()
        {
            return dl.GetCoursesDB();
        }

        public DataTable GetSections(string CourseID)
        {
            return dl.GetSectionsDB(CourseID);
        }

        public DataTable GetStudents(string SectionID)
        {
            return dl.GetStudentsDB(SectionID);
        }

        public bool AddCourse(CourseDTO dto)
        {
            if(dl.AddCourseDB(dto)>0)
            {
                return true;
            }
            return false;
        }
        
        public bool DropCourse(string CourseID)
        {
            if(dl.DropCourseDB(CourseID)>0)
            {
                return true;
            }
            return false;
        }

        public bool AddSection(SectionDTO dto)
        {
            if (dl.AddSectionDB(dto) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DropSection(string SectionID)
        {
            if (dl.DropSectionDB(SectionID)>0)
            {
                return true;
            }
            return false;
        }

        public bool ChangeCapacity(string Capacity, string SectionID)
        {
            if(dl.ChangeCapacityDB(Capacity,SectionID)>0)
            {
                return true;
            }
            return false;
        }
    }
}
