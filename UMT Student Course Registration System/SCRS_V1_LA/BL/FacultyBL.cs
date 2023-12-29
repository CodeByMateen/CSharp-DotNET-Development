using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lect25_W3_LA.DL;
using Lect25_W3_LA.DTO;

namespace Lect25_W3_LA.BL
{
    class FacultyBL
    {
        FacultyDL fDL;
        public FacultyBL()
        {
            fDL = new FacultyDL();
        }
        public DataTable GetPendingRequests(UserDTO facultyDTO)
        {
            return fDL.GetPendingRequestsFromDB(facultyDTO);
        }

        public void UpdatePendingRequests(List<RequestDTO> updatedRequests)
        {
            fDL.UpdatePendingRequestsInDB(updatedRequests);
        }
    }
}
