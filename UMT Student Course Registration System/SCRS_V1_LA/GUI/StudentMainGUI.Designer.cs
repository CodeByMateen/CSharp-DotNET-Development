namespace Lect25_W3_LA.GUI
{
    partial class StudentMainGUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_Status = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.btn_Add_Course = new System.Windows.Forms.Button();
            this.dgv_ViewOffered = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_DropCourse = new System.Windows.Forms.Button();
            this.dgv_View_Registered = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewOffered)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Registered)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2073, 1082);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.lb_Status);
            this.tabPage1.Controls.Add(this.lb_Welcome);
            this.tabPage1.Controls.Add(this.btn_Add_Course);
            this.tabPage1.Controls.Add(this.dgv_ViewOffered);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2053, 1024);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Offered Courses";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(1606, 75);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(111, 32);
            this.lb_Status.TabIndex = 3;
            this.lb_Status.Text = "Status: ";
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Location = new System.Drawing.Point(1606, 24);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(140, 32);
            this.lb_Welcome.TabIndex = 2;
            this.lb_Welcome.Text = "Welcome ";
            // 
            // btn_Add_Course
            // 
            this.btn_Add_Course.Enabled = false;
            this.btn_Add_Course.Location = new System.Drawing.Point(1407, 815);
            this.btn_Add_Course.Name = "btn_Add_Course";
            this.btn_Add_Course.Size = new System.Drawing.Size(192, 85);
            this.btn_Add_Course.TabIndex = 1;
            this.btn_Add_Course.Text = "Add Course Request";
            this.btn_Add_Course.UseVisualStyleBackColor = true;
            this.btn_Add_Course.Click += new System.EventHandler(this.btn_Add_Course_Click);
            // 
            // dgv_ViewOffered
            // 
            this.dgv_ViewOffered.AllowUserToAddRows = false;
            this.dgv_ViewOffered.AllowUserToDeleteRows = false;
            this.dgv_ViewOffered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewOffered.Location = new System.Drawing.Point(441, 134);
            this.dgv_ViewOffered.Name = "dgv_ViewOffered";
            this.dgv_ViewOffered.ReadOnly = true;
            this.dgv_ViewOffered.RowTemplate.Height = 40;
            this.dgv_ViewOffered.Size = new System.Drawing.Size(1158, 664);
            this.dgv_ViewOffered.TabIndex = 0;
            this.dgv_ViewOffered.SelectionChanged += new System.EventHandler(this.dgv_ViewOffered_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.btn_DropCourse);
            this.tabPage2.Controls.Add(this.dgv_View_Registered);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2053, 1024);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registered Courses";
            // 
            // btn_DropCourse
            // 
            this.btn_DropCourse.Enabled = false;
            this.btn_DropCourse.Location = new System.Drawing.Point(1363, 810);
            this.btn_DropCourse.Name = "btn_DropCourse";
            this.btn_DropCourse.Size = new System.Drawing.Size(242, 85);
            this.btn_DropCourse.TabIndex = 3;
            this.btn_DropCourse.Text = "Drop Course Request";
            this.btn_DropCourse.UseVisualStyleBackColor = true;
            this.btn_DropCourse.Click += new System.EventHandler(this.btn_DropCourse_Click);
            // 
            // dgv_View_Registered
            // 
            this.dgv_View_Registered.AllowUserToAddRows = false;
            this.dgv_View_Registered.AllowUserToDeleteRows = false;
            this.dgv_View_Registered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Registered.Location = new System.Drawing.Point(447, 129);
            this.dgv_View_Registered.Name = "dgv_View_Registered";
            this.dgv_View_Registered.ReadOnly = true;
            this.dgv_View_Registered.RowTemplate.Height = 40;
            this.dgv_View_Registered.Size = new System.Drawing.Size(1158, 664);
            this.dgv_View_Registered.TabIndex = 2;
            this.dgv_View_Registered.SelectionChanged += new System.EventHandler(this.dgv_View_Registered_SelectionChanged);
            // 
            // StudentMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2073, 1082);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentMainGUI";
            this.Text = "StudentMainGUI";
            this.Load += new System.EventHandler(this.StudentMainGUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewOffered)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Registered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Add_Course;
        private System.Windows.Forms.DataGridView dgv_ViewOffered;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_DropCourse;
        private System.Windows.Forms.DataGridView dgv_View_Registered;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_Welcome;
    }
}