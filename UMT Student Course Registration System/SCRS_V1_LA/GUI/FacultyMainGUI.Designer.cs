namespace Lect25_W3_LA.GUI
{
    partial class FacultyMainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Requests = new System.Windows.Forms.DataGridView();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.btn_Approve = new System.Windows.Forms.Button();
            this.lb_Welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Requests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Requests
            // 
            this.dgv_Requests.AllowUserToAddRows = false;
            this.dgv_Requests.AllowUserToDeleteRows = false;
            this.dgv_Requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Requests.Location = new System.Drawing.Point(359, 140);
            this.dgv_Requests.Name = "dgv_Requests";
            this.dgv_Requests.ReadOnly = true;
            this.dgv_Requests.RowTemplate.Height = 40;
            this.dgv_Requests.Size = new System.Drawing.Size(1209, 742);
            this.dgv_Requests.TabIndex = 0;
            this.dgv_Requests.SelectionChanged += new System.EventHandler(this.dgv_Requests_SelectionChanged);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Location = new System.Drawing.Point(1186, 898);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(178, 80);
            this.btn_SelectAll.TabIndex = 1;
            this.btn_SelectAll.Text = "Select All";
            this.btn_SelectAll.UseVisualStyleBackColor = true;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // btn_Approve
            // 
            this.btn_Approve.Enabled = false;
            this.btn_Approve.Location = new System.Drawing.Point(1400, 898);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.Size = new System.Drawing.Size(168, 80);
            this.btn_Approve.TabIndex = 2;
            this.btn_Approve.Text = "Approve";
            this.btn_Approve.UseVisualStyleBackColor = true;
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Location = new System.Drawing.Point(1576, 33);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(133, 32);
            this.lb_Welcome.TabIndex = 3;
            this.lb_Welcome.Text = "Welcome";
            // 
            // FacultyMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1952, 1047);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.btn_Approve);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.dgv_Requests);
            this.Name = "FacultyMainGUI";
            this.Text = "FacultyMainGUI";
            this.Load += new System.EventHandler(this.FacultyMainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Requests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Requests;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.Button btn_Approve;
        private System.Windows.Forms.Label lb_Welcome;
    }
}