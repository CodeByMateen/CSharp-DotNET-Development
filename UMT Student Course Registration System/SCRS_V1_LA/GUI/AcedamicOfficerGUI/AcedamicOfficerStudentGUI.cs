using Lect25_W3_LA.BL;
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
    public partial class AcedamicOfficerStudentGUI : Form
    {
        AcedamicOfficerBL bl;
        string SectionID;

        public AcedamicOfficerStudentGUI(string sectionid)
        {
            InitializeComponent();
            bl = new AcedamicOfficerBL();
            SectionID = sectionid;         
        }

        private void AcedamicOfficerStudentGUI_Load(object sender, EventArgs e)
        {
            dgv_student.DataSource = bl.GetStudents(SectionID);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
