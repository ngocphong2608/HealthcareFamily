namespace HealthcareFamilyGUI
{
    partial class RequestUserForm
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
            this.cmdDeleteUser = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdAcceptUser = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.listRequestUser = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Image = null;
            this.cmdOK.Location = new System.Drawing.Point(106, 418);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(160, 35);
            this.cmdOK.TabIndex = 30;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseSelectable = true;
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdDeleteUser
            // 
            this.cmdDeleteUser.Image = null;
            this.cmdDeleteUser.Location = new System.Drawing.Point(190, 75);
            this.cmdDeleteUser.Name = "cmdDeleteUser";
            this.cmdDeleteUser.Size = new System.Drawing.Size(160, 35);
            this.cmdDeleteUser.TabIndex = 29;
            this.cmdDeleteUser.Text = "Delete User";
            this.cmdDeleteUser.UseSelectable = true;
            this.cmdDeleteUser.UseVisualStyleBackColor = true;
            // 
            // cmdAcceptUser
            // 
            this.cmdAcceptUser.Image = null;
            this.cmdAcceptUser.Location = new System.Drawing.Point(24, 75);
            this.cmdAcceptUser.Name = "cmdAcceptUser";
            this.cmdAcceptUser.Size = new System.Drawing.Size(160, 35);
            this.cmdAcceptUser.TabIndex = 28;
            this.cmdAcceptUser.Text = "Accept User";
            this.cmdAcceptUser.UseSelectable = true;
            this.cmdAcceptUser.UseVisualStyleBackColor = true;
            // 
            // listRequestUser
            // 
            this.listRequestUser.Location = new System.Drawing.Point(25, 116);
            this.listRequestUser.Name = "listRequestUser";
            this.listRequestUser.Size = new System.Drawing.Size(325, 281);
            this.listRequestUser.TabIndex = 27;
            this.listRequestUser.UseCompatibleStateImageBehavior = false;
            // 
            // RequestUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 500);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdDeleteUser);
            this.Controls.Add(this.cmdAcceptUser);
            this.Controls.Add(this.listRequestUser);
            this.MaximizeBox = false;
            this.Name = "RequestUserForm";
            this.Resizable = false;
            this.Text = "Request New User";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdOK;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdDeleteUser;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdAcceptUser;
        private System.Windows.Forms.ListView listRequestUser;
    }
}