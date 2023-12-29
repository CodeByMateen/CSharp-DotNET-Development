
namespace Lect25_W3_LA.GUI
{
    partial class AcedamicOfficerMainGUI
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
            this.dgv_courses = new System.Windows.Forms.DataGridView();
            this.btn_sections = new System.Windows.Forms.Button();
            this.btn_dropcourse = new System.Windows.Forms.Button();
            this.btn_addcourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_courses
            // 
            this.dgv_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courses.Location = new System.Drawing.Point(13, 13);
            this.dgv_courses.MultiSelect = false;
            this.dgv_courses.Name = "dgv_courses";
            this.dgv_courses.ReadOnly = true;
            this.dgv_courses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_courses.Size = new System.Drawing.Size(424, 425);
            this.dgv_courses.TabIndex = 0;
            // 
            // btn_sections
            // 
            this.btn_sections.Location = new System.Drawing.Point(554, 314);
            this.btn_sections.Name = "btn_sections";
            this.btn_sections.Size = new System.Drawing.Size(164, 23);
            this.btn_sections.TabIndex = 1;
            this.btn_sections.Text = "View Sections";
            this.btn_sections.UseVisualStyleBackColor = true;
            this.btn_sections.Click += new System.EventHandler(this.btn_sections_Click);
            // 
            // btn_dropcourse
            // 
            this.btn_dropcourse.Location = new System.Drawing.Point(554, 391);
            this.btn_dropcourse.Name = "btn_dropcourse";
            this.btn_dropcourse.Size = new System.Drawing.Size(164, 23);
            this.btn_dropcourse.TabIndex = 1;
            this.btn_dropcourse.Text = "Drop Course";
            this.btn_dropcourse.UseVisualStyleBackColor = true;
            this.btn_dropcourse.Click += new System.EventHandler(this.btn_dropcourse_Click);
            // 
            // btn_addcourse
            // 
            this.btn_addcourse.Location = new System.Drawing.Point(554, 354);
            this.btn_addcourse.Name = "btn_addcourse";
            this.btn_addcourse.Size = new System.Drawing.Size(164, 23);
            this.btn_addcourse.TabIndex = 1;
            this.btn_addcourse.Text = "Add Course";
            this.btn_addcourse.UseVisualStyleBackColor = true;
            this.btn_addcourse.Click += new System.EventHandler(this.btn_addcourse_Click);
            // 
            // AcedamicOfficerMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addcourse);
            this.Controls.Add(this.btn_dropcourse);
            this.Controls.Add(this.btn_sections);
            this.Controls.Add(this.dgv_courses);
            this.Name = "AcedamicOfficerMainGUI";
            this.Text = "AcedamicOfficerMainGUI";
            this.Load += new System.EventHandler(this.AcedamicOfficerMainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_courses;
        private System.Windows.Forms.Button btn_sections;
        private System.Windows.Forms.Button btn_dropcourse;
        private System.Windows.Forms.Button btn_addcourse;
    }
}