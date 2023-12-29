using Lect25_W3_LA.BL;
using Lect25_W3_LA.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect25_W3_LA
{
    public partial class LoginGUI : Form
    {
        private LoginDTO lgDTO;
        private LoginBL lgBL;
        public LoginGUI()
        {
            InitializeComponent();
            lgDTO = new LoginDTO();
            lgBL = new LoginBL();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Usernname.Clear();
            txt_Password.Text = "";
            txt_Usernname.Focus();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!(txt_Usernname.Text == "" || txt_Password.Text == ""))
            {
                lgDTO.Username = txt_Usernname.Text;
                lgDTO.Password = txt_Password.Text;
                lgBL.VerifyUser(lgDTO).ShowDialog();
            }


        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
            
        }
    }
}
