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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmdDeleteNotification = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdRefeshNotification = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(24, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(325, 281);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cmdDeleteNotification
            // 
            this.cmdDeleteNotification.Image = null;
            this.cmdDeleteNotification.Location = new System.Drawing.Point(189, 74);
            this.cmdDeleteNotification.Name = "cmdDeleteNotification";
            this.cmdDeleteNotification.Size = new System.Drawing.Size(160, 35);
            this.cmdDeleteNotification.TabIndex = 17;
            this.cmdDeleteNotification.Text = "Delete Notification";
            this.cmdDeleteNotification.UseSelectable = true;
            this.cmdDeleteNotification.UseVisualStyleBackColor = true;
            // 
            // cmdRefeshNotification
            // 
            this.cmdRefeshNotification.Image = null;
            this.cmdRefeshNotification.Location = new System.Drawing.Point(23, 74);
            this.cmdRefeshNotification.Name = "cmdRefeshNotification";
            this.cmdRefeshNotification.Size = new System.Drawing.Size(160, 35);
            this.cmdRefeshNotification.TabIndex = 16;
            this.cmdRefeshNotification.Text = "Refesh Notification";
            this.cmdRefeshNotification.UseSelectable = true;
            this.cmdRefeshNotification.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.cmdDeleteNotification);
            this.Controls.Add(this.cmdRefeshNotification);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "NotificationForm";
            this.Resizable = false;
            this.Text = "Notification";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdDeleteNotification;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdRefeshNotification;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdOk;

    }
}