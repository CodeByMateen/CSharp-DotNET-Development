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
    public partial class AcedamicOfficerSectionsGUI : Form
    {
        string CourseID;
        SectionDTO dto;
        AcedamicOfficerBL bl;
        public AcedamicOfficerSectionsGUI(string courseid)
        {
            InitializeComponent();
            bl = new AcedamicOfficerBL();
            CourseID = courseid;
            dto = new SectionDTO();
        }

        private void AcedamicOfficerSectionsGUI_Load(object sender, EventArgs e)
        {
            dgv_section.DataSource = bl.GetSections(CourseID);
        }

        private void btn_changelimit_Click(object sender, EventArgs e)
        {
            if (dgv_section.SelectedRows.Count > 0)
            {
                dto.SectionId = dgv_section.SelectedRows[0].Cells[0].Value.ToString();
                dto.CourseId = dgv_section.SelectedRows[0].Cells[1].Value.ToString();
                dto.SectionName = dgv_section.SelectedRows[0].Cells[2].Value.ToString();
                dto.FacultyId = dgv_section.SelectedRows[0].Cells[3].Value.ToString();
                dto.Capacity = dgv_section.SelectedRows[0].Cells[4].Value.ToString();
                dto.Strength = dgv_section.SelectedRows[0].Cells[5].Value.ToString();
                dto.Status = dgv_section.SelectedRows[0].Cells[6].Value.ToString();

                Form Capacity = new ChangeCapacity(dto);
                Capacity.Show(this);
            }
            else
            {
                MessageBox.Show("No Section selected.");
            }
        }

        private void btn_viewstudents_Click(object sender, EventArgs e)
        {
            if(dgv_section.SelectedRows.Count>0)
            {
                Form Students = new AcedamicOfficerStudentGUI(dgv_section.SelectedRows[0].Cells[0].Value.ToString());
                Students.Show(this);
            }
            else
            {
                MessageBox.Show("No Section selected.");
            }
        }

        private void btn_addsection_Click(object sender, EventArgs e)
        {
            Form Add = new AddSection(CourseID);
            Add.Show(this);
        }

        private void btn_dropsection_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to drop this section?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (dgv_section.SelectedRows.Count > 0)
            {
                string CourseID = dgv_section.SelectedRows[0].Cells[0].Value.ToString();
                if (bl.DropSection(CourseID))
                {
                    MessageBox.Show("Section Dropped Successfully.");
                }
                else
                {
                    MessageBox.Show("An error occured.");
                }
            }
            else
            {
                MessageBox.Show("No Section Selected.");
            }
        }
    }
}
