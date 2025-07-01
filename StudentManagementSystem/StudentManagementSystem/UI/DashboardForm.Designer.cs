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
            this.tEACHERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBJECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsDashboard
            // 
            this.mnsDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.mnsDashboard.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnsDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.tEACHERToolStripMenuItem,
            this.gRADEToolStripMenuItem,
            this.sUBJECTToolStripMenuItem,
            this.uSERToolStripMenuItem});
            this.mnsDashboard.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnsDashboard.Location = new System.Drawing.Point(0, 0);
            this.mnsDashboard.Name = "mnsDashboard";
            this.mnsDashboard.Size = new System.Drawing.Size(1184, 33);
            this.mnsDashboard.TabIndex = 0;
            this.mnsDashboard.Text = "Dashboard";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentsListToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sTUDENTToolStripMenuItem.Image = global::StudentManagementSystem.Properties.Resources.reading;
            this.sTUDENTToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sTUDENTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            this.sTUDENTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addNewStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentsListToolStripMenuItem
            // 
            this.studentsListToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.studentsListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            this.studentsListToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.studentsListToolStripMenuItem.Text = "Students List";
            this.studentsListToolStripMenuItem.Click += new System.EventHandler(this.studentsListToolStripMenuItem_Click);
            // 
            // tEACHERToolStripMenuItem
            // 
            this.tEACHERToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.tEACHERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTeacherToolStripMenuItem,
            this.teacherListToolStripMenuItem});
            this.tEACHERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEACHERToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tEACHERToolStripMenuItem.Image = global::StudentManagementSystem.Properties.Resources.teacher;
            this.tEACHERToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tEACHERToolStripMenuItem.Name = "tEACHERToolStripMenuItem";
            this.tEACHERToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.tEACHERToolStripMenuItem.Text = "TEACHER";
            this.tEACHERToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addNewTeacherToolStripMenuItem
            // 
            this.addNewTeacherToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addNewTeacherToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTeacherToolStripMenuItem.Name = "addNewTeacherToolStripMenuItem";
            this.addNewTeacherToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.addNewTeacherToolStripMenuItem.Text = "Add New Teacher";
            this.addNewTeacherToolStripMenuItem.Click += new System.EventHandler(this.addNewTeacherToolStripMenuItem_Click);
            // 
            // teacherListToolStripMenuItem
            // 
            this.teacherListToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.teacherListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherListToolStripMenuItem.Name = "teacherListToolStripMenuItem";
            this.teacherListToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.teacherListToolStripMenuItem.Text = "Teacher List";
            this.teacherListToolStripMenuItem.Click += new System.EventHandler(this.teacherListToolStripMenuItem_Click);
            // 
            // gRADEToolStripMenuItem
            // 
            this.gRADEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.gRADEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gRADEToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.gRADEToolStripMenuItem.Image = global::StudentManagementSystem.Properties.Resources.online_learning;
            this.gRADEToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gRADEToolStripMenuItem.Name = "gRADEToolStripMenuItem";
            this.gRADEToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.gRADEToolStripMenuItem.Text = "GRADE";
            this.gRADEToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gRADEToolStripMenuItem.Click += new System.EventHandler(this.gRADEToolStripMenuItem_Click);
            // 
            // sUBJECTToolStripMenuItem
            // 
            this.sUBJECTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.sUBJECTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUBJECTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sUBJECTToolStripMenuItem.Image = global::StudentManagementSystem.Properties.Resources.book;
            this.sUBJECTToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sUBJECTToolStripMenuItem.Name = "sUBJECTToolStripMenuItem";
            this.sUBJECTToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.sUBJECTToolStripMenuItem.Text = "SUBJECT";
            this.sUBJECTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sUBJECTToolStripMenuItem.Click += new System.EventHandler(this.sUBJECTToolStripMenuItem_Click);
            // 
            // uSERToolStripMenuItem
            // 
            this.uSERToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.uSERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem});
            this.uSERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSERToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uSERToolStripMenuItem.Image = global::StudentManagementSystem.Properties.Resources.user__1_;
            this.uSERToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uSERToolStripMenuItem.Name = "uSERToolStripMenuItem";
            this.uSERToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.uSERToolStripMenuItem.Text = "USER";
            this.uSERToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addNewUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
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
        private System.Windows.Forms.ToolStripMenuItem tEACHERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRADEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBJECTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
    }
}