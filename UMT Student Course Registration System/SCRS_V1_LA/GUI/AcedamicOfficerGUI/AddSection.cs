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
    public partial class AddSection : Form
    {
        AcedamicOfficerBL bl;
        string CourseID;
        SectionDTO dto;
        public AddSection(string courseid)
        {
            InitializeComponent();
            bl = new AcedamicOfficerBL();
            CourseID = courseid;
            dto = new SectionDTO();
        }

        private void btn_addsection_Click(object sender, EventArgs e)
        {
            dto.SectionId = txt_secid.Text;
            dto.CourseId = txt_courseid.Text;
            dto.SectionName = txt_secname.Text;
            dto.FacultyId = txt_facultyid.Text;
            dto.Capacity = txt_capacity.Text;
            dto.Strength= "0";
            dto.Status = txt_status.Text;
            if(bl.AddSection(dto))
            {
                MessageBox.Show("Section Added Successfully.");
            }
            else
            {
                MessageBox.Show("An Error Occured.");
            }
        }

        private void AddSection_Load(object sender, EventArgs e)
        {
            txt_courseid.Text = CourseID;
        }
    }
}
