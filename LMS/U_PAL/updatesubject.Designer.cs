
namespace LMS.U_PAL
{
    partial class updatesubject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblChours = new System.Windows.Forms.Label();
            this.textTotalMarks = new System.Windows.Forms.TextBox();
            this.lblTMarks = new System.Windows.Forms.Label();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.textTID = new System.Windows.Forms.TextBox();
            this.textSID = new System.Windows.Forms.TextBox();
            this.lblLSect = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.btnUpd = new System.Windows.Forms.Button();
            this.lblTeacherAss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 156);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 75;
            // 
            // lblChours
            // 
            this.lblChours.AutoSize = true;
            this.lblChours.BackColor = System.Drawing.Color.Transparent;
            this.lblChours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChours.ForeColor = System.Drawing.Color.White;
            this.lblChours.Location = new System.Drawing.Point(317, 154);
            this.lblChours.Name = "lblChours";
            this.lblChours.Size = new System.Drawing.Size(110, 20);
            this.lblChours.TabIndex = 76;
            this.lblChours.Text = "Credit Hours";
            // 
            // textTotalMarks
            // 
            this.textTotalMarks.Location = new System.Drawing.Point(121, 156);
            this.textTotalMarks.Multiline = true;
            this.textTotalMarks.Name = "textTotalMarks";
            this.textTotalMarks.Size = new System.Drawing.Size(175, 20);
            this.textTotalMarks.TabIndex = 65;
            // 
            // lblTMarks
            // 
            this.lblTMarks.AutoSize = true;
            this.lblTMarks.BackColor = System.Drawing.Color.Transparent;
            this.lblTMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMarks.ForeColor = System.Drawing.Color.White;
            this.lblTMarks.Location = new System.Drawing.Point(11, 156);
            this.lblTMarks.Name = "lblTMarks";
            this.lblTMarks.Size = new System.Drawing.Size(102, 20);
            this.lblTMarks.TabIndex = 74;
            this.lblTMarks.Text = "Total Marks";
            // 
            // cmbLab
            // 
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbLab.Location = new System.Drawing.Point(121, 182);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(175, 21);
            this.cmbLab.TabIndex = 67;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.back.Location = new System.Drawing.Point(13, 366);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(99, 30);
            this.back.TabIndex = 69;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // textTID
            // 
            this.textTID.Location = new System.Drawing.Point(442, 130);
            this.textTID.Multiline = true;
            this.textTID.Name = "textTID";
            this.textTID.Size = new System.Drawing.Size(175, 20);
            this.textTID.TabIndex = 66;
            // 
            // textSID
            // 
            this.textSID.Location = new System.Drawing.Point(121, 130);
            this.textSID.Multiline = true;
            this.textSID.Name = "textSID";
            this.textSID.Size = new System.Drawing.Size(175, 20);
            this.textSID.TabIndex = 64;
            // 
            // lblLSect
            // 
            this.lblLSect.AutoSize = true;
            this.lblLSect.BackColor = System.Drawing.Color.Transparent;
            this.lblLSect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLSect.ForeColor = System.Drawing.Color.White;
            this.lblLSect.Location = new System.Drawing.Point(11, 180);
            this.lblLSect.Name = "lblLSect";
            this.lblLSect.Size = new System.Drawing.Size(105, 20);
            this.lblLSect.TabIndex = 73;
            this.lblLSect.Text = "Lab Section";
            this.lblLSect.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.BackColor = System.Drawing.Color.Transparent;
            this.lblTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTid.ForeColor = System.Drawing.Color.White;
            this.lblTid.Location = new System.Drawing.Point(329, 130);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(98, 20);
            this.lblTid.TabIndex = 72;
            this.lblTid.Text = "Teacher ID";
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.BackColor = System.Drawing.Color.Transparent;
            this.lblSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSid.ForeColor = System.Drawing.Color.White;
            this.lblSid.Location = new System.Drawing.Point(11, 130);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(94, 20);
            this.lblSid.TabIndex = 71;
            this.lblSid.Text = "Subject ID";
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpd.Location = new System.Drawing.Point(222, 293);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(183, 40);
            this.btnUpd.TabIndex = 68;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = false;
            // 
            // lblTeacherAss
            // 
            this.lblTeacherAss.AutoSize = true;
            this.lblTeacherAss.BackColor = System.Drawing.Color.Transparent;
            this.lblTeacherAss.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherAss.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTeacherAss.Location = new System.Drawing.Point(216, 16);
            this.lblTeacherAss.Name = "lblTeacherAss";
            this.lblTeacherAss.Size = new System.Drawing.Size(214, 36);
            this.lblTeacherAss.TabIndex = 70;
            this.lblTeacherAss.Text = "Teacher Assign";
            // 
            // updatesubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources.StudentWallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblChours);
            this.Controls.Add(this.textTotalMarks);
            this.Controls.Add(this.lblTMarks);
            this.Controls.Add(this.cmbLab);
            this.Controls.Add(this.back);
            this.Controls.Add(this.textTID);
            this.Controls.Add(this.textSID);
            this.Controls.Add(this.lblLSect);
            this.Controls.Add(this.lblTid);
            this.Controls.Add(this.lblSid);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.lblTeacherAss);
            this.Name = "updatesubject";
            this.Size = new System.Drawing.Size(628, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblChours;
        private System.Windows.Forms.TextBox textTotalMarks;
        private System.Windows.Forms.Label lblTMarks;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox textTID;
        private System.Windows.Forms.TextBox textSID;
        private System.Windows.Forms.Label lblLSect;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Label lblTeacherAss;
    }
}
