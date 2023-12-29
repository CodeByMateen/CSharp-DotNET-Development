using Lect25_W3_LA.BL;
using Lect25_W3_LA.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect25_W3_LA.GUI
{
    public partial class AdminMainGUI : Form
    {
        private UserDTO uDTO;
        private UserDTO uDTO_Block;
        private UserDTO adminDTO;
        private AdminBL aBL;
        public AdminMainGUI(UserDTO admin)
        {
            InitializeComponent();
            uDTO = new UserDTO();
            uDTO_Block = new UserDTO();
            aBL = new AdminBL();
            adminDTO = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txt_UserID.Text == "" || txt_Password.Text == "" || txt_Name.Text == ""))
                {
                    uDTO.UserID = txt_UserID.Text;
                    uDTO.Name = txt_Name.Text;
                    uDTO.Password = txt_Password.Text;
                    uDTO.Role = cmb_Role.Text;
                    aBL.CreateAccount(uDTO);
                    MessageBox.Show("Account has been successfuly created");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account has not been created due to " + ex.Message);
            }
        }

        private void AdminMainGUI_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (!(txt_Block_Username.Text == ""))
            {
                try
                {
                    uDTO_Block = aBL.CheckAccount(txt_Block_Username.Text);
                    if (uDTO_Block != null)
                    {
                        txt_Block_Username.Text = uDTO_Block.UserID;

                        txt_BlockName.Text = uDTO_Block.Name;
                        cmb_BlockRole.Text = uDTO_Block.Role;
                        txt_Status.Text = uDTO_Block.Status;
                        btn_Block.Enabled = true;
                        if (uDTO_Block.Status.Equals("active"))
                        {
                            btn_Block.Text = "Block";
                        }
                        else if (uDTO_Block.Status.Equals("block"))
                        {
                            btn_Block.Text = "Active";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record not found");
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Record not found due to exception");
                }
                
            }
        }


        private void btn_Block_Click(object sender, EventArgs e)
        {
            
            if (uDTO_Block != null)
            {
                try
                {
                    aBL.Block_UnBlock_User(uDTO_Block);
                    MessageBox.Show("User " + uDTO_Block.Name + " with id  " + uDTO_Block.UserID + " has been " + uDTO_Block.Status + "ed");
                    btn_Block.Enabled = false;

                }catch(SqlException ex)
                {
                    MessageBox.Show("Due to some reasons user status has not been updated");
                }
            }
        }

        private void txt_Block_Username_TextChanged(object sender, EventArgs e)
        {
            btn_Block.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
