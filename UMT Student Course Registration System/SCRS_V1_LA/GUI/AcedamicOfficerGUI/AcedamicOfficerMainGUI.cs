using Lect25_W3_LA.BL;
using Lect25_W3_LA.GUI.AcedamicOfficerGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect25_W3_LA.GUI
{
    public partial class AcedamicOfficerMainGUI : Form
    {
        AcedamicOfficerBL bl;
        public AcedamicOfficerMainGUI()
        {
            InitializeComponent();
            bl = new AcedamicOfficerBL();
        }

        private void AcedamicOfficerMainGUI_Load(object sender, EventArgs e)
        {
            dgv_courses.DataSource = bl.GetCourses();
        }

        private void btn_sections_Click(object sender, EventArgs e)
        {
            if(dgv_courses.SelectedRows.Count>0)
            {
                string CourseID = dgv_courses.SelectedRows[0].Cells[0].Value.ToString();

                Form Section = new AcedamicOfficerSectionsGUI(CourseID);
                Section.Show(this);
            }
            else
            {
                MessageBox.Show("No Course Selected.");
            }
        }

        private void btn_addcourse_Click(object sender, EventArgs e)
        {
            Form Add = new AddCourse();
            Add.Show(this);
        }

        private void btn_dropcourse_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to drop this course and all of its sections?","Confirm",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                return;
            }

            if (dgv_courses.SelectedRows.Count > 0)
            {
                string CourseID = dgv_courses.SelectedRows[0].Cells[0].Value.ToString();
                if(bl.DropCourse(CourseID))
                {
                    MessageBox.Show("Course Dropped Successfully.");
                }
                else
                {
                    MessageBox.Show("An error occured.");
                }
            }
            else
            {
                MessageBox.Show("No Course Selected.");
            }
            
        }
    }
}
