
namespace Lect25_W3_LA.GUI.AcedamicOfficerGUI
{
    partial class AddSection
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_secid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_courseid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_secname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_facultyid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_capacity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_addsection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section ID";
            // 
            // txt_secid
            // 
            this.txt_secid.Location = new System.Drawing.Point(168, 12);
            this.txt_secid.Name = "txt_secid";
            this.txt_secid.Size = new System.Drawing.Size(154, 20);
            this.txt_secid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course ID";
            // 
            // txt_courseid
            // 
            this.txt_courseid.Location = new System.Drawing.Point(168, 55);
            this.txt_courseid.Name = "txt_courseid";
            this.txt_courseid.ReadOnly = true;
            this.txt_courseid.Size = new System.Drawing.Size(154, 20);
            this.txt_courseid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Section Name";
            // 
            // txt_secname
            // 
            this.txt_secname.Location = new System.Drawing.Point(168, 98);
            this.txt_secname.Name = "txt_secname";
            this.txt_secname.Size = new System.Drawing.Size(154, 20);
            this.txt_secname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Faculty ID";
            // 
            // txt_facultyid
            // 
            this.txt_facultyid.Location = new System.Drawing.Point(168, 135);
            this.txt_facultyid.Name = "txt_facultyid";
            this.txt_facultyid.Size = new System.Drawing.Size(154, 20);
            this.txt_facultyid.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Capacity";
            // 
            // txt_capacity
            // 
            this.txt_capacity.Location = new System.Drawing.Point(168, 174);
            this.txt_capacity.Name = "txt_capacity";
            this.txt_capacity.Size = new System.Drawing.Size(154, 20);
            this.txt_capacity.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(168, 213);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(154, 20);
            this.txt_status.TabIndex = 1;
            // 
            // btn_addsection
            // 
            this.btn_addsection.Location = new System.Drawing.Point(187, 263);
            this.btn_addsection.Name = "btn_addsection";
            this.btn_addsection.Size = new System.Drawing.Size(109, 23);
            this.btn_addsection.TabIndex = 2;
            this.btn_addsection.Text = "Add Section";
            this.btn_addsection.UseVisualStyleBackColor = true;
            this.btn_addsection.Click += new System.EventHandler(this.btn_addsection_Click);
            // 
            // AddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 326);
            this.Controls.Add(this.btn_addsection);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_capacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_facultyid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_secname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_courseid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_secid);
            this.Controls.Add(this.label1);
            this.Name = "AddSection";
            this.Text = "AddSection";
            this.Load += new System.EventHandler(this.AddSection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_secid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_courseid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_secname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_facultyid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_capacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_addsection;
    }
}