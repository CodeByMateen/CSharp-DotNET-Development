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
    public partial class FacultyMainGUI : Form
    {
        FacultyBL facBL;
        UserDTO facultyDTO;

        public FacultyMainGUI(UserDTO ud)
        {
            InitializeComponent();
            facultyDTO = ud;
            facBL = new FacultyBL();

        }

        private void FacultyMainGUI_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
            btn_Approve.Enabled = false;
            try
            {
                dgv_Requests.DataSource = facBL.GetPendingRequests(facultyDTO);
                lb_Welcome.Text += facultyDTO.Name;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No pending requests");
            }

        }

        private void dgv_Requests_SelectionChanged(object sender, EventArgs e)
        {
            btn_Approve.Enabled = true;
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            //CourseRegisterDTO crDTO = new CourseRegisterDTO();
            List<RequestDTO> updatedRequests = new List<RequestDTO>();
            foreach (DataGridViewRow row in dgv_Requests.Rows)
            {
                RequestDTO rDTO = new RequestDTO();

                //rDTO.ReqStatus =  row.Cells[0].Value.ToString();
                rDTO.ReqID     =  row.Cells[1].Value.ToString();
                rDTO.ReqStatus = "approve";
                rDTO.ReqType = row.Cells["ReqType"].Value.ToString();
                rDTO.SecID = row.Cells["SecID"].Value.ToString();
                rDTO.StdID = row.Cells["StdID"].Value.ToString();

                updatedRequests.Add(rDTO);
                
            }
            try
            {

                if (updatedRequests.Count > 0)
                {
                    facBL.UpdatePendingRequests(updatedRequests);

                    MessageBox.Show("Request updated successfully");
                    dgv_Requests.DataSource = facBL.GetPendingRequests(facultyDTO);
                    if (dgv_Requests.Rows.Count == 0)
                        btn_Approve.Enabled = false;
                    else
                        btn_Approve.Enabled = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Request not updated");
            }
            
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {

        }
    }
}
