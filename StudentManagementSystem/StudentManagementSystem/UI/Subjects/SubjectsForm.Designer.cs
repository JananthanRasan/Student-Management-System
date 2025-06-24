namespace StudentManagementSystem.UI.Subjects
{
    partial class SubjectsForm
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
            this.lblHead = new System.Windows.Forms.Label();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(895, 45);
            this.lblHead.TabIndex = 1;
            this.lblHead.Text = "Subjects";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(12, 105);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.Size = new System.Drawing.Size(469, 258);
            this.dgvSubjects.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 33);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Text = "search";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(188, 410);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(123, 37);
            this.btnAddStudent.TabIndex = 14;
            this.btnAddStudent.Text = "Add Grade";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(12, 410);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 37);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(100, 410);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 37);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(448, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 37);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(536, 410);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 37);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(624, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 37);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(712, 410);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 37);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(800, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 37);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(-2, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 1);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(667, 228);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(211, 35);
            this.txtFirstName.TabIndex = 27;
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherID.Location = new System.Drawing.Point(667, 155);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(211, 35);
            this.txtTeacherID.TabIndex = 26;
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectCode.Location = new System.Drawing.Point(494, 233);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(135, 30);
            this.lblSubjectCode.TabIndex = 24;
            this.lblSubjectCode.Text = "Subject Code";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(494, 160);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(143, 30);
            this.lblSubjectName.TabIndex = 25;
            this.lblSubjectName.Text = "Subject Name";
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Location = new System.Drawing.Point(317, 410);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(125, 37);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(487, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1, 347);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(188, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 37);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 463);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.lblSubjectCode);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.lblHead);
            this.Name = "SubjectsForm";
            this.Text = "Subjects";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
    }
}