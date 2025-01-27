namespace session06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddBlog = new Button();
            buttonUserManagment = new Button();
            SuspendLayout();
            // 
            // buttonAddBlog
            // 
            buttonAddBlog.Location = new Point(12, 12);
            buttonAddBlog.Name = "buttonAddBlog";
            buttonAddBlog.Size = new Size(154, 23);
            buttonAddBlog.TabIndex = 0;
            buttonAddBlog.Text = "Add Blog";
            buttonAddBlog.UseVisualStyleBackColor = true;
            buttonAddBlog.Click += buttonAddBlog_Click;
            // 
            // buttonUserManagment
            // 
            buttonUserManagment.Location = new Point(12, 41);
            buttonUserManagment.Name = "buttonUserManagment";
            buttonUserManagment.Size = new Size(154, 23);
            buttonUserManagment.TabIndex = 1;
            buttonUserManagment.Text = "User Managment";
            buttonUserManagment.UseVisualStyleBackColor = true;
            buttonUserManagment.Click += buttonUserManagment_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 380);
            Controls.Add(buttonUserManagment);
            Controls.Add(buttonAddBlog);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddBlog;
        private Button buttonUserManagment;
    }
}
