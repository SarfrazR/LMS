
namespace LMS.U_PAL
{
    partial class TeacherPersonal
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
            this.label10 = new System.Windows.Forms.Label();
            this.GrdTeacher = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(164, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(308, 36);
            this.label10.TabIndex = 93;
            this.label10.Text = "Teacher Personal Info";
            // 
            // GrdTeacher
            // 
            this.GrdTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdTeacher.Location = new System.Drawing.Point(3, 70);
            this.GrdTeacher.Name = "GrdTeacher";
            this.GrdTeacher.Size = new System.Drawing.Size(622, 282);
            this.GrdTeacher.TabIndex = 94;
            this.GrdTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdTeacher_CellContentClick);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(3, 382);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(72, 30);
            this.back.TabIndex = 95;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // TeacherPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources.StudentWallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.back);
            this.Controls.Add(this.GrdTeacher);
            this.Controls.Add(this.label10);
            this.Name = "TeacherPersonal";
            this.Size = new System.Drawing.Size(628, 415);
            this.Load += new System.EventHandler(this.TeacherPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GrdTeacher;
        private System.Windows.Forms.Button back;
    }
}
