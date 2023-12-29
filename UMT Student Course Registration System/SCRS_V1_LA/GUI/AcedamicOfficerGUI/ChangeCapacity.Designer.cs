
namespace Lect25_W3_LA.GUI.AcedamicOfficerGUI
{
    partial class ChangeCapacity
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
            this.txt_sectionname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_courseid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sectionid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_capacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_changecapacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sectionname
            // 
            this.txt_sectionname.Location = new System.Drawing.Point(124, 126);
            this.txt_sectionname.Name = "txt_sectionname";
            this.txt_sectionname.ReadOnly = true;
            this.txt_sectionname.Size = new System.Drawing.Size(154, 20);
            this.txt_sectionname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Section Name";
            // 
            // txt_courseid
            // 
            this.txt_courseid.Location = new System.Drawing.Point(124, 83);
            this.txt_courseid.Name = "txt_courseid";
            this.txt_courseid.ReadOnly = true;
            this.txt_courseid.Size = new System.Drawing.Size(154, 20);
            this.txt_courseid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course ID";
            // 
            // txt_sectionid
            // 
            this.txt_sectionid.Location = new System.Drawing.Point(124, 40);
            this.txt_sectionid.Name = "txt_sectionid";
            this.txt_sectionid.ReadOnly = true;
            this.txt_sectionid.Size = new System.Drawing.Size(154, 20);
            this.txt_sectionid.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Section ID";
            // 
            // txt_capacity
            // 
            this.txt_capacity.Location = new System.Drawing.Point(124, 169);
            this.txt_capacity.Name = "txt_capacity";
            this.txt_capacity.Size = new System.Drawing.Size(154, 20);
            this.txt_capacity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Capacity";
            // 
            // btn_changecapacity
            // 
            this.btn_changecapacity.Location = new System.Drawing.Point(141, 224);
            this.btn_changecapacity.Name = "btn_changecapacity";
            this.btn_changecapacity.Size = new System.Drawing.Size(118, 23);
            this.btn_changecapacity.TabIndex = 10;
            this.btn_changecapacity.Text = "Change Capacity";
            this.btn_changecapacity.UseVisualStyleBackColor = true;
            this.btn_changecapacity.Click += new System.EventHandler(this.btn_changecapacity_Click);
            // 
            // ChangeCapacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 305);
            this.Controls.Add(this.btn_changecapacity);
            this.Controls.Add(this.txt_capacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sectionname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_courseid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sectionid);
            this.Controls.Add(this.label1);
            this.Name = "ChangeCapacity";
            this.Text = "ChangeCapacity";
            this.Load += new System.EventHandler(this.ChangeCapacity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sectionname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_courseid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sectionid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_capacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_changecapacity;
    }
}