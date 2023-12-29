
namespace Lect25_W3_LA.GUI.AcedamicOfficerGUI
{
    partial class AddCourse
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
            this.txt_courseid = new System.Windows.Forms.TextBox();
            this.txt_coursename = new System.Windows.Forms.TextBox();
            this.nud_credithrs = new System.Windows.Forms.NumericUpDown();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addcourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_credithrs)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_courseid
            // 
            this.txt_courseid.Location = new System.Drawing.Point(86, 38);
            this.txt_courseid.Name = "txt_courseid";
            this.txt_courseid.Size = new System.Drawing.Size(162, 20);
            this.txt_courseid.TabIndex = 0;
            // 
            // txt_coursename
            // 
            this.txt_coursename.Location = new System.Drawing.Point(86, 73);
            this.txt_coursename.Name = "txt_coursename";
            this.txt_coursename.Size = new System.Drawing.Size(162, 20);
            this.txt_coursename.TabIndex = 0;
            // 
            // nud_credithrs
            // 
            this.nud_credithrs.Location = new System.Drawing.Point(86, 115);
            this.nud_credithrs.Name = "nud_credithrs";
            this.nud_credithrs.Size = new System.Drawing.Size(162, 20);
            this.nud_credithrs.TabIndex = 1;
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "NULL",
            "dept1",
            "dept2",
            "dept3"});
            this.cb_department.Location = new System.Drawing.Point(86, 154);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(162, 21);
            this.cb_department.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credit Hrs";
            // 
            // btn_addcourse
            // 
            this.btn_addcourse.Location = new System.Drawing.Point(125, 216);
            this.btn_addcourse.Name = "btn_addcourse";
            this.btn_addcourse.Size = new System.Drawing.Size(75, 23);
            this.btn_addcourse.TabIndex = 4;
            this.btn_addcourse.Text = "Add Course";
            this.btn_addcourse.UseVisualStyleBackColor = true;
            this.btn_addcourse.Click += new System.EventHandler(this.btn_addcourse_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 330);
            this.Controls.Add(this.btn_addcourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.nud_credithrs);
            this.Controls.Add(this.txt_coursename);
            this.Controls.Add(this.txt_courseid);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            ((System.ComponentModel.ISupportInitialize)(this.nud_credithrs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_courseid;
        private System.Windows.Forms.TextBox txt_coursename;
        private System.Windows.Forms.NumericUpDown nud_credithrs;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addcourse;
    }
}