namespace HealthcareFamilyGUI
{
    partial class SearchingPeopleForm
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
            this.cmdSearch = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lvwPeopleList = new System.Windows.Forms.ListView();
            this.txtPeopleInfo = new System.Windows.Forms.TextBox();
            this.cmdOK = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "People information:";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Image = null;
            this.cmdSearch.Location = new System.Drawing.Point(277, 83);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 2;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseSelectable = true;
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "People list: ";
            // 
            // lvwPeopleList
            // 
            this.lvwPeopleList.Location = new System.Drawing.Point(24, 131);
            this.lvwPeopleList.Name = "lvwPeopleList";
            this.lvwPeopleList.Size = new System.Drawing.Size(328, 166);
            this.lvwPeopleList.TabIndex = 6;
            this.lvwPeopleList.UseCompatibleStateImageBehavior = false;
            // 
            // txtPeopleInfo
            // 
            this.txtPeopleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeopleInfo.Location = new System.Drawing.Point(24, 83);
            this.txtPeopleInfo.Name = "txtPeopleInfo";
            this.txtPeopleInfo.Size = new System.Drawing.Size(247, 23);
            this.txtPeopleInfo.TabIndex = 7;
            // 
            // cmdOK
            // 
            this.cmdOK.Image = null;
            this.cmdOK.Location = new System.Drawing.Point(184, 314);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(168, 35);
            this.cmdOK.TabIndex = 26;
            this.cmdOK.Text = "Next";
            this.cmdOK.UseSelectable = true;
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = null;
            this.cmdCancel.Location = new System.Drawing.Point(24, 314);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(154, 35);
            this.cmdCancel.TabIndex = 27;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseSelectable = true;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // SearchingPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 365);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtPeopleInfo);
            this.Controls.Add(this.lvwPeopleList);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SearchingPeopleForm";
            this.Resizable = false;
            this.Text = "Searching People";
            this.Load += new System.EventHandler(this.SearchingPeopleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdSearch;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ListView lvwPeopleList;
        private System.Windows.Forms.TextBox txtPeopleInfo;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdOK;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdCancel;
    }
}