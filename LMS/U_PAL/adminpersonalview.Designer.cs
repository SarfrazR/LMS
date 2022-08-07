
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
            this.GridAdmin = new System.Windows.Forms.DataGridView();
            this.panelview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelview
            // 
            this.panelview.BackgroundImage = global::LMS.Properties.Resources.StudentWallpaper1;
            this.panelview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelview.Controls.Add(this.back);
            this.panelview.Controls.Add(this.button2);
            this.panelview.Controls.Add(this.label10);
            this.panelview.Controls.Add(this.GridAdmin);
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
            this.back.Location = new System.Drawing.Point(225, 379);
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
            this.button2.Location = new System.Drawing.Point(225, 90);
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
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(216, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 36);
            this.label10.TabIndex = 49;
            this.label10.Text = "Admin Detail";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // GridAdmin
            // 
            this.GridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdmin.Location = new System.Drawing.Point(58, 155);
            this.GridAdmin.Name = "GridAdmin";
            this.GridAdmin.Size = new System.Drawing.Size(517, 193);
            this.GridAdmin.TabIndex = 46;
            this.GridAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridStudent_CellContentClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelview;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GridAdmin;
    }
}
