namespace ArtisAdmin
{
    partial class ManageUsers
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFoundNotes = new System.Windows.Forms.Label();
            this.lblFoundDateCreated = new System.Windows.Forms.Label();
            this.lblFoundPrivLevel = new System.Windows.Forms.Label();
            this.lblFoundUser = new System.Windows.Forms.Label();
            this.lblCurNotes = new System.Windows.Forms.Label();
            this.lblCurDateCreated = new System.Windows.Forms.Label();
            this.lblCurPrivLevel = new System.Windows.Forms.Label();
            this.lblCurUser = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.txtEditNotes = new System.Windows.Forms.TextBox();
            this.comboPrivLevel = new System.Windows.Forms.ComboBox();
            this.lblUpdateNotes = new System.Windows.Forms.Label();
            this.lblUpdatePrivLevel = new System.Windows.Forms.Label();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.txtEditUserName = new System.Windows.Forms.TextBox();
            this.lblUpdatePassword = new System.Windows.Forms.Label();
            this.lblUpdateUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFindUsername = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFindByNotes = new System.Windows.Forms.Button();
            this.txtFindByNotes = new System.Windows.Forms.TextBox();
            this.lblFindByNotes = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFoundNotes);
            this.groupBox2.Controls.Add(this.lblFoundDateCreated);
            this.groupBox2.Controls.Add(this.lblFoundPrivLevel);
            this.groupBox2.Controls.Add(this.lblFoundUser);
            this.groupBox2.Controls.Add(this.lblCurNotes);
            this.groupBox2.Controls.Add(this.lblCurDateCreated);
            this.groupBox2.Controls.Add(this.lblCurPrivLevel);
            this.groupBox2.Controls.Add(this.lblCurUser);
            this.groupBox2.Location = new System.Drawing.Point(253, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 172);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current User Info";
            // 
            // lblFoundNotes
            // 
            this.lblFoundNotes.AutoSize = true;
            this.lblFoundNotes.Location = new System.Drawing.Point(95, 120);
            this.lblFoundNotes.Name = "lblFoundNotes";
            this.lblFoundNotes.Size = new System.Drawing.Size(41, 13);
            this.lblFoundNotes.TabIndex = 7;
            this.lblFoundNotes.Text = "label12";
            // 
            // lblFoundDateCreated
            // 
            this.lblFoundDateCreated.AutoSize = true;
            this.lblFoundDateCreated.Location = new System.Drawing.Point(95, 92);
            this.lblFoundDateCreated.Name = "lblFoundDateCreated";
            this.lblFoundDateCreated.Size = new System.Drawing.Size(41, 13);
            this.lblFoundDateCreated.TabIndex = 6;
            this.lblFoundDateCreated.Text = "label11";
            // 
            // lblFoundPrivLevel
            // 
            this.lblFoundPrivLevel.AutoSize = true;
            this.lblFoundPrivLevel.Location = new System.Drawing.Point(95, 56);
            this.lblFoundPrivLevel.Name = "lblFoundPrivLevel";
            this.lblFoundPrivLevel.Size = new System.Drawing.Size(41, 13);
            this.lblFoundPrivLevel.TabIndex = 5;
            this.lblFoundPrivLevel.Text = "label10";
            // 
            // lblFoundUser
            // 
            this.lblFoundUser.AutoSize = true;
            this.lblFoundUser.Location = new System.Drawing.Point(95, 24);
            this.lblFoundUser.Name = "lblFoundUser";
            this.lblFoundUser.Size = new System.Drawing.Size(35, 13);
            this.lblFoundUser.TabIndex = 4;
            this.lblFoundUser.Text = "label5";
            // 
            // lblCurNotes
            // 
            this.lblCurNotes.AutoSize = true;
            this.lblCurNotes.Location = new System.Drawing.Point(10, 120);
            this.lblCurNotes.Name = "lblCurNotes";
            this.lblCurNotes.Size = new System.Drawing.Size(41, 13);
            this.lblCurNotes.TabIndex = 3;
            this.lblCurNotes.Text = "Notes: ";
            // 
            // lblCurDateCreated
            // 
            this.lblCurDateCreated.AutoSize = true;
            this.lblCurDateCreated.Location = new System.Drawing.Point(10, 88);
            this.lblCurDateCreated.Name = "lblCurDateCreated";
            this.lblCurDateCreated.Size = new System.Drawing.Size(76, 13);
            this.lblCurDateCreated.TabIndex = 2;
            this.lblCurDateCreated.Text = "Date Created: ";
            // 
            // lblCurPrivLevel
            // 
            this.lblCurPrivLevel.AutoSize = true;
            this.lblCurPrivLevel.Location = new System.Drawing.Point(10, 56);
            this.lblCurPrivLevel.Name = "lblCurPrivLevel";
            this.lblCurPrivLevel.Size = new System.Drawing.Size(79, 13);
            this.lblCurPrivLevel.TabIndex = 1;
            this.lblCurPrivLevel.Text = "Privilege Level:";
            // 
            // lblCurUser
            // 
            this.lblCurUser.AutoSize = true;
            this.lblCurUser.Location = new System.Drawing.Point(10, 24);
            this.lblCurUser.Name = "lblCurUser";
            this.lblCurUser.Size = new System.Drawing.Size(58, 13);
            this.lblCurUser.TabIndex = 0;
            this.lblCurUser.Text = "Username:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(403, 351);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(474, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete...";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(545, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.txtEditNotes);
            this.grpUpdate.Controls.Add(this.comboPrivLevel);
            this.grpUpdate.Controls.Add(this.lblUpdateNotes);
            this.grpUpdate.Controls.Add(this.lblUpdatePrivLevel);
            this.grpUpdate.Controls.Add(this.txtEditPassword);
            this.grpUpdate.Controls.Add(this.txtEditUserName);
            this.grpUpdate.Controls.Add(this.lblUpdatePassword);
            this.grpUpdate.Controls.Add(this.lblUpdateUser);
            this.grpUpdate.Location = new System.Drawing.Point(397, 190);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(213, 155);
            this.grpUpdate.TabIndex = 22;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update User Info";
            // 
            // txtEditNotes
            // 
            this.txtEditNotes.Location = new System.Drawing.Point(87, 117);
            this.txtEditNotes.Name = "txtEditNotes";
            this.txtEditNotes.Size = new System.Drawing.Size(121, 20);
            this.txtEditNotes.TabIndex = 23;
            // 
            // comboPrivLevel
            // 
            this.comboPrivLevel.FormattingEnabled = true;
            this.comboPrivLevel.Location = new System.Drawing.Point(87, 80);
            this.comboPrivLevel.Name = "comboPrivLevel";
            this.comboPrivLevel.Size = new System.Drawing.Size(121, 21);
            this.comboPrivLevel.TabIndex = 22;
            // 
            // lblUpdateNotes
            // 
            this.lblUpdateNotes.AutoSize = true;
            this.lblUpdateNotes.Location = new System.Drawing.Point(5, 120);
            this.lblUpdateNotes.Name = "lblUpdateNotes";
            this.lblUpdateNotes.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateNotes.TabIndex = 21;
            this.lblUpdateNotes.Text = "Notes";
            // 
            // lblUpdatePrivLevel
            // 
            this.lblUpdatePrivLevel.AutoSize = true;
            this.lblUpdatePrivLevel.Location = new System.Drawing.Point(5, 83);
            this.lblUpdatePrivLevel.Name = "lblUpdatePrivLevel";
            this.lblUpdatePrivLevel.Size = new System.Drawing.Size(76, 13);
            this.lblUpdatePrivLevel.TabIndex = 20;
            this.lblUpdatePrivLevel.Text = "Privilege Level";
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Location = new System.Drawing.Point(87, 48);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.Size = new System.Drawing.Size(121, 20);
            this.txtEditPassword.TabIndex = 19;
            // 
            // txtEditUserName
            // 
            this.txtEditUserName.Location = new System.Drawing.Point(87, 18);
            this.txtEditUserName.Name = "txtEditUserName";
            this.txtEditUserName.Size = new System.Drawing.Size(121, 20);
            this.txtEditUserName.TabIndex = 18;
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.Location = new System.Drawing.Point(5, 51);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(53, 13);
            this.lblUpdatePassword.TabIndex = 17;
            this.lblUpdatePassword.Text = "Password";
            // 
            // lblUpdateUser
            // 
            this.lblUpdateUser.AutoSize = true;
            this.lblUpdateUser.Location = new System.Drawing.Point(5, 21);
            this.lblUpdateUser.Name = "lblUpdateUser";
            this.lblUpdateUser.Size = new System.Drawing.Size(61, 13);
            this.lblUpdateUser.TabIndex = 16;
            this.lblUpdateUser.Text = "Username: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblFindUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 80);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Username";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(154, 51);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find...";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(97, 17);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblFindUsername
            // 
            this.lblFindUsername.AutoSize = true;
            this.lblFindUsername.Location = new System.Drawing.Point(33, 20);
            this.lblFindUsername.Name = "lblFindUsername";
            this.lblFindUsername.Size = new System.Drawing.Size(58, 13);
            this.lblFindUsername.TabIndex = 0;
            this.lblFindUsername.Text = "Username:";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AllowUserToOrderColumns = true;
            this.dgvSearchResults.AllowUserToResizeColumns = false;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Notes});
            this.dgvSearchResults.Location = new System.Drawing.Point(6, 19);
            this.dgvSearchResults.MultiSelect = false;
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowHeadersVisible = false;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(365, 159);
            this.dgvSearchResults.TabIndex = 27;
            this.dgvSearchResults.SelectionChanged += new System.EventHandler(this.dgvSearchResults_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFindByNotes);
            this.groupBox3.Controls.Add(this.txtFindByNotes);
            this.groupBox3.Controls.Add(this.lblFindByNotes);
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 80);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search By Notes";
            // 
            // btnFindByNotes
            // 
            this.btnFindByNotes.Location = new System.Drawing.Point(154, 51);
            this.btnFindByNotes.Name = "btnFindByNotes";
            this.btnFindByNotes.Size = new System.Drawing.Size(75, 23);
            this.btnFindByNotes.TabIndex = 2;
            this.btnFindByNotes.Text = "Find...";
            this.btnFindByNotes.UseVisualStyleBackColor = true;
            this.btnFindByNotes.Click += new System.EventHandler(this.btnFindByNotes_Click);
            // 
            // txtFindByNotes
            // 
            this.txtFindByNotes.Location = new System.Drawing.Point(97, 17);
            this.txtFindByNotes.Name = "txtFindByNotes";
            this.txtFindByNotes.Size = new System.Drawing.Size(132, 20);
            this.txtFindByNotes.TabIndex = 1;
            // 
            // lblFindByNotes
            // 
            this.lblFindByNotes.AutoSize = true;
            this.lblFindByNotes.Location = new System.Drawing.Point(33, 20);
            this.lblFindByNotes.Name = "lblFindByNotes";
            this.lblFindByNotes.Size = new System.Drawing.Size(41, 13);
            this.lblFindByNotes.TabIndex = 0;
            this.lblFindByNotes.Text = "Notes: ";
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.dgvSearchResults);
            this.grpResults.Location = new System.Drawing.Point(12, 190);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(379, 184);
            this.grpResults.TabIndex = 30;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Search Results";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 137;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Notes.Width = 208;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 386);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFoundNotes;
        private System.Windows.Forms.Label lblFoundDateCreated;
        private System.Windows.Forms.Label lblFoundPrivLevel;
        private System.Windows.Forms.Label lblFoundUser;
        private System.Windows.Forms.Label lblCurNotes;
        private System.Windows.Forms.Label lblCurDateCreated;
        private System.Windows.Forms.Label lblCurPrivLevel;
        private System.Windows.Forms.Label lblCurUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.TextBox txtEditNotes;
        private System.Windows.Forms.ComboBox comboPrivLevel;
        private System.Windows.Forms.Label lblUpdateNotes;
        private System.Windows.Forms.Label lblUpdatePrivLevel;
        private System.Windows.Forms.TextBox txtEditPassword;
        private System.Windows.Forms.TextBox txtEditUserName;
        private System.Windows.Forms.Label lblUpdatePassword;
        private System.Windows.Forms.Label lblUpdateUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFindUsername;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFindByNotes;
        private System.Windows.Forms.TextBox txtFindByNotes;
        private System.Windows.Forms.Label lblFindByNotes;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}