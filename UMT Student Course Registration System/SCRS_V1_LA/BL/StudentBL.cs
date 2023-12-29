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
    class StudentBL
    {

        private StudentDL stdDL;
        public StudentBL()
        {
            stdDL = new StudentDL();
        }
        public DataTable GetOfferedCourses(string userID)// should pass userID to filter results
        {
            return stdDL.GetOfferedCoursesFromDB(userID);
        }

        

        public DataTable  GetRegisteredCourses(string userID)
        {
            return stdDL.GetRegisterCoursesFromDB(userID);
            
        }
        public void RegisterCourse(CourseRegisterDTO crDTO)
        {
            //stdDL.RegisterCourseInDB(crDTO);
            // throw new NotImplementedException();
        }
        public void DropCourse(CourseRegisterDTO crDTO)
        {
            //stdDL.DropCourseInDB(crDTO);

        }

        internal void RegisterCourseRequest(RequestDTO reqDTO)
        {
            stdDL.RegisterCourseRequestInDB(reqDTO);
            
        }
        public void DropCourseRequest(RequestDTO reqDTO)
        {
            stdDL.DropCourseRequestInDB(reqDTO);
        }
    }
}
