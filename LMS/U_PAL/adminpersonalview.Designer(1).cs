
namespace LMS.U_PAL
{
    partial class adminpersonalview
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
            this.panelview = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textRegno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GridStudent = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelview
            // 
            this.panelview.BackgroundImage = global::LMS.Properties.Resources.StudentWallpaper1;
            this.panelview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelview.Controls.Add(this.button1);
            this.panelview.Controls.Add(this.back);
            this.panelview.Controls.Add(this.button2);
            this.panelview.Controls.Add(this.label10);
            this.panelview.Controls.Add(this.textRegno);
            this.panelview.Controls.Add(this.label3);
            this.panelview.Controls.Add(this.GridStudent);
            this.panelview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelview.Location = new System.Drawing.Point(0, 0);
            this.panelview.Name = "panelview";
            this.panelview.Size = new System.Drawing.Size(628, 412);
            this.panelview.TabIndex = 0;
            this.panelview.Paint += new System.Windows.Forms.PaintEventHandler(this.panelview_Paint);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(423, 370);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(152, 30);
            this.back.TabIndex = 54;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(58, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 32);
            this.button2.TabIndex = 51;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(216, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 29);
            this.label10.TabIndex = 49;
            this.label10.Text = "Admin Detail";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textRegno
            // 
            this.textRegno.Location = new System.Drawing.Point(271, 89);
            this.textRegno.Multiline = true;
            this.textRegno.Name = "textRegno";
            this.textRegno.Size = new System.Drawing.Size(213, 25);
            this.textRegno.TabIndex = 48;
            this.textRegno.TextChanged += new System.EventHandler(this.textRegno_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Admin ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GridStudent
            // 
            this.GridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStudent.Location = new System.Drawing.Point(58, 155);
            this.GridStudent.Name = "GridStudent";
            this.GridStudent.Size = new System.Drawing.Size(517, 193);
            this.GridStudent.TabIndex = 46;
            this.GridStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridStudent_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(504, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 55;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // adminpersonalview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelview);
            this.Name = "adminpersonalview";
            this.Size = new System.Drawing.Size(628, 412);
            this.panelview.ResumeLayout(false);
            this.panelview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelview;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textRegno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridStudent;
        private System.Windows.Forms.Button button1;
    }
}
