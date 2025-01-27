namespace session06.UI;

partial class UsersForm
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
        groupBoxUsers = new GroupBox();
        dataGridViewUsers = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
        SuspendLayout();
        // 
        // groupBoxUsers
        // 
        groupBoxUsers.Location = new Point(12, 12);
        groupBoxUsers.Name = "groupBoxUsers";
        groupBoxUsers.Size = new Size(742, 249);
        groupBoxUsers.TabIndex = 0;
        groupBoxUsers.TabStop = false;
        groupBoxUsers.Text = "groupBoxUsers";
        groupBoxUsers.Enter += groupBoxUsers_Enter;
        // 
        // dataGridViewUsers
        // 
        dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewUsers.Location = new Point(12, 267);
        dataGridViewUsers.Name = "dataGridViewUsers";
        dataGridViewUsers.Size = new Size(742, 275);
        dataGridViewUsers.TabIndex = 1;
        // 
        // UsersForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(766, 554);
        Controls.Add(dataGridViewUsers);
        Controls.Add(groupBoxUsers);
        Name = "UsersForm";
        Text = "UsersForm";
        Load += UsersForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxUsers;
    private DataGridView dataGridViewUsers;
}