using HealthcareFamilyGUI.FormArguments;
namespace HealthcareFamilyGUI
{
    partial class CreateMeetingForm
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
            this.cbDoctor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtTime = new MetroFramework.Controls.MetroDateTime();
            this.cmdCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdOK = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbHour = new MetroFramework.Controls.MetroComboBox();
            this.cbMinute = new MetroFramework.Controls.MetroComboBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Doctor:";
            // 
            // cbDoctor
            // 
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.ItemHeight = 23;
            this.cbDoctor.Location = new System.Drawing.Point(110, 71);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(242, 29);
            this.cbDoctor.TabIndex = 1;
            this.cbDoctor.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Date:";
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(110, 106);
            this.dtTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(242, 29);
            this.dtTime.TabIndex = 3;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = null;
            this.cmdCancel.Location = new System.Drawing.Point(24, 312);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(154, 35);
            this.cmdCancel.TabIndex = 31;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseSelectable = true;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Image = null;
            this.cmdOK.Location = new System.Drawing.Point(184, 312);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(168, 35);
            this.cmdOK.TabIndex = 30;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseSelectable = true;
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(104, 145);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Hour:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(226, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Minute:";
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.ItemHeight = 23;
            this.cbHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbHour.Location = new System.Drawing.Point(152, 142);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(63, 29);
            this.cbHour.TabIndex = 36;
            this.cbHour.UseSelectable = true;
            // 
            // cbMinute
            // 
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.ItemHeight = 23;
            this.cbMinute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMinute.Location = new System.Drawing.Point(288, 142);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(63, 29);
            this.cbMinute.TabIndex = 37;
            this.cbMinute.UseSelectable = true;
            // 
            // txtDetail
            // 
            this.txtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.Location = new System.Drawing.Point(110, 182);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(242, 114);
            this.txtDetail.TabIndex = 38;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 182);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Text = "Detail:";
            // 
            // CreateMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 360);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.cbMinute);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "CreateMeetingForm";
            this.Resizable = false;
            this.Text = "Create Meeting";
            this.Load += new System.EventHandler(this.CreateMeetingAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbDoctor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtTime;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdCancel;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdOK;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbHour;
        private MetroFramework.Controls.MetroComboBox cbMinute;
        private CreateMeetingFormArguments Arguments;
        private System.Windows.Forms.TextBox txtDetail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}