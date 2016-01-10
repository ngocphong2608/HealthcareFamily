namespace HealthcareFamilyGUI
{
    partial class NotificationForm
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
            this.lvwNotification = new System.Windows.Forms.ListView();
            this.cmdOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // lvwNotification
            // 
            this.lvwNotification.Location = new System.Drawing.Point(24, 63);
            this.lvwNotification.Name = "lvwNotification";
            this.lvwNotification.Size = new System.Drawing.Size(325, 333);
            this.lvwNotification.TabIndex = 1;
            this.lvwNotification.UseCompatibleStateImageBehavior = false;
            // 
            // cmdOk
            // 
            this.cmdOk.Image = null;
            this.cmdOk.Location = new System.Drawing.Point(105, 417);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(160, 35);
            this.cmdOk.TabIndex = 26;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseSelectable = true;
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 475);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.lvwNotification);
            this.MaximizeBox = false;
            this.Name = "NotificationForm";
            this.Resizable = false;
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwNotification;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdOk;

    }
}