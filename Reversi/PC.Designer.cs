namespace Reversi
{
    partial class PC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.משחקחדשToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הוראותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.יציאהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ניצחוןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1062, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "לבן";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1031, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "שחור";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(912, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(912, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.משחקחדשToolStripMenuItem,
            this.הוראותToolStripMenuItem,
            this.יציאהToolStripMenuItem,
            this.ניצחוןToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // משחקחדשToolStripMenuItem
            // 
            this.משחקחדשToolStripMenuItem.Name = "משחקחדשToolStripMenuItem";
            this.משחקחדשToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.משחקחדשToolStripMenuItem.Text = "משחק חדש";
            this.משחקחדשToolStripMenuItem.Click += new System.EventHandler(this.משחקחדשToolStripMenuItem_Click_1);
            // 
            // הוראותToolStripMenuItem
            // 
            this.הוראותToolStripMenuItem.Name = "הוראותToolStripMenuItem";
            this.הוראותToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.הוראותToolStripMenuItem.Text = "הוראות";
            this.הוראותToolStripMenuItem.Click += new System.EventHandler(this.הוראותToolStripMenuItem_Click);
            // 
            // יציאהToolStripMenuItem
            // 
            this.יציאהToolStripMenuItem.Name = "יציאהToolStripMenuItem";
            this.יציאהToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.יציאהToolStripMenuItem.Text = "יציאה ";
            this.יציאהToolStripMenuItem.Click += new System.EventHandler(this.יציאהToolStripMenuItem_Click_1);
            // 
            // ניצחוןToolStripMenuItem
            // 
            this.ניצחוןToolStripMenuItem.Name = "ניצחוןToolStripMenuItem";
            this.ניצחוןToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ניצחוןToolStripMenuItem.Text = "ניצחון";
            this.ניצחוןToolStripMenuItem.Click += new System.EventHandler(this.ניצחוןToolStripMenuItem_Click);
            // 
            // PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Reversi.Properties.Resources.cp_reka_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 813);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PC";
            this.Text = "PC";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mmm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem משחקחדשToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הוראותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem יציאהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ניצחוןToolStripMenuItem;
    }
}