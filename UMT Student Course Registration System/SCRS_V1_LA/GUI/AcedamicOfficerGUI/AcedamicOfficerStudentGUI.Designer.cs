
namespace Lect25_W3_LA.GUI.AcedamicOfficerGUI
{
    partial class AcedamicOfficerStudentGUI
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
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_student
            // 
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(12, 12);
            this.dgv_student.MultiSelect = false;
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.ReadOnly = true;
            this.dgv_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_student.Size = new System.Drawing.Size(510, 426);
            this.dgv_student.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(593, 396);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(155, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // AcedamicOfficerStudentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_student);
            this.Name = "AcedamicOfficerStudentGUI";
            this.Text = "AcedamicOfficerStudentGUI";
            this.Load += new System.EventHandler(this.AcedamicOfficerStudentGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.Button btn_close;
    }
}