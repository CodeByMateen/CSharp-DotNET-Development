namespace Lect25_W3_LA.GUI
{
    partial class AdminMainGUI
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_BlockName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Block = new System.Windows.Forms.Button();
            this.cmb_BlockRole = new System.Windows.Forms.ComboBox();
            this.txt_Block_Username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(2115, 1029);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.txt_Name);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cmb_Role);
            this.tabPage1.Controls.Add(this.txt_Password);
            this.tabPage1.Controls.Add(this.txt_UserID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2095, 971);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Account";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(863, 638);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(373, 38);
            this.txt_Name.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 638);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1083, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 87);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_Role
            // 
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Academic Officer"});
            this.cmb_Role.Location = new System.Drawing.Point(863, 501);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(373, 39);
            this.cmb_Role.TabIndex = 6;
            this.cmb_Role.Text = "Student";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(863, 365);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(373, 38);
            this.txt_Password.TabIndex = 5;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(863, 228);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(373, 38);
            this.txt_UserID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account Admin Panel";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.txt_Status);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btn_Search);
            this.tabPage2.Controls.Add(this.txt_BlockName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_Block);
            this.tabPage2.Controls.Add(this.cmb_BlockRole);
            this.tabPage2.Controls.Add(this.txt_Block_Username);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2095, 971);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Block Account";
            // 
            // txt_Status
            // 
            this.txt_Status.Enabled = false;
            this.txt_Status.Location = new System.Drawing.Point(949, 639);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(373, 38);
            this.txt_Status.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(696, 639);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Status";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1383, 234);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(187, 69);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_BlockName
            // 
            this.txt_BlockName.Enabled = false;
            this.txt_BlockName.Location = new System.Drawing.Point(946, 515);
            this.txt_BlockName.Name = "txt_BlockName";
            this.txt_BlockName.Size = new System.Drawing.Size(373, 38);
            this.txt_BlockName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name";
            // 
            // btn_Block
            // 
            this.btn_Block.Enabled = false;
            this.btn_Block.Location = new System.Drawing.Point(1085, 725);
            this.btn_Block.Name = "btn_Block";
            this.btn_Block.Size = new System.Drawing.Size(256, 87);
            this.btn_Block.TabIndex = 15;
            this.btn_Block.Text = "Block/Unblock";
            this.btn_Block.UseVisualStyleBackColor = true;
            this.btn_Block.Click += new System.EventHandler(this.btn_Block_Click);
            // 
            // cmb_BlockRole
            // 
            this.cmb_BlockRole.Enabled = false;
            this.cmb_BlockRole.FormattingEnabled = true;
            this.cmb_BlockRole.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Academic Officer"});
            this.cmb_BlockRole.Location = new System.Drawing.Point(946, 378);
            this.cmb_BlockRole.Name = "cmb_BlockRole";
            this.cmb_BlockRole.Size = new System.Drawing.Size(373, 39);
            this.cmb_BlockRole.TabIndex = 14;
            // 
            // txt_Block_Username
            // 
            this.txt_Block_Username.Location = new System.Drawing.Point(946, 234);
            this.txt_Block_Username.Name = "txt_Block_Username";
            this.txt_Block_Username.Size = new System.Drawing.Size(373, 38);
            this.txt_Block_Username.TabIndex = 13;
            this.txt_Block_Username.TextChanged += new System.EventHandler(this.txt_Block_Username_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(685, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "UserID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(844, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(475, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "Block/Unblock Account Admin Panel";
            // 
            // AdminMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2115, 1029);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminMainGUI";
            this.Text = "AdminMainGUI";
            this.Load += new System.EventHandler(this.AdminMainGUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_BlockName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Block;
        private System.Windows.Forms.ComboBox cmb_BlockRole;
        private System.Windows.Forms.TextBox txt_Block_Username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label10;
    }
}