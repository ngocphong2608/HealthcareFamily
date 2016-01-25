using HealthcareFamilyGUI.FormArguments;
namespace HealthcareFamilyGUI
{
    partial class SearchingRelationshipForm
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
            this.cbRelationship = new MetroFramework.Controls.MetroComboBox();
            this.cmdBack = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdFinish = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Choose Relationship";
            // 
            // cbRelationship
            // 
            this.cbRelationship.FormattingEnabled = true;
            this.cbRelationship.ItemHeight = 23;
            this.cbRelationship.Location = new System.Drawing.Point(24, 83);
            this.cbRelationship.Name = "cbRelationship";
            this.cbRelationship.Size = new System.Drawing.Size(328, 29);
            this.cbRelationship.TabIndex = 1;
            this.cbRelationship.UseSelectable = true;
            // 
            // cmdBack
            // 
            this.cmdBack.Image = null;
            this.cmdBack.Location = new System.Drawing.Point(23, 127);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(154, 35);
            this.cmdBack.TabIndex = 29;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseSelectable = true;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdFinish
            // 
            this.cmdFinish.Image = null;
            this.cmdFinish.Location = new System.Drawing.Point(183, 127);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(168, 35);
            this.cmdFinish.TabIndex = 28;
            this.cmdFinish.Text = "Finish";
            this.cmdFinish.UseSelectable = true;
            this.cmdFinish.UseVisualStyleBackColor = true;
            this.cmdFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // SearchingRelationshipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 180);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdFinish);
            this.Controls.Add(this.cbRelationship);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "SearchingRelationshipForm";
            this.Text = "Choose Relationship";
            this.Load += new System.EventHandler(this.SearchingRelationshipForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbRelationship;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdBack;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdFinish;
        private SearchingRelationshipFormArguments Arguments;
    }
}