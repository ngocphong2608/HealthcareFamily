using HealthcareFamilyGUI.FormArguments;
namespace HealthcareFamilyGUI
{
    partial class SignUpSecondStepForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.cboGender = new MetroFramework.Controls.MetroComboBox();
            this.dtpBirthday = new MetroFramework.Controls.MetroDateTime();
            this.cmdBack = new MetroFramework.Controls.MetroButton();
            this.cmdFinish = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(102, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Full Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(102, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Gender";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(102, 210);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Birthday";
            // 
            // txtFullName
            // 
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(197, 105);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.Size = new System.Drawing.Size(230, 23);
            this.txtFullName.TabIndex = 14;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.ItemHeight = 23;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female ",
            "Other"});
            this.cboGender.Location = new System.Drawing.Point(197, 148);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(230, 29);
            this.cboGender.TabIndex = 15;
            this.cboGender.UseSelectable = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(197, 200);
            this.dtpBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(230, 29);
            this.dtpBirthday.TabIndex = 16;
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(50, 300);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(200, 30);
            this.cmdBack.TabIndex = 17;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseSelectable = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdFinish
            // 
            this.cmdFinish.Location = new System.Drawing.Point(300, 300);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(200, 30);
            this.cmdFinish.TabIndex = 18;
            this.cmdFinish.Text = "Finish";
            this.cmdFinish.UseSelectable = true;
            this.cmdFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // SignUpSecondStepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 370);
            this.Controls.Add(this.cmdFinish);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpSecondStepForm";
            this.Text = "Create New Account - Step 2";
            this.Load += new System.EventHandler(this.SignUpSecondStepForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private MetroFramework.Controls.MetroComboBox cboGender;
        private MetroFramework.Controls.MetroDateTime dtpBirthday;
        private MetroFramework.Controls.MetroButton cmdBack;
        private MetroFramework.Controls.MetroButton cmdFinish;
        public SignUpSecondStepFromArguments userControler { get; set; }
    }
}