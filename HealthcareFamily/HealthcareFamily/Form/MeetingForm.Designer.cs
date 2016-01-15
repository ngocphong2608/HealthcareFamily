using HealthcareFamilyGUI.FormArguments;
namespace HealthcareFamilyGUI
{
    partial class MeetingForm
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
            this.cmdOK = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdDeleteMeeting = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdCreateMeeting = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.lvwMeeting = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Image = null;
            this.cmdOK.Location = new System.Drawing.Point(105, 406);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(160, 35);
            this.cmdOK.TabIndex = 30;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseSelectable = true;
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdDeleteMeeting
            // 
            this.cmdDeleteMeeting.Image = null;
            this.cmdDeleteMeeting.Location = new System.Drawing.Point(189, 63);
            this.cmdDeleteMeeting.Name = "cmdDeleteMeeting";
            this.cmdDeleteMeeting.Size = new System.Drawing.Size(160, 35);
            this.cmdDeleteMeeting.TabIndex = 29;
            this.cmdDeleteMeeting.Text = "Delete Meeting";
            this.cmdDeleteMeeting.UseSelectable = true;
            this.cmdDeleteMeeting.UseVisualStyleBackColor = true;
            // 
            // cmdCreateMeeting
            // 
            this.cmdCreateMeeting.Image = null;
            this.cmdCreateMeeting.Location = new System.Drawing.Point(23, 63);
            this.cmdCreateMeeting.Name = "cmdCreateMeeting";
            this.cmdCreateMeeting.Size = new System.Drawing.Size(160, 35);
            this.cmdCreateMeeting.TabIndex = 28;
            this.cmdCreateMeeting.Text = "Create Meeting";
            this.cmdCreateMeeting.UseSelectable = true;
            this.cmdCreateMeeting.UseVisualStyleBackColor = true;
            this.cmdCreateMeeting.Click += new System.EventHandler(this.cmdCreateMeeting_Click);
            // 
            // lvwMeeting
            // 
            this.lvwMeeting.Location = new System.Drawing.Point(24, 104);
            this.lvwMeeting.Name = "lvwMeeting";
            this.lvwMeeting.Size = new System.Drawing.Size(325, 281);
            this.lvwMeeting.TabIndex = 27;
            this.lvwMeeting.UseCompatibleStateImageBehavior = false;
            // 
            // MeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 465);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdDeleteMeeting);
            this.Controls.Add(this.cmdCreateMeeting);
            this.Controls.Add(this.lvwMeeting);
            this.MaximizeBox = false;
            this.Name = "MeetingForm";
            this.Resizable = false;
            this.Text = "Meeting";
            this.Load += new System.EventHandler(this.MeetingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdOK;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdDeleteMeeting;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdCreateMeeting;
        private System.Windows.Forms.ListView lvwMeeting;
        MeetingFormArguments Arguments;


    }
}