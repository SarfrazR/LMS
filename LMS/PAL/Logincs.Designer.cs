
namespace LMS.PAL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cmduser = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnnotice = new System.Windows.Forms.Button();
            this.btnrule = new System.Windows.Forms.Button();
            this.btnabout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(966, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(836, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(835, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(984, 266);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(208, 20);
            this.txtusername.TabIndex = 3;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(984, 373);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(208, 20);
            this.txtpassword.TabIndex = 4;
            // 
            // cmduser
            // 
            this.cmduser.FormattingEnabled = true;
            this.cmduser.Items.AddRange(new object[] {
            "Student",
            "Admin",
            "Teacher"});
            this.cmduser.Location = new System.Drawing.Point(984, 321);
            this.cmduser.Name = "cmduser";
            this.cmduser.Size = new System.Drawing.Size(208, 21);
            this.cmduser.TabIndex = 5;
            this.cmduser.SelectedIndexChanged += new System.EventHandler(this.cmduser_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::LMS.Properties.Resources.ntu_logo;
            this.pictureBox1.Location = new System.Drawing.Point(840, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LMS.Properties.Resources.icons8_learning_48;
            this.pictureBox2.Location = new System.Drawing.Point(226, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Playbill", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(331, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 60);
            this.label4.TabIndex = 8;
            this.label4.Text = "Learning Management System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(836, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::LMS.Properties.Resources.icons8_exit_492;
            this.button1.Location = new System.Drawing.Point(984, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Secure Login";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnotice
            // 
            this.btnnotice.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnnotice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnotice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnnotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotice.ForeColor = System.Drawing.Color.White;
            this.btnnotice.Image = global::LMS.Properties.Resources.icons8_alarm_32;
            this.btnnotice.Location = new System.Drawing.Point(803, 566);
            this.btnnotice.Name = "btnnotice";
            this.btnnotice.Size = new System.Drawing.Size(138, 42);
            this.btnnotice.TabIndex = 11;
            this.btnnotice.Text = "Notice Board";
            this.btnnotice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnotice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnotice.UseVisualStyleBackColor = false;
            this.btnnotice.Click += new System.EventHandler(this.btnnotice_Click);
            // 
            // btnrule
            // 
            this.btnrule.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnrule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrule.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrule.ForeColor = System.Drawing.Color.White;
            this.btnrule.Image = global::LMS.Properties.Resources.icons8_rules_32;
            this.btnrule.Location = new System.Drawing.Point(972, 566);
            this.btnrule.Name = "btnrule";
            this.btnrule.Size = new System.Drawing.Size(138, 42);
            this.btnrule.TabIndex = 12;
            this.btnrule.Text = "Rules";
            this.btnrule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrule.UseVisualStyleBackColor = false;
            this.btnrule.Click += new System.EventHandler(this.btnrule_Click);
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnabout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnabout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnabout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.Color.White;
            this.btnabout.Image = global::LMS.Properties.Resources.icons8_about_32;
            this.btnabout.Location = new System.Drawing.Point(1157, 566);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(138, 42);
            this.btnabout.TabIndex = 13;
            this.btnabout.Text = "About ";
            this.btnabout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnabout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnabout.UseVisualStyleBackColor = false;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1321, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::LMS.Properties.Resources.StudentWallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 678);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnabout);
            this.Controls.Add(this.btnrule);
            this.Controls.Add(this.btnnotice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmduser);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning Managment System";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.ComboBox cmduser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnnotice;
        private System.Windows.Forms.Button btnrule;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Button btnExit;
    }
}