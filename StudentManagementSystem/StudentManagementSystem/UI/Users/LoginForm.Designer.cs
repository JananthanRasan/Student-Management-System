namespace StudentManagementSystem.UI.Users
{
    partial class LoginForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(193, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 38);
            this.btnCancel.TabIndex = 97;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(295, 263);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 38);
            this.btnLogin.TabIndex = 98;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(158, 158);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(233, 35);
            this.txtFirstName.TabIndex = 96;
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherID.Location = new System.Drawing.Point(158, 93);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(233, 35);
            this.txtTeacherID.TabIndex = 95;
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectCode.Location = new System.Drawing.Point(12, 161);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(99, 30);
            this.lblSubjectCode.TabIndex = 93;
            this.lblSubjectCode.Text = "Password";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(12, 96);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(116, 30);
            this.lblSubjectName.TabIndex = 94;
            this.lblSubjectName.Text = "User Name";
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHead.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHead.Location = new System.Drawing.Point(0, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(403, 45);
            this.lblHead.TabIndex = 92;
            this.lblHead.Text = "Login";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(-6, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 1);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.lblSubjectCode);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.lblHead);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}