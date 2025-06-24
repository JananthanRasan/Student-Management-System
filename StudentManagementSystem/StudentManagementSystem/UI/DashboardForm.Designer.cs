namespace StudentManagementSystem.UI
{
    partial class DashboardForm
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
            this.mnsDashboard = new System.Windows.Forms.MenuStrip();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEACHERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBJECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsDashboard
            // 
            this.mnsDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.tEACHERToolStripMenuItem,
            this.gRADEToolStripMenuItem,
            this.sUBJECTToolStripMenuItem});
            this.mnsDashboard.Location = new System.Drawing.Point(0, 0);
            this.mnsDashboard.Name = "mnsDashboard";
            this.mnsDashboard.Size = new System.Drawing.Size(984, 24);
            this.mnsDashboard.TabIndex = 0;
            this.mnsDashboard.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentsListToolStripMenuItem,
            this.editToolStripMenuItem,
            this.showToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentsListToolStripMenuItem
            // 
            this.studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            this.studentsListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentsListToolStripMenuItem.Text = "Students List";
            this.studentsListToolStripMenuItem.Click += new System.EventHandler(this.studentsListToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit Student";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show Student";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // tEACHERToolStripMenuItem
            // 
            this.tEACHERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTeacherToolStripMenuItem,
            this.teacherListToolStripMenuItem,
            this.editTeacherToolStripMenuItem,
            this.showTeacherToolStripMenuItem});
            this.tEACHERToolStripMenuItem.Name = "tEACHERToolStripMenuItem";
            this.tEACHERToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tEACHERToolStripMenuItem.Text = "TEACHER";
            // 
            // addNewTeacherToolStripMenuItem
            // 
            this.addNewTeacherToolStripMenuItem.Name = "addNewTeacherToolStripMenuItem";
            this.addNewTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewTeacherToolStripMenuItem.Text = "Add New Teacher";
            this.addNewTeacherToolStripMenuItem.Click += new System.EventHandler(this.addNewTeacherToolStripMenuItem_Click);
            // 
            // teacherListToolStripMenuItem
            // 
            this.teacherListToolStripMenuItem.Name = "teacherListToolStripMenuItem";
            this.teacherListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teacherListToolStripMenuItem.Text = "Teacher List";
            this.teacherListToolStripMenuItem.Click += new System.EventHandler(this.teacherListToolStripMenuItem_Click);
            // 
            // editTeacherToolStripMenuItem
            // 
            this.editTeacherToolStripMenuItem.Name = "editTeacherToolStripMenuItem";
            this.editTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editTeacherToolStripMenuItem.Text = "Edit Teacher";
            this.editTeacherToolStripMenuItem.Click += new System.EventHandler(this.editTeacherToolStripMenuItem_Click);
            // 
            // showTeacherToolStripMenuItem
            // 
            this.showTeacherToolStripMenuItem.Name = "showTeacherToolStripMenuItem";
            this.showTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showTeacherToolStripMenuItem.Text = "Show Teacher";
            this.showTeacherToolStripMenuItem.Click += new System.EventHandler(this.showTeacherToolStripMenuItem_Click);
            // 
            // gRADEToolStripMenuItem
            // 
            this.gRADEToolStripMenuItem.Name = "gRADEToolStripMenuItem";
            this.gRADEToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.gRADEToolStripMenuItem.Text = "GRADE";
            this.gRADEToolStripMenuItem.Click += new System.EventHandler(this.gRADEToolStripMenuItem_Click);
            // 
            // sUBJECTToolStripMenuItem
            // 
            this.sUBJECTToolStripMenuItem.Name = "sUBJECTToolStripMenuItem";
            this.sUBJECTToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sUBJECTToolStripMenuItem.Text = "SUBJECT";
            this.sUBJECTToolStripMenuItem.Click += new System.EventHandler(this.sUBJECTToolStripMenuItem_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.mnsDashboard);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsDashboard;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.mnsDashboard.ResumeLayout(false);
            this.mnsDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsDashboard;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEACHERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRADEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBJECTToolStripMenuItem;
    }
}