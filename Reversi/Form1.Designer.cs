namespace Reversi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.משחקחדשToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הוראותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.יציאהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ניצחוןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.משחקמולמחשבToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_move_turn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.משחקחדשToolStripMenuItem,
            this.הוראותToolStripMenuItem,
            this.יציאהToolStripMenuItem,
            this.ניצחוןToolStripMenuItem,
            this.משחקמולמחשבToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // משחקחדשToolStripMenuItem
            // 
            this.משחקחדשToolStripMenuItem.Name = "משחקחדשToolStripMenuItem";
            this.משחקחדשToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.משחקחדשToolStripMenuItem.Text = "משחק חדש";
            this.משחקחדשToolStripMenuItem.Click += new System.EventHandler(this.משחקחדשToolStripMenuItem_Click);
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
            this.יציאהToolStripMenuItem.Click += new System.EventHandler(this.יציאהToolStripMenuItem_Click);
            // 
            // ניצחוןToolStripMenuItem
            // 
            this.ניצחוןToolStripMenuItem.Name = "ניצחוןToolStripMenuItem";
            this.ניצחוןToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ניצחוןToolStripMenuItem.Text = "ניצחון";
            this.ניצחוןToolStripMenuItem.Click += new System.EventHandler(this.ניצחוןToolStripMenuItem_Click);
            // 
            // משחקמולמחשבToolStripMenuItem
            // 
            this.משחקמולמחשבToolStripMenuItem.Name = "משחקמולמחשבToolStripMenuItem";
            this.משחקמולמחשבToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.משחקמולמחשבToolStripMenuItem.Text = "משחק מול מחשב";
            this.משחקמולמחשבToolStripMenuItem.Click += new System.EventHandler(this.משחקמולמחשבToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = global::Reversi.Properties.Resources.pic_bored;
            this.pictureBox1.Location = new System.Drawing.Point(64, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 722);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(881, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "שחור";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(933, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "שחורים";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(950, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "לבנים";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(988, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "תור";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(881, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(881, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "2";
            // 
            // b_move_turn
            // 
            this.b_move_turn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_move_turn.Font = new System.Drawing.Font("Narkisim", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.b_move_turn.Location = new System.Drawing.Point(878, 318);
            this.b_move_turn.Name = "b_move_turn";
            this.b_move_turn.Size = new System.Drawing.Size(164, 69);
            this.b_move_turn.TabIndex = 8;
            this.b_move_turn.Text = "העבר טור";
            this.b_move_turn.UseVisualStyleBackColor = false;
            this.b_move_turn.Click += new System.EventHandler(this.b_move_turn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reversi.Properties.Resources.pic_wod02;
            this.ClientSize = new System.Drawing.Size(1078, 962);
            this.Controls.Add(this.b_move_turn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mmm);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem משחקחדשToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הוראותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem יציאהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ניצחוןToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem משחקמולמחשבToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_move_turn;
    }
}

