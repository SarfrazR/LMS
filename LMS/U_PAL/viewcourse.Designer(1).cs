
namespace LMS.U_PAL
{
    partial class viewcourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textSTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GridSubject = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Courses";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.back.Location = new System.Drawing.Point(457, 376);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(151, 30);
            this.back.TabIndex = 56;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Coral;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(11, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 32);
            this.button4.TabIndex = 54;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(456, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 32);
            this.button3.TabIndex = 55;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textSTitle
            // 
            this.textSTitle.Location = new System.Drawing.Point(461, 60);
            this.textSTitle.Multiline = true;
            this.textSTitle.Name = "textSTitle";
            this.textSTitle.Size = new System.Drawing.Size(153, 25);
            this.textSTitle.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(311, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Subject Title";
            // 
            // textSID
            // 
            this.textSID.Location = new System.Drawing.Point(121, 60);
            this.textSID.Multiline = true;
            this.textSID.Name = "textSID";
            this.textSID.Size = new System.Drawing.Size(153, 25);
            this.textSID.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Subject ID";
            // 
            // GridSubject
            // 
            this.GridSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSubject.Location = new System.Drawing.Point(6, 177);
            this.GridSubject.Name = "GridSubject";
            this.GridSubject.Size = new System.Drawing.Size(608, 193);
            this.GridSubject.TabIndex = 57;
            // 
            // viewcourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources.StudentWallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textSTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridSubject);
            this.Name = "viewcourse";
            this.Size = new System.Drawing.Size(628, 412);
            ((System.ComponentModel.ISupportInitialize)(this.GridSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textSTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridSubject;
    }
}
