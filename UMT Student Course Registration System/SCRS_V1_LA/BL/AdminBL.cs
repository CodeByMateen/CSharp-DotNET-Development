using Lect25_W3_LA.DL;
using Lect25_W3_LA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect25_W3_LA.BL
{
    class AdminBL
    {
        private AdminDL aDL;
        public AdminBL()
        {
            aDL = new AdminDL();
        }
        public void CreateAccount(UserDTO ud)
        {
            ud.Role.ToLower();
            aDL.CreateAccountInDB(ud);
            if(ud.Role == "Student")
            {
                aDL.AddStudentInDB(ud);
            }
            else if(ud.Role == "faculty")
            {
                aDL.AddFacultyInDB(ud);
            }

        }

        internal UserDTO CheckAccount(string text)
        {
            return aDL.CheckAccount(text);
        }

        internal void Block_UnBlock_User(UserDTO uDTO)
        {
            if (uDTO.Status.Equals("block"))
                uDTO.Status = "active";
            else
                uDTO.Status = "block";
            aDL.Block_UnBlock_User_InDB(uDTO);

        }
    }
}
