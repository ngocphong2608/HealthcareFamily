namespace HealthcareFamilyGUI
{
    partial class DoctorInformationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwMeeting = new System.Windows.Forms.ListBox();
            this.cmdMessage = new System.Windows.Forms.Button();
            this.cmdCreateMeeting = new System.Windows.Forms.Button();
            this.cmdDeleteMeeting = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // txtGender
            // 
            this.txtGender.AutoSize = true;
            this.txtGender.Location = new System.Drawing.Point(100, 55);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(35, 13);
            this.txtGender.TabIndex = 5;
            this.txtGender.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(100, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(35, 13);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(100, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvwMeeting
            // 
            this.lvwMeeting.FormattingEnabled = true;
            this.lvwMeeting.Location = new System.Drawing.Point(34, 191);
            this.lvwMeeting.Name = "lvwMeeting";
            this.lvwMeeting.Size = new System.Drawing.Size(352, 147);
            this.lvwMeeting.TabIndex = 1;
            // 
            // cmdMessage
            // 
            this.cmdMessage.Enabled = false;
            this.cmdMessage.Location = new System.Drawing.Point(268, 31);
            this.cmdMessage.Name = "cmdMessage";
            this.cmdMessage.Size = new System.Drawing.Size(118, 23);
            this.cmdMessage.TabIndex = 2;
            this.cmdMessage.Text = "Message";
            this.cmdMessage.UseVisualStyleBackColor = true;
            // 
            // cmdCreateMeeting
            // 
            this.cmdCreateMeeting.Enabled = false;
            this.cmdCreateMeeting.Location = new System.Drawing.Point(268, 76);
            this.cmdCreateMeeting.Name = "cmdCreateMeeting";
            this.cmdCreateMeeting.Size = new System.Drawing.Size(118, 23);
            this.cmdCreateMeeting.TabIndex = 3;
            this.cmdCreateMeeting.Text = "Create Meeting";
            this.cmdCreateMeeting.UseVisualStyleBackColor = true;
            // 
            // cmdDeleteMeeting
            // 
            this.cmdDeleteMeeting.Enabled = false;
            this.cmdDeleteMeeting.Location = new System.Drawing.Point(268, 124);
            this.cmdDeleteMeeting.Name = "cmdDeleteMeeting";
            this.cmdDeleteMeeting.Size = new System.Drawing.Size(118, 23);
            this.cmdDeleteMeeting.TabIndex = 4;
            this.cmdDeleteMeeting.Text = "Delete Meeting";
            this.cmdDeleteMeeting.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(100, 111);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(35, 13);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "label4";
            // 
            // DoctorInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 366);
            this.Controls.Add(this.cmdDeleteMeeting);
            this.Controls.Add(this.cmdCreateMeeting);
            this.Controls.Add(this.cmdMessage);
            this.Controls.Add(this.lvwMeeting);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoctorInformationForm";
            this.Text = "Doctor Information";
            this.Load += new System.EventHandler(this.DoctorInformationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lvwMeeting;
        private System.Windows.Forms.Button cmdMessage;
        private System.Windows.Forms.Button cmdCreateMeeting;
        private System.Windows.Forms.Button cmdDeleteMeeting;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label label2;
    }
}