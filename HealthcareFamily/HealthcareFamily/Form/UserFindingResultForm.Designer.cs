namespace HealthcareFamily
{
    partial class UserFindingResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvwFriendResult = new System.Windows.Forms.ListBox();
            this.cmdNext = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIND FRIEND RESULT";
            // 
            // lvwFriendResult
            // 
            this.lvwFriendResult.FormattingEnabled = true;
            this.lvwFriendResult.Location = new System.Drawing.Point(12, 50);
            this.lvwFriendResult.Name = "lvwFriendResult";
            this.lvwFriendResult.Size = new System.Drawing.Size(270, 121);
            this.lvwFriendResult.TabIndex = 1;
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(161, 189);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(75, 23);
            this.cmdNext.TabIndex = 2;
            this.cmdNext.Text = "Next";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(45, 189);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(75, 23);
            this.cmdBack.TabIndex = 3;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // UserFindingResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 236);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.lvwFriendResult);
            this.Controls.Add(this.label1);
            this.Name = "UserFindingResultForm";
            this.Text = "User Finding Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lvwFriendResult;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button cmdBack;
    }
}