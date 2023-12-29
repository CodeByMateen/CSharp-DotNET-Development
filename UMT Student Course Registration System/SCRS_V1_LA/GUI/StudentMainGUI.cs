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
    public partial class StudentMainGUI : Form
    {
        private StudentBL stdBL;
        private UserDTO studentDTO;
        private bool viewOffer = false;
        private bool viewRegister = false;

        public StudentMainGUI(UserDTO dto)
        {
            InitializeComponent();
            stdBL = new StudentBL();
            studentDTO = dto;
        }

        private void StudentMainGUI_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
            try
            {
                dgv_ViewOffered.DataSource = stdBL.GetOfferedCourses(studentDTO.UserID);
                lb_Welcome.Text += studentDTO.Name;
                lb_Status.Text += studentDTO.Status;
                viewOffer = true;
            }catch(SqlException ex)
            {
                MessageBox.Show("Courses not available");
            }
        }

        private void dgv_ViewOffered_SelectionChanged(object sender, EventArgs e)
        {
            if(studentDTO.Status == "active"&& viewOffer==true)
            {
                btn_Add_Course.Enabled = true;
            }
        }

        private void btn_Add_Course_Click(object sender, EventArgs e)
        {
            RequestDTO reqDTO = new RequestDTO();
            reqDTO.SecID = dgv_ViewOffered.CurrentRow.Cells[1].Value.ToString();
            reqDTO.StdID = studentDTO.UserID;
            reqDTO.ReqType = "add";

            
            if (MessageBox.Show("Are you really want to add this course?","Adding course section "+ reqDTO.SecID,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    stdBL.RegisterCourseRequest(reqDTO);
                    MessageBox.Show("Add Course request submitted Succesfullly");
                }catch(SqlException ex)
                {
                    MessageBox.Show("Course has not been added");

                }
                dgv_ViewOffered.DataSource = stdBL.GetOfferedCourses(studentDTO.UserID);
                btn_Add_Course.Enabled = false;

            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            // not called in this scenerio
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_View_Registered.DataSource = stdBL.GetRegisteredCourses(studentDTO.UserID);
            dgv_ViewOffered.DataSource = stdBL.GetOfferedCourses(studentDTO.UserID);
            viewRegister = true;
            viewOffer = true;
        }

        private void dgv_View_Registered_SelectionChanged(object sender, EventArgs e)
        {
            if (studentDTO.Status == "active" && viewRegister == true)
            {
                btn_DropCourse.Enabled = true;
            }
        }

        private void btn_DropCourse_Click(object sender, EventArgs e)
        {
            RequestDTO reqDTO = new RequestDTO();
            reqDTO.SecID = dgv_View_Registered.CurrentRow.Cells[1].Value.ToString();
            reqDTO.StdID = studentDTO.UserID;
            reqDTO.ReqType = "drop";


            if (MessageBox.Show("Are you really want to drop this course?", "Adding course section " + reqDTO.SecID, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    stdBL.DropCourseRequest(reqDTO);
                    MessageBox.Show("Course Drop request submitted Succesfullly");
                    //dgv_View_Registered.CurrentRow.Frozen = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Course has not been dropped");

                }
                dgv_View_Registered.DataSource = stdBL.GetRegisteredCourses(studentDTO.UserID);
                btn_DropCourse.Enabled = false;

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
