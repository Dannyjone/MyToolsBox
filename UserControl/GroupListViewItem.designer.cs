namespace MyToolsBox
{
    partial class GroupListViewItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroToggle1 = new Wisder.W3Common.WMetroControl.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.GroupListViewItem_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GroupListViewItem_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.GroupListViewItem_MouseHover);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GroupListViewItem_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(86, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ItemName";
            this.label1.Click += new System.EventHandler(this.GroupListViewItem_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GroupListViewItem_MouseDown);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.GroupListViewItem_MouseHover);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GroupListViewItem_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(88, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 11);
            this.label2.TabIndex = 2;
            this.label2.Text = "ItemViewRemark";
            this.label2.Click += new System.EventHandler(this.GroupListViewItem_Click);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GroupListViewItem_MouseDown);
            this.label2.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.GroupListViewItem_MouseHover);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GroupListViewItem_MouseUp);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(117, 63);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 16);
            this.metroToggle1.TabIndex = 3;
            this.metroToggle1.Text = "OFF";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.UseVisualStyleBackColor = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // GroupListViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GroupListViewItem";
            this.Size = new System.Drawing.Size(200, 83);
            this.Click += new System.EventHandler(this.GroupListViewItem_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GroupListViewItem_MouseDown);
            this.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.GroupListViewItem_MouseHover);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GroupListViewItem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Wisder.W3Common.WMetroControl.Controls.MetroToggle metroToggle1;
    }
}
