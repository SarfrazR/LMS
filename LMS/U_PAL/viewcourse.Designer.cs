
namespace LMS.U_PAL
{
    partial class btnviewcourse
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSID = new System.Windows.Forms.TextBox();
            this.lblSid = new System.Windows.Forms.Label();
            this.GridSubject = new System.Windows.Forms.DataGridView();
            this.btnSearchData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 62;
            this.label1.Text = "Courses";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.back.Location = new System.Drawing.Point(14, 379);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(151, 30);
            this.back.TabIndex = 56;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Coral;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(18, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 32);
            this.button4.TabIndex = 54;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(438, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 32);
            this.btnSearch.TabIndex = 55;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSID
            // 
            this.textSID.Location = new System.Drawing.Point(139, 141);
            this.textSID.Multiline = true;
            this.textSID.Name = "textSID";
            this.textSID.Size = new System.Drawing.Size(153, 25);
            this.textSID.TabIndex = 59;
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.BackColor = System.Drawing.Color.Transparent;
            this.lblSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSid.ForeColor = System.Drawing.Color.White;
            this.lblSid.Location = new System.Drawing.Point(13, 141);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(120, 25);
            this.lblSid.TabIndex = 58;
            this.lblSid.Text = "Subject ID";
            // 
            // GridSubject
            // 
            this.GridSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSubject.Location = new System.Drawing.Point(6, 177);
            this.GridSubject.Name = "GridSubject";
            this.GridSubject.Size = new System.Drawing.Size(608, 193);
            this.GridSubject.TabIndex = 57;
            this.GridSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSubject_CellContentClick);
            // 
            // btnSearchData
            // 
            this.btnSearchData.BackColor = System.Drawing.Color.Green;
            this.btnSearchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchData.Location = new System.Drawing.Point(439, 141);
            this.btnSearchData.Name = "btnSearchData";
            this.btnSearchData.Size = new System.Drawing.Size(151, 30);
            this.btnSearchData.TabIndex = 63;
            this.btnSearchData.Text = "Search";
            this.btnSearchData.UseVisualStyleBackColor = false;
            this.btnSearchData.Click += new System.EventHandler(this.btnSearchData_Click);
            // 
            // btnviewcourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources.StudentWallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnSearchData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSID);
            this.Controls.Add(this.lblSid);
            this.Controls.Add(this.GridSubject);
            this.Name = "btnviewcourse";
            this.Size = new System.Drawing.Size(628, 412);
            this.Load += new System.EventHandler(this.btnviewcourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSID;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.DataGridView GridSubject;
        private System.Windows.Forms.Button btnSearchData;
    }
}
