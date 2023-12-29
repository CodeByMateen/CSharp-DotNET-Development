
namespace Lect25_W3_LA.GUI.AcedamicOfficerGUI
{
    partial class AcedamicOfficerSectionsGUI
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
            this.dgv_section = new System.Windows.Forms.DataGridView();
            this.btn_dropsection = new System.Windows.Forms.Button();
            this.btn_viewstudents = new System.Windows.Forms.Button();
            this.btn_changelimit = new System.Windows.Forms.Button();
            this.btn_addsection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_section)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_section
            // 
            this.dgv_section.AllowUserToResizeColumns = false;
            this.dgv_section.AllowUserToResizeRows = false;
            this.dgv_section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_section.Location = new System.Drawing.Point(13, 13);
            this.dgv_section.MultiSelect = false;
            this.dgv_section.Name = "dgv_section";
            this.dgv_section.ReadOnly = true;
            this.dgv_section.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_section.Size = new System.Drawing.Size(531, 425);
            this.dgv_section.TabIndex = 0;
            // 
            // btn_dropsection
            // 
            this.btn_dropsection.Location = new System.Drawing.Point(602, 345);
            this.btn_dropsection.Name = "btn_dropsection";
            this.btn_dropsection.Size = new System.Drawing.Size(154, 23);
            this.btn_dropsection.TabIndex = 1;
            this.btn_dropsection.Text = "Drop Section";
            this.btn_dropsection.UseVisualStyleBackColor = true;
            this.btn_dropsection.Click += new System.EventHandler(this.btn_dropsection_Click);
            // 
            // btn_viewstudents
            // 
            this.btn_viewstudents.Location = new System.Drawing.Point(602, 388);
            this.btn_viewstudents.Name = "btn_viewstudents";
            this.btn_viewstudents.Size = new System.Drawing.Size(154, 23);
            this.btn_viewstudents.TabIndex = 1;
            this.btn_viewstudents.Text = "View Students";
            this.btn_viewstudents.UseVisualStyleBackColor = true;
            this.btn_viewstudents.Click += new System.EventHandler(this.btn_viewstudents_Click);
            // 
            // btn_changelimit
            // 
            this.btn_changelimit.Location = new System.Drawing.Point(602, 263);
            this.btn_changelimit.Name = "btn_changelimit";
            this.btn_changelimit.Size = new System.Drawing.Size(154, 23);
            this.btn_changelimit.TabIndex = 1;
            this.btn_changelimit.Text = "Change Limit";
            this.btn_changelimit.UseVisualStyleBackColor = true;
            this.btn_changelimit.Click += new System.EventHandler(this.btn_changelimit_Click);
            // 
            // btn_addsection
            // 
            this.btn_addsection.Location = new System.Drawing.Point(602, 304);
            this.btn_addsection.Name = "btn_addsection";
            this.btn_addsection.Size = new System.Drawing.Size(154, 23);
            this.btn_addsection.TabIndex = 1;
            this.btn_addsection.Text = "Add Section";
            this.btn_addsection.UseVisualStyleBackColor = true;
            this.btn_addsection.Click += new System.EventHandler(this.btn_addsection_Click);
            // 
            // AcedamicOfficerSectionsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_viewstudents);
            this.Controls.Add(this.btn_changelimit);
            this.Controls.Add(this.btn_addsection);
            this.Controls.Add(this.btn_dropsection);
            this.Controls.Add(this.dgv_section);
            this.Name = "AcedamicOfficerSectionsGUI";
            this.Text = "AcedamicOfficerSectionsGUI";
            this.Load += new System.EventHandler(this.AcedamicOfficerSectionsGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_section)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_section;
        private System.Windows.Forms.Button btn_dropsection;
        private System.Windows.Forms.Button btn_viewstudents;
        private System.Windows.Forms.Button btn_changelimit;
        private System.Windows.Forms.Button btn_addsection;
    }
}