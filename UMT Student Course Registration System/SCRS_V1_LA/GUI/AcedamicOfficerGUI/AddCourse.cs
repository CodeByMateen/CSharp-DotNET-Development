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

namespace Lect25_W3_LA.GUI.AcedamicOfficerGUI
{
    public partial class AddCourse : Form
    {
        CourseDTO dto;
        AcedamicOfficerBL bl;
        public AddCourse()
        {
            InitializeComponent();
            dto = new CourseDTO();
            bl = new AcedamicOfficerBL();
        }

        private void btn_addcourse_Click(object sender, EventArgs e)
        {
            dto.CourseId = txt_courseid.Text;
            dto.CourseName = txt_coursename.Text;
            dto.CreditHrs = nud_credithrs.Value.ToString();
            dto.DepartmentId = cb_department.Text;
            if(bl.AddCourse(dto))
            {
                MessageBox.Show("Course Added Successfully.");
            }
            else
            {
                MessageBox.Show("An Error Occured.");
            }
        }
    }
}
