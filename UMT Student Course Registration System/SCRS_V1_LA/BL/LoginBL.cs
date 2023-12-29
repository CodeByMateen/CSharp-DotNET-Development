using Lect25_W3_LA.DL;
using Lect25_W3_LA.DTO;
using Lect25_W3_LA.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect25_W3_LA.BL
{
    class LoginBL
    {
        private LoginDL lgDL;
        public LoginBL()
        {
            lgDL = new LoginDL();
        }
        public Form VerifyUser(LoginDTO lg)
        {
            // Here we call loginDL objects method verifyUserFromDB
            UserDTO ud = lgDL.VerifyUserFromDB(lg);
            if(ud==null)
            {
                return new WrongUserGUI();
            }
            if (ud.Role == "admin")
            {
                return new AdminMainGUI(ud);
            }
            else if(ud.Role == "student")
            {
                return new StudentMainGUI(ud);
            }
            else if(ud.Role == "AcedamicOfficer")
            {
                return new AcedamicOfficerMainGUI();
            }
            else if(ud.Role == "faculty")
            {
                return new FacultyMainGUI(ud);
            }
            else
            {
                return new WrongUserGUI();
            }

            /*
            if (lg.Username.Equals("Admin") && lg.Password.Equals("Admin"))
                return true;
            return false;
            */
        }
    }
}
