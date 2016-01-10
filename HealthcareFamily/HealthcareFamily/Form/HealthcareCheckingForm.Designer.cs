using System;
namespace HealthcareFamilyGUI
{
    partial class HealthcareCheckingForm
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
            this.txtHeartBeat = new System.Windows.Forms.TextBox();
            this.txtEmotion = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmdCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdOK = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // txtHeartBeat
            // 
            this.txtHeartBeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeartBeat.Location = new System.Drawing.Point(111, 64);
            this.txtHeartBeat.Name = "txtHeartBeat";
            this.txtHeartBeat.Size = new System.Drawing.Size(241, 22);
            this.txtHeartBeat.TabIndex = 2;
            // 
            // txtEmotion
            // 
            this.txtEmotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmotion.Location = new System.Drawing.Point(111, 92);
            this.txtEmotion.Name = "txtEmotion";
            this.txtEmotion.Size = new System.Drawing.Size(241, 22);
            this.txtEmotion.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Heart Beat:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Emotion:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = null;
            this.cmdCancel.Location = new System.Drawing.Point(25, 139);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(154, 35);
            this.cmdCancel.TabIndex = 29;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseSelectable = true;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Image = null;
            this.cmdOK.Location = new System.Drawing.Point(185, 139);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(168, 35);
            this.cmdOK.TabIndex = 28;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseSelectable = true;
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // HealthcareCheckingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 200);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtEmotion);
            this.Controls.Add(this.txtHeartBeat);
            this.MaximizeBox = false;
            this.Name = "HealthcareCheckingForm";
            this.Resizable = false;
            this.Text = "Heathcare Checking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeartBeat;
        private System.Windows.Forms.TextBox txtEmotion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdCancel;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdOK;
        public String HeartBeat;
        public String Emotion;
        public DateTime Date;
    }
}