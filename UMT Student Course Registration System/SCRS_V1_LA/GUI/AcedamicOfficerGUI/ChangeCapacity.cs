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
    public partial class ChangeCapacity : Form
    {
        AcedamicOfficerBL bl;
        SectionDTO dto;
        public ChangeCapacity(SectionDTO DTO)
        {
            InitializeComponent();
            dto = DTO;
            bl = new AcedamicOfficerBL();
        }

        private void ChangeCapacity_Load(object sender, EventArgs e)
        {
            txt_sectionid.Text = dto.SectionId;
            txt_courseid.Text = dto.CourseId;
            txt_sectionname.Text = dto.SectionName;
            txt_capacity.Text = dto.Capacity;
        }

        private void btn_changecapacity_Click(object sender, EventArgs e)
        {
            if(bl.ChangeCapacity(txt_capacity.Text,txt_sectionid.Text))
            {
                MessageBox.Show("Capacity Increased Successfully.");
            }
            else
            {
                MessageBox.Show("An Error Occured.");
            }
        }
    }
}
