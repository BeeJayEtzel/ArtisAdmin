namespace ArtisAdmin
{
    partial class UsageStatistics
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
            this.grpTopUsers = new System.Windows.Forms.GroupBox();
            this.dgvTopUsers = new System.Windows.Forms.DataGridView();
            this.resrank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ago2Sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbxResourceUsage = new System.Windows.Forms.PictureBox();
            this.grpResourceUsage = new System.Windows.Forms.GroupBox();
            this.grpConference = new System.Windows.Forms.GroupBox();
            this.lblConfereceAgoData = new System.Windows.Forms.Label();
            this.lblConferenceLastData = new System.Windows.Forms.Label();
            this.lblConferenceCurData = new System.Windows.Forms.Label();
            this.lblConferenceAgo2Sem = new System.Windows.Forms.Label();
            this.lblConferenceCur = new System.Windows.Forms.Label();
            this.lblConferenceLast = new System.Windows.Forms.Label();
            this.grpStadiumPod = new System.Windows.Forms.GroupBox();
            this.lblStadiumAgoData = new System.Windows.Forms.Label();
            this.lblStadiumLastData = new System.Windows.Forms.Label();
            this.lblStadiumCurData = new System.Windows.Forms.Label();
            this.lblStadiumAgo2Sem = new System.Windows.Forms.Label();
            this.lblStadiumCur = new System.Windows.Forms.Label();
            this.lblStadiumLast = new System.Windows.Forms.Label();
            this.grpBreakOut = new System.Windows.Forms.GroupBox();
            this.lblBreakOutLastData = new System.Windows.Forms.Label();
            this.lblBreakOutAgoData = new System.Windows.Forms.Label();
            this.lblBreakOutCurData = new System.Windows.Forms.Label();
            this.lblBreakOutAgo2Sem = new System.Windows.Forms.Label();
            this.lblBreakOutCur = new System.Windows.Forms.Label();
            this.lblBreakOutLast = new System.Windows.Forms.Label();
            this.grpEastD = new System.Windows.Forms.GroupBox();
            this.lblEastDAgoData = new System.Windows.Forms.Label();
            this.lblEastDLastData = new System.Windows.Forms.Label();
            this.lblEastDCurData = new System.Windows.Forms.Label();
            this.lblEastDAgo2Sem = new System.Windows.Forms.Label();
            this.lblEastDCur = new System.Windows.Forms.Label();
            this.lblEastDLast = new System.Windows.Forms.Label();
            this.grpWestD = new System.Windows.Forms.GroupBox();
            this.lblWestDCurData = new System.Windows.Forms.Label();
            this.lblWestDLastData = new System.Windows.Forms.Label();
            this.lblWestDAgoData = new System.Windows.Forms.Label();
            this.lblWestDAgo2Sem = new System.Windows.Forms.Label();
            this.lblWestDCur = new System.Windows.Forms.Label();
            this.lblWestDLast = new System.Windows.Forms.Label();
            this.grpKey = new System.Windows.Forms.GroupBox();
            this.pbxConference = new System.Windows.Forms.PictureBox();
            this.lblKeyConference = new System.Windows.Forms.Label();
            this.lblKeyBreakOut = new System.Windows.Forms.Label();
            this.lblKeyEastD = new System.Windows.Forms.Label();
            this.lblKeyWestD = new System.Windows.Forms.Label();
            this.lblKeyStadium = new System.Windows.Forms.Label();
            this.pbxBreakOut = new System.Windows.Forms.PictureBox();
            this.pbxWestD = new System.Windows.Forms.PictureBox();
            this.pbxEastD = new System.Windows.Forms.PictureBox();
            this.pbxStadium = new System.Windows.Forms.PictureBox();
            this.grpTopUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResourceUsage)).BeginInit();
            this.grpResourceUsage.SuspendLayout();
            this.grpConference.SuspendLayout();
            this.grpStadiumPod.SuspendLayout();
            this.grpBreakOut.SuspendLayout();
            this.grpEastD.SuspendLayout();
            this.grpWestD.SuspendLayout();
            this.grpKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBreakOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWestD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEastD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStadium)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTopUsers
            // 
            this.grpTopUsers.Controls.Add(this.dgvTopUsers);
            this.grpTopUsers.Location = new System.Drawing.Point(18, 211);
            this.grpTopUsers.Name = "grpTopUsers";
            this.grpTopUsers.Size = new System.Drawing.Size(598, 144);
            this.grpTopUsers.TabIndex = 2;
            this.grpTopUsers.TabStop = false;
            this.grpTopUsers.Text = "Top Users";
            // 
            // dgvTopUsers
            // 
            this.dgvTopUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resrank,
            this.Username,
            this.CurSem,
            this.LastSem,
            this.Ago2Sem});
            this.dgvTopUsers.Location = new System.Drawing.Point(6, 16);
            this.dgvTopUsers.Name = "dgvTopUsers";
            this.dgvTopUsers.RowHeadersVisible = false;
            this.dgvTopUsers.Size = new System.Drawing.Size(586, 113);
            this.dgvTopUsers.TabIndex = 0;
            // 
            // resrank
            // 
            this.resrank.HeaderText = "Rank";
            this.resrank.Name = "resrank";
            this.resrank.Width = 75;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // CurSem
            // 
            this.CurSem.HeaderText = "Current Semester";
            this.CurSem.Name = "CurSem";
            this.CurSem.Width = 114;
            // 
            // LastSem
            // 
            this.LastSem.HeaderText = "Last Semester";
            this.LastSem.Name = "LastSem";
            this.LastSem.Width = 114;
            // 
            // Ago2Sem
            // 
            this.Ago2Sem.HeaderText = "Two Semesters Ago";
            this.Ago2Sem.Name = "Ago2Sem";
            this.Ago2Sem.Width = 113;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(830, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxResourceUsage
            // 
            this.pbxResourceUsage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbxResourceUsage.Location = new System.Drawing.Point(7, 15);
            this.pbxResourceUsage.Name = "pbxResourceUsage";
            this.pbxResourceUsage.Size = new System.Drawing.Size(280, 295);
            this.pbxResourceUsage.TabIndex = 9;
            this.pbxResourceUsage.TabStop = false;
            this.pbxResourceUsage.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxResourceUsage_Paint);
            // 
            // grpResourceUsage
            // 
            this.grpResourceUsage.Controls.Add(this.pbxResourceUsage);
            this.grpResourceUsage.Location = new System.Drawing.Point(616, 12);
            this.grpResourceUsage.Name = "grpResourceUsage";
            this.grpResourceUsage.Size = new System.Drawing.Size(295, 316);
            this.grpResourceUsage.TabIndex = 10;
            this.grpResourceUsage.TabStop = false;
            this.grpResourceUsage.Text = "Resource Usage";
            // 
            // grpConference
            // 
            this.grpConference.Controls.Add(this.lblConfereceAgoData);
            this.grpConference.Controls.Add(this.lblConferenceLastData);
            this.grpConference.Controls.Add(this.lblConferenceCurData);
            this.grpConference.Controls.Add(this.lblConferenceAgo2Sem);
            this.grpConference.Controls.Add(this.lblConferenceCur);
            this.grpConference.Controls.Add(this.lblConferenceLast);
            this.grpConference.Location = new System.Drawing.Point(18, 11);
            this.grpConference.Name = "grpConference";
            this.grpConference.Size = new System.Drawing.Size(142, 94);
            this.grpConference.TabIndex = 11;
            this.grpConference.TabStop = false;
            this.grpConference.Text = "Conference Room";
            // 
            // lblConfereceAgoData
            // 
            this.lblConfereceAgoData.AutoSize = true;
            this.lblConfereceAgoData.Location = new System.Drawing.Point(68, 73);
            this.lblConfereceAgoData.Name = "lblConfereceAgoData";
            this.lblConfereceAgoData.Size = new System.Drawing.Size(35, 13);
            this.lblConfereceAgoData.TabIndex = 16;
            this.lblConfereceAgoData.Text = "label3";
            // 
            // lblConferenceLastData
            // 
            this.lblConferenceLastData.AutoSize = true;
            this.lblConferenceLastData.Location = new System.Drawing.Point(68, 46);
            this.lblConferenceLastData.Name = "lblConferenceLastData";
            this.lblConferenceLastData.Size = new System.Drawing.Size(35, 13);
            this.lblConferenceLastData.TabIndex = 15;
            this.lblConferenceLastData.Text = "label2";
            // 
            // lblConferenceCurData
            // 
            this.lblConferenceCurData.AutoSize = true;
            this.lblConferenceCurData.Location = new System.Drawing.Point(68, 18);
            this.lblConferenceCurData.Name = "lblConferenceCurData";
            this.lblConferenceCurData.Size = new System.Drawing.Size(35, 13);
            this.lblConferenceCurData.TabIndex = 14;
            this.lblConferenceCurData.Text = "label1";
            // 
            // lblConferenceAgo2Sem
            // 
            this.lblConferenceAgo2Sem.AutoSize = true;
            this.lblConferenceAgo2Sem.Location = new System.Drawing.Point(6, 73);
            this.lblConferenceAgo2Sem.Name = "lblConferenceAgo2Sem";
            this.lblConferenceAgo2Sem.Size = new System.Drawing.Size(56, 13);
            this.lblConferenceAgo2Sem.TabIndex = 13;
            this.lblConferenceAgo2Sem.Text = "Ago2Sem:";
            // 
            // lblConferenceCur
            // 
            this.lblConferenceCur.AutoSize = true;
            this.lblConferenceCur.Location = new System.Drawing.Point(6, 17);
            this.lblConferenceCur.Name = "lblConferenceCur";
            this.lblConferenceCur.Size = new System.Drawing.Size(47, 13);
            this.lblConferenceCur.TabIndex = 0;
            this.lblConferenceCur.Text = "CurSem:";
            // 
            // lblConferenceLast
            // 
            this.lblConferenceLast.AutoSize = true;
            this.lblConferenceLast.Location = new System.Drawing.Point(6, 46);
            this.lblConferenceLast.Name = "lblConferenceLast";
            this.lblConferenceLast.Size = new System.Drawing.Size(54, 13);
            this.lblConferenceLast.TabIndex = 12;
            this.lblConferenceLast.Text = "LastSem: ";
            // 
            // grpStadiumPod
            // 
            this.grpStadiumPod.Controls.Add(this.lblStadiumAgoData);
            this.grpStadiumPod.Controls.Add(this.lblStadiumLastData);
            this.grpStadiumPod.Controls.Add(this.lblStadiumCurData);
            this.grpStadiumPod.Controls.Add(this.lblStadiumAgo2Sem);
            this.grpStadiumPod.Controls.Add(this.lblStadiumCur);
            this.grpStadiumPod.Controls.Add(this.lblStadiumLast);
            this.grpStadiumPod.Location = new System.Drawing.Point(18, 111);
            this.grpStadiumPod.Name = "grpStadiumPod";
            this.grpStadiumPod.Size = new System.Drawing.Size(142, 94);
            this.grpStadiumPod.TabIndex = 12;
            this.grpStadiumPod.TabStop = false;
            this.grpStadiumPod.Text = "Stadium Pod";
            // 
            // lblStadiumAgoData
            // 
            this.lblStadiumAgoData.AutoSize = true;
            this.lblStadiumAgoData.Location = new System.Drawing.Point(71, 73);
            this.lblStadiumAgoData.Name = "lblStadiumAgoData";
            this.lblStadiumAgoData.Size = new System.Drawing.Size(41, 13);
            this.lblStadiumAgoData.TabIndex = 17;
            this.lblStadiumAgoData.Text = "label15";
            // 
            // lblStadiumLastData
            // 
            this.lblStadiumLastData.AutoSize = true;
            this.lblStadiumLastData.Location = new System.Drawing.Point(71, 46);
            this.lblStadiumLastData.Name = "lblStadiumLastData";
            this.lblStadiumLastData.Size = new System.Drawing.Size(41, 13);
            this.lblStadiumLastData.TabIndex = 16;
            this.lblStadiumLastData.Text = "label14";
            // 
            // lblStadiumCurData
            // 
            this.lblStadiumCurData.AutoSize = true;
            this.lblStadiumCurData.Location = new System.Drawing.Point(71, 17);
            this.lblStadiumCurData.Name = "lblStadiumCurData";
            this.lblStadiumCurData.Size = new System.Drawing.Size(41, 13);
            this.lblStadiumCurData.TabIndex = 15;
            this.lblStadiumCurData.Text = "label13";
            // 
            // lblStadiumAgo2Sem
            // 
            this.lblStadiumAgo2Sem.AutoSize = true;
            this.lblStadiumAgo2Sem.Location = new System.Drawing.Point(6, 73);
            this.lblStadiumAgo2Sem.Name = "lblStadiumAgo2Sem";
            this.lblStadiumAgo2Sem.Size = new System.Drawing.Size(59, 13);
            this.lblStadiumAgo2Sem.TabIndex = 13;
            this.lblStadiumAgo2Sem.Text = "Ago2Sem: ";
            // 
            // lblStadiumCur
            // 
            this.lblStadiumCur.AutoSize = true;
            this.lblStadiumCur.Location = new System.Drawing.Point(6, 17);
            this.lblStadiumCur.Name = "lblStadiumCur";
            this.lblStadiumCur.Size = new System.Drawing.Size(47, 13);
            this.lblStadiumCur.TabIndex = 0;
            this.lblStadiumCur.Text = "CurSem:";
            // 
            // lblStadiumLast
            // 
            this.lblStadiumLast.AutoSize = true;
            this.lblStadiumLast.Location = new System.Drawing.Point(6, 46);
            this.lblStadiumLast.Name = "lblStadiumLast";
            this.lblStadiumLast.Size = new System.Drawing.Size(57, 13);
            this.lblStadiumLast.TabIndex = 12;
            this.lblStadiumLast.Text = "Last Sem: ";
            // 
            // grpBreakOut
            // 
            this.grpBreakOut.Controls.Add(this.lblBreakOutLastData);
            this.grpBreakOut.Controls.Add(this.lblBreakOutAgoData);
            this.grpBreakOut.Controls.Add(this.lblBreakOutCurData);
            this.grpBreakOut.Controls.Add(this.lblBreakOutAgo2Sem);
            this.grpBreakOut.Controls.Add(this.lblBreakOutCur);
            this.grpBreakOut.Controls.Add(this.lblBreakOutLast);
            this.grpBreakOut.Location = new System.Drawing.Point(166, 12);
            this.grpBreakOut.Name = "grpBreakOut";
            this.grpBreakOut.Size = new System.Drawing.Size(142, 94);
            this.grpBreakOut.TabIndex = 13;
            this.grpBreakOut.TabStop = false;
            this.grpBreakOut.Text = "Break Out Room";
            // 
            // lblBreakOutLastData
            // 
            this.lblBreakOutLastData.AutoSize = true;
            this.lblBreakOutLastData.Location = new System.Drawing.Point(73, 46);
            this.lblBreakOutLastData.Name = "lblBreakOutLastData";
            this.lblBreakOutLastData.Size = new System.Drawing.Size(35, 13);
            this.lblBreakOutLastData.TabIndex = 17;
            this.lblBreakOutLastData.Text = "label6";
            // 
            // lblBreakOutAgoData
            // 
            this.lblBreakOutAgoData.AutoSize = true;
            this.lblBreakOutAgoData.Location = new System.Drawing.Point(73, 72);
            this.lblBreakOutAgoData.Name = "lblBreakOutAgoData";
            this.lblBreakOutAgoData.Size = new System.Drawing.Size(35, 13);
            this.lblBreakOutAgoData.TabIndex = 16;
            this.lblBreakOutAgoData.Text = "label5";
            // 
            // lblBreakOutCurData
            // 
            this.lblBreakOutCurData.AutoSize = true;
            this.lblBreakOutCurData.Location = new System.Drawing.Point(73, 17);
            this.lblBreakOutCurData.Name = "lblBreakOutCurData";
            this.lblBreakOutCurData.Size = new System.Drawing.Size(35, 13);
            this.lblBreakOutCurData.TabIndex = 15;
            this.lblBreakOutCurData.Text = "label4";
            // 
            // lblBreakOutAgo2Sem
            // 
            this.lblBreakOutAgo2Sem.AutoSize = true;
            this.lblBreakOutAgo2Sem.Location = new System.Drawing.Point(6, 73);
            this.lblBreakOutAgo2Sem.Name = "lblBreakOutAgo2Sem";
            this.lblBreakOutAgo2Sem.Size = new System.Drawing.Size(53, 13);
            this.lblBreakOutAgo2Sem.TabIndex = 13;
            this.lblBreakOutAgo2Sem.Text = "Ago2Sem";
            // 
            // lblBreakOutCur
            // 
            this.lblBreakOutCur.AutoSize = true;
            this.lblBreakOutCur.Location = new System.Drawing.Point(6, 17);
            this.lblBreakOutCur.Name = "lblBreakOutCur";
            this.lblBreakOutCur.Size = new System.Drawing.Size(47, 13);
            this.lblBreakOutCur.TabIndex = 0;
            this.lblBreakOutCur.Text = "CurSem:";
            // 
            // lblBreakOutLast
            // 
            this.lblBreakOutLast.AutoSize = true;
            this.lblBreakOutLast.Location = new System.Drawing.Point(6, 46);
            this.lblBreakOutLast.Name = "lblBreakOutLast";
            this.lblBreakOutLast.Size = new System.Drawing.Size(57, 13);
            this.lblBreakOutLast.TabIndex = 12;
            this.lblBreakOutLast.Text = "Last Sem: ";
            // 
            // grpEastD
            // 
            this.grpEastD.Controls.Add(this.lblEastDAgoData);
            this.grpEastD.Controls.Add(this.lblEastDLastData);
            this.grpEastD.Controls.Add(this.lblEastDCurData);
            this.grpEastD.Controls.Add(this.lblEastDAgo2Sem);
            this.grpEastD.Controls.Add(this.lblEastDCur);
            this.grpEastD.Controls.Add(this.lblEastDLast);
            this.grpEastD.Location = new System.Drawing.Point(462, 12);
            this.grpEastD.Name = "grpEastD";
            this.grpEastD.Size = new System.Drawing.Size(142, 94);
            this.grpEastD.TabIndex = 14;
            this.grpEastD.TabStop = false;
            this.grpEastD.Text = "East D Table";
            // 
            // lblEastDAgoData
            // 
            this.lblEastDAgoData.AutoSize = true;
            this.lblEastDAgoData.Location = new System.Drawing.Point(75, 72);
            this.lblEastDAgoData.Name = "lblEastDAgoData";
            this.lblEastDAgoData.Size = new System.Drawing.Size(41, 13);
            this.lblEastDAgoData.TabIndex = 20;
            this.lblEastDAgoData.Text = "label12";
            // 
            // lblEastDLastData
            // 
            this.lblEastDLastData.AutoSize = true;
            this.lblEastDLastData.Location = new System.Drawing.Point(75, 46);
            this.lblEastDLastData.Name = "lblEastDLastData";
            this.lblEastDLastData.Size = new System.Drawing.Size(41, 13);
            this.lblEastDLastData.TabIndex = 19;
            this.lblEastDLastData.Text = "label11";
            // 
            // lblEastDCurData
            // 
            this.lblEastDCurData.AutoSize = true;
            this.lblEastDCurData.Location = new System.Drawing.Point(75, 17);
            this.lblEastDCurData.Name = "lblEastDCurData";
            this.lblEastDCurData.Size = new System.Drawing.Size(41, 13);
            this.lblEastDCurData.TabIndex = 18;
            this.lblEastDCurData.Text = "label10";
            // 
            // lblEastDAgo2Sem
            // 
            this.lblEastDAgo2Sem.AutoSize = true;
            this.lblEastDAgo2Sem.Location = new System.Drawing.Point(6, 73);
            this.lblEastDAgo2Sem.Name = "lblEastDAgo2Sem";
            this.lblEastDAgo2Sem.Size = new System.Drawing.Size(53, 13);
            this.lblEastDAgo2Sem.TabIndex = 13;
            this.lblEastDAgo2Sem.Text = "Ago2Sem";
            // 
            // lblEastDCur
            // 
            this.lblEastDCur.AutoSize = true;
            this.lblEastDCur.Location = new System.Drawing.Point(6, 17);
            this.lblEastDCur.Name = "lblEastDCur";
            this.lblEastDCur.Size = new System.Drawing.Size(47, 13);
            this.lblEastDCur.TabIndex = 0;
            this.lblEastDCur.Text = "CurSem:";
            // 
            // lblEastDLast
            // 
            this.lblEastDLast.AutoSize = true;
            this.lblEastDLast.Location = new System.Drawing.Point(6, 46);
            this.lblEastDLast.Name = "lblEastDLast";
            this.lblEastDLast.Size = new System.Drawing.Size(57, 13);
            this.lblEastDLast.TabIndex = 12;
            this.lblEastDLast.Text = "Last Sem: ";
            // 
            // grpWestD
            // 
            this.grpWestD.Controls.Add(this.lblWestDCurData);
            this.grpWestD.Controls.Add(this.lblWestDLastData);
            this.grpWestD.Controls.Add(this.lblWestDAgoData);
            this.grpWestD.Controls.Add(this.lblWestDAgo2Sem);
            this.grpWestD.Controls.Add(this.lblWestDCur);
            this.grpWestD.Controls.Add(this.lblWestDLast);
            this.grpWestD.Location = new System.Drawing.Point(314, 12);
            this.grpWestD.Name = "grpWestD";
            this.grpWestD.Size = new System.Drawing.Size(142, 94);
            this.grpWestD.TabIndex = 15;
            this.grpWestD.TabStop = false;
            this.grpWestD.Text = "West D Table";
            // 
            // lblWestDCurData
            // 
            this.lblWestDCurData.AutoSize = true;
            this.lblWestDCurData.Location = new System.Drawing.Point(81, 17);
            this.lblWestDCurData.Name = "lblWestDCurData";
            this.lblWestDCurData.Size = new System.Drawing.Size(35, 13);
            this.lblWestDCurData.TabIndex = 17;
            this.lblWestDCurData.Text = "label9";
            // 
            // lblWestDLastData
            // 
            this.lblWestDLastData.AutoSize = true;
            this.lblWestDLastData.Location = new System.Drawing.Point(81, 46);
            this.lblWestDLastData.Name = "lblWestDLastData";
            this.lblWestDLastData.Size = new System.Drawing.Size(35, 13);
            this.lblWestDLastData.TabIndex = 16;
            this.lblWestDLastData.Text = "label8";
            // 
            // lblWestDAgoData
            // 
            this.lblWestDAgoData.AutoSize = true;
            this.lblWestDAgoData.Location = new System.Drawing.Point(81, 72);
            this.lblWestDAgoData.Name = "lblWestDAgoData";
            this.lblWestDAgoData.Size = new System.Drawing.Size(35, 13);
            this.lblWestDAgoData.TabIndex = 15;
            this.lblWestDAgoData.Text = "label7";
            // 
            // lblWestDAgo2Sem
            // 
            this.lblWestDAgo2Sem.AutoSize = true;
            this.lblWestDAgo2Sem.Location = new System.Drawing.Point(6, 73);
            this.lblWestDAgo2Sem.Name = "lblWestDAgo2Sem";
            this.lblWestDAgo2Sem.Size = new System.Drawing.Size(56, 13);
            this.lblWestDAgo2Sem.TabIndex = 13;
            this.lblWestDAgo2Sem.Text = "Ago2Sem:";
            // 
            // lblWestDCur
            // 
            this.lblWestDCur.AutoSize = true;
            this.lblWestDCur.Location = new System.Drawing.Point(6, 17);
            this.lblWestDCur.Name = "lblWestDCur";
            this.lblWestDCur.Size = new System.Drawing.Size(47, 13);
            this.lblWestDCur.TabIndex = 0;
            this.lblWestDCur.Text = "CurSem:";
            // 
            // lblWestDLast
            // 
            this.lblWestDLast.AutoSize = true;
            this.lblWestDLast.Location = new System.Drawing.Point(6, 46);
            this.lblWestDLast.Name = "lblWestDLast";
            this.lblWestDLast.Size = new System.Drawing.Size(57, 13);
            this.lblWestDLast.TabIndex = 12;
            this.lblWestDLast.Text = "Last Sem: ";
            // 
            // grpKey
            // 
            this.grpKey.Controls.Add(this.pbxStadium);
            this.grpKey.Controls.Add(this.pbxEastD);
            this.grpKey.Controls.Add(this.pbxWestD);
            this.grpKey.Controls.Add(this.pbxBreakOut);
            this.grpKey.Controls.Add(this.lblKeyStadium);
            this.grpKey.Controls.Add(this.lblKeyEastD);
            this.grpKey.Controls.Add(this.lblKeyWestD);
            this.grpKey.Controls.Add(this.lblKeyBreakOut);
            this.grpKey.Controls.Add(this.lblKeyConference);
            this.grpKey.Controls.Add(this.pbxConference);
            this.grpKey.Location = new System.Drawing.Point(166, 111);
            this.grpKey.Name = "grpKey";
            this.grpKey.Size = new System.Drawing.Size(438, 93);
            this.grpKey.TabIndex = 16;
            this.grpKey.TabStop = false;
            this.grpKey.Text = "Resource Key";
            // 
            // pbxConference
            // 
            this.pbxConference.Location = new System.Drawing.Point(120, 18);
            this.pbxConference.Name = "pbxConference";
            this.pbxConference.Size = new System.Drawing.Size(24, 21);
            this.pbxConference.TabIndex = 0;
            this.pbxConference.TabStop = false;
            this.pbxConference.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxResourceUsage_Paint);
            // 
            // lblKeyConference
            // 
            this.lblKeyConference.AutoSize = true;
            this.lblKeyConference.Location = new System.Drawing.Point(15, 26);
            this.lblKeyConference.Name = "lblKeyConference";
            this.lblKeyConference.Size = new System.Drawing.Size(99, 13);
            this.lblKeyConference.TabIndex = 1;
            this.lblKeyConference.Text = "Conference Room: ";
            // 
            // lblKeyBreakOut
            // 
            this.lblKeyBreakOut.AutoSize = true;
            this.lblKeyBreakOut.Location = new System.Drawing.Point(15, 62);
            this.lblKeyBreakOut.Name = "lblKeyBreakOut";
            this.lblKeyBreakOut.Size = new System.Drawing.Size(89, 13);
            this.lblKeyBreakOut.TabIndex = 2;
            this.lblKeyBreakOut.Text = "Break Out Room:";
            // 
            // lblKeyEastD
            // 
            this.lblKeyEastD.AutoSize = true;
            this.lblKeyEastD.Location = new System.Drawing.Point(180, 62);
            this.lblKeyEastD.Name = "lblKeyEastD";
            this.lblKeyEastD.Size = new System.Drawing.Size(75, 13);
            this.lblKeyEastD.TabIndex = 4;
            this.lblKeyEastD.Text = "East D Table: ";
            // 
            // lblKeyWestD
            // 
            this.lblKeyWestD.AutoSize = true;
            this.lblKeyWestD.Location = new System.Drawing.Point(180, 26);
            this.lblKeyWestD.Name = "lblKeyWestD";
            this.lblKeyWestD.Size = new System.Drawing.Size(79, 13);
            this.lblKeyWestD.TabIndex = 3;
            this.lblKeyWestD.Text = "West D Table: ";
            // 
            // lblKeyStadium
            // 
            this.lblKeyStadium.AutoSize = true;
            this.lblKeyStadium.Location = new System.Drawing.Point(311, 26);
            this.lblKeyStadium.Name = "lblKeyStadium";
            this.lblKeyStadium.Size = new System.Drawing.Size(73, 13);
            this.lblKeyStadium.TabIndex = 5;
            this.lblKeyStadium.Text = "Stadium Pod: ";
            // 
            // pbxBreakOut
            // 
            this.pbxBreakOut.Location = new System.Drawing.Point(120, 54);
            this.pbxBreakOut.Name = "pbxBreakOut";
            this.pbxBreakOut.Size = new System.Drawing.Size(24, 21);
            this.pbxBreakOut.TabIndex = 6;
            this.pbxBreakOut.TabStop = false;
            // 
            // pbxWestD
            // 
            this.pbxWestD.Location = new System.Drawing.Point(265, 18);
            this.pbxWestD.Name = "pbxWestD";
            this.pbxWestD.Size = new System.Drawing.Size(24, 21);
            this.pbxWestD.TabIndex = 7;
            this.pbxWestD.TabStop = false;
            // 
            // pbxEastD
            // 
            this.pbxEastD.Location = new System.Drawing.Point(265, 54);
            this.pbxEastD.Name = "pbxEastD";
            this.pbxEastD.Size = new System.Drawing.Size(24, 21);
            this.pbxEastD.TabIndex = 8;
            this.pbxEastD.TabStop = false;
            // 
            // pbxStadium
            // 
            this.pbxStadium.Location = new System.Drawing.Point(390, 18);
            this.pbxStadium.Name = "pbxStadium";
            this.pbxStadium.Size = new System.Drawing.Size(24, 21);
            this.pbxStadium.TabIndex = 9;
            this.pbxStadium.TabStop = false;
            // 
            // UsageStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 367);
            this.Controls.Add(this.grpKey);
            this.Controls.Add(this.grpWestD);
            this.Controls.Add(this.grpEastD);
            this.Controls.Add(this.grpBreakOut);
            this.Controls.Add(this.grpStadiumPod);
            this.Controls.Add(this.grpConference);
            this.Controls.Add(this.grpResourceUsage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpTopUsers);
            this.Name = "UsageStatistics";
            this.Text = "Usage Statistics";
            this.Load += new System.EventHandler(this.UsageStatistics_Load);
            this.grpTopUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResourceUsage)).EndInit();
            this.grpResourceUsage.ResumeLayout(false);
            this.grpConference.ResumeLayout(false);
            this.grpConference.PerformLayout();
            this.grpStadiumPod.ResumeLayout(false);
            this.grpStadiumPod.PerformLayout();
            this.grpBreakOut.ResumeLayout(false);
            this.grpBreakOut.PerformLayout();
            this.grpEastD.ResumeLayout(false);
            this.grpEastD.PerformLayout();
            this.grpWestD.ResumeLayout(false);
            this.grpWestD.PerformLayout();
            this.grpKey.ResumeLayout(false);
            this.grpKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBreakOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWestD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEastD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStadium)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpTopUsers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTopUsers;
        private System.Windows.Forms.PictureBox pbxResourceUsage;
        private System.Windows.Forms.GroupBox grpResourceUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn resrank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ago2Sem;
        private System.Windows.Forms.GroupBox grpConference;
        private System.Windows.Forms.Label lblConferenceAgo2Sem;
        private System.Windows.Forms.Label lblConferenceCur;
        private System.Windows.Forms.Label lblConferenceLast;
        private System.Windows.Forms.GroupBox grpStadiumPod;
        private System.Windows.Forms.Label lblStadiumAgo2Sem;
        private System.Windows.Forms.Label lblStadiumCur;
        private System.Windows.Forms.Label lblStadiumLast;
        private System.Windows.Forms.GroupBox grpBreakOut;
        private System.Windows.Forms.Label lblBreakOutAgo2Sem;
        private System.Windows.Forms.Label lblBreakOutCur;
        private System.Windows.Forms.Label lblBreakOutLast;
        private System.Windows.Forms.GroupBox grpEastD;
        private System.Windows.Forms.Label lblEastDAgo2Sem;
        private System.Windows.Forms.Label lblEastDCur;
        private System.Windows.Forms.Label lblEastDLast;
        private System.Windows.Forms.GroupBox grpWestD;
        private System.Windows.Forms.Label lblWestDAgo2Sem;
        private System.Windows.Forms.Label lblWestDCur;
        private System.Windows.Forms.Label lblWestDLast;
        private System.Windows.Forms.GroupBox grpKey;
        private System.Windows.Forms.Label lblConfereceAgoData;
        private System.Windows.Forms.Label lblConferenceLastData;
        private System.Windows.Forms.Label lblConferenceCurData;
        private System.Windows.Forms.Label lblStadiumAgoData;
        private System.Windows.Forms.Label lblStadiumLastData;
        private System.Windows.Forms.Label lblStadiumCurData;
        private System.Windows.Forms.Label lblBreakOutLastData;
        private System.Windows.Forms.Label lblBreakOutAgoData;
        private System.Windows.Forms.Label lblBreakOutCurData;
        private System.Windows.Forms.Label lblEastDAgoData;
        private System.Windows.Forms.Label lblEastDLastData;
        private System.Windows.Forms.Label lblEastDCurData;
        private System.Windows.Forms.Label lblWestDCurData;
        private System.Windows.Forms.Label lblWestDLastData;
        private System.Windows.Forms.Label lblWestDAgoData;
        private System.Windows.Forms.PictureBox pbxStadium;
        private System.Windows.Forms.PictureBox pbxEastD;
        private System.Windows.Forms.PictureBox pbxWestD;
        private System.Windows.Forms.PictureBox pbxBreakOut;
        private System.Windows.Forms.Label lblKeyStadium;
        private System.Windows.Forms.Label lblKeyEastD;
        private System.Windows.Forms.Label lblKeyWestD;
        private System.Windows.Forms.Label lblKeyBreakOut;
        private System.Windows.Forms.Label lblKeyConference;
        private System.Windows.Forms.PictureBox pbxConference;
    }
}