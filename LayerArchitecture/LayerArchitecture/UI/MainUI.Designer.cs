namespace LayerArchitecture.UI
{
    partial class MainUI
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
            this.studentEntryButton = new System.Windows.Forms.Button();
            this.departmentEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentEntryButton
            // 
            this.studentEntryButton.Location = new System.Drawing.Point(53, 34);
            this.studentEntryButton.Name = "studentEntryButton";
            this.studentEntryButton.Size = new System.Drawing.Size(188, 49);
            this.studentEntryButton.TabIndex = 0;
            this.studentEntryButton.Text = "Student Entry";
            this.studentEntryButton.UseVisualStyleBackColor = true;
            this.studentEntryButton.Click += new System.EventHandler(this.studentEntryButton_Click);
            // 
            // departmentEntryButton
            // 
            this.departmentEntryButton.Location = new System.Drawing.Point(53, 101);
            this.departmentEntryButton.Name = "departmentEntryButton";
            this.departmentEntryButton.Size = new System.Drawing.Size(188, 53);
            this.departmentEntryButton.TabIndex = 0;
            this.departmentEntryButton.Text = "Department Entry";
            this.departmentEntryButton.UseVisualStyleBackColor = true;
            this.departmentEntryButton.Click += new System.EventHandler(this.departmentEntryButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.departmentEntryButton);
            this.Controls.Add(this.studentEntryButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentEntryButton;
        private System.Windows.Forms.Button departmentEntryButton;
    }
}