namespace HealthcareFamily
{
    partial class LoginFailForm
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
            this.cmdLoginAgain = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdLoginAgain
            // 
            this.cmdLoginAgain.Location = new System.Drawing.Point(21, 72);
            this.cmdLoginAgain.Name = "cmdLoginAgain";
            this.cmdLoginAgain.Size = new System.Drawing.Size(82, 23);
            this.cmdLoginAgain.TabIndex = 1;
            this.cmdLoginAgain.Text = "Login again";
            this.cmdLoginAgain.UseVisualStyleBackColor = true;
            this.cmdLoginAgain.Click += new System.EventHandler(this.cmdLoginAgain_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(121, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Forgot password";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wrong Username or Password";
            // 
            // LoginFailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdLoginAgain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFailForm";
            this.Text = "Sign In Fail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLoginAgain;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}