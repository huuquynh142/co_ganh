namespace co_ganh
{
    partial class coghanh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coghanh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOption = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnPP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tengnuoichoi1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tenguoichoi2 = new System.Windows.Forms.Label();
            this.pcbTrang = new System.Windows.Forms.PictureBox();
            this.pcbĐen = new System.Windows.Forms.PictureBox();
            this.lbquanden = new System.Windows.Forms.Label();
            this.lbsoquanden = new System.Windows.Forms.Label();
            this.lbquantrang = new System.Windows.Forms.Label();
            this.lbsoquantrang = new System.Windows.Forms.Label();
            this.panel_co_ganh = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.grpOption.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbĐen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.playerVsComputerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.playerVsPlayerToolStripMenuItem.Text = "Player vs Player";
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.playerVsPlayerToolStripMenuItem_Click);
            // 
            // playerVsComputerToolStripMenuItem
            // 
            this.playerVsComputerToolStripMenuItem.Name = "playerVsComputerToolStripMenuItem";
            this.playerVsComputerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.playerVsComputerToolStripMenuItem.Text = "Player vs Computer";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guideToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // guideToolStripMenuItem
            // 
            this.guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            this.guideToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.guideToolStripMenuItem.Text = "Guide";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // grpOption
            // 
            this.grpOption.Controls.Add(this.label1);
            this.grpOption.Controls.Add(this.btnNewGame);
            this.grpOption.Controls.Add(this.btnExit);
            this.grpOption.Controls.Add(this.btnPC);
            this.grpOption.Controls.Add(this.btnPP);
            this.grpOption.Location = new System.Drawing.Point(570, 292);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(243, 291);
            this.grpOption.TabIndex = 4;
            this.grpOption.TabStop = false;
            this.grpOption.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carry Chess is very good";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(138, 212);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(88, 39);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(18, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 39);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPC
            // 
            this.btnPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPC.Location = new System.Drawing.Point(125, 109);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(112, 55);
            this.btnPC.TabIndex = 1;
            this.btnPC.Text = "Player vs Computer";
            this.btnPC.UseVisualStyleBackColor = false;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnPP
            // 
            this.btnPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPP.Location = new System.Drawing.Point(18, 109);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(101, 55);
            this.btnPP.TabIndex = 0;
            this.btnPP.Text = "Player vs Player";
            this.btnPP.UseVisualStyleBackColor = false;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(569, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 249);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tengnuoichoi1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tenguoichoi2);
            this.groupBox1.Controls.Add(this.pcbTrang);
            this.groupBox1.Controls.Add(this.pcbĐen);
            this.groupBox1.Controls.Add(this.lbquanden);
            this.groupBox1.Controls.Add(this.lbsoquanden);
            this.groupBox1.Controls.Add(this.lbquantrang);
            this.groupBox1.Controls.Add(this.lbsoquantrang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lượt đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Người chơi :";
            // 
            // tengnuoichoi1
            // 
            this.tengnuoichoi1.AutoSize = true;
            this.tengnuoichoi1.ForeColor = System.Drawing.Color.Green;
            this.tengnuoichoi1.Location = new System.Drawing.Point(77, 24);
            this.tengnuoichoi1.Name = "tengnuoichoi1";
            this.tengnuoichoi1.Size = new System.Drawing.Size(0, 13);
            this.tengnuoichoi1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Người chơi :";
            // 
            // tenguoichoi2
            // 
            this.tenguoichoi2.AutoSize = true;
            this.tenguoichoi2.ForeColor = System.Drawing.Color.Red;
            this.tenguoichoi2.Location = new System.Drawing.Point(77, 74);
            this.tenguoichoi2.Name = "tenguoichoi2";
            this.tenguoichoi2.Size = new System.Drawing.Size(0, 13);
            this.tenguoichoi2.TabIndex = 3;
            // 
            // pcbTrang
            // 
            this.pcbTrang.Image = global::co_ganh.Properties.Resources.Black;
            this.pcbTrang.Location = new System.Drawing.Point(7, 97);
            this.pcbTrang.Name = "pcbTrang";
            this.pcbTrang.Size = new System.Drawing.Size(25, 25);
            this.pcbTrang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTrang.TabIndex = 2;
            this.pcbTrang.TabStop = false;
            // 
            // pcbĐen
            // 
            this.pcbĐen.Image = global::co_ganh.Properties.Resources.Black;
            this.pcbĐen.Location = new System.Drawing.Point(9, 40);
            this.pcbĐen.Name = "pcbĐen";
            this.pcbĐen.Size = new System.Drawing.Size(25, 25);
            this.pcbĐen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbĐen.TabIndex = 2;
            this.pcbĐen.TabStop = false;
            // 
            // lbquanden
            // 
            this.lbquanden.AutoSize = true;
            this.lbquanden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquanden.ForeColor = System.Drawing.Color.Black;
            this.lbquanden.Location = new System.Drawing.Point(48, 47);
            this.lbquanden.Name = "lbquanden";
            this.lbquanden.Size = new System.Drawing.Size(62, 13);
            this.lbquanden.TabIndex = 0;
            this.lbquanden.Text = "Số quân :";
            // 
            // lbsoquanden
            // 
            this.lbsoquanden.AutoSize = true;
            this.lbsoquanden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoquanden.ForeColor = System.Drawing.Color.Black;
            this.lbsoquanden.Location = new System.Drawing.Point(116, 47);
            this.lbsoquanden.Name = "lbsoquanden";
            this.lbsoquanden.Size = new System.Drawing.Size(14, 13);
            this.lbsoquanden.TabIndex = 1;
            this.lbsoquanden.Text = "8";
            // 
            // lbquantrang
            // 
            this.lbquantrang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbquantrang.AutoSize = true;
            this.lbquantrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquantrang.ForeColor = System.Drawing.Color.Red;
            this.lbquantrang.Location = new System.Drawing.Point(48, 97);
            this.lbquantrang.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lbquantrang.Name = "lbquantrang";
            this.lbquantrang.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbquantrang.Size = new System.Drawing.Size(62, 18);
            this.lbquantrang.TabIndex = 0;
            this.lbquantrang.Text = "Số quân :";
            // 
            // lbsoquantrang
            // 
            this.lbsoquantrang.AutoSize = true;
            this.lbsoquantrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoquantrang.ForeColor = System.Drawing.Color.Red;
            this.lbsoquantrang.Location = new System.Drawing.Point(116, 102);
            this.lbsoquantrang.Name = "lbsoquantrang";
            this.lbsoquantrang.Size = new System.Drawing.Size(14, 13);
            this.lbsoquantrang.TabIndex = 1;
            this.lbsoquantrang.Text = "8";
            // 
            // panel_co_ganh
            // 
            this.panel_co_ganh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_co_ganh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_co_ganh.Location = new System.Drawing.Point(0, 27);
            this.panel_co_ganh.Name = "panel_co_ganh";
            this.panel_co_ganh.Size = new System.Drawing.Size(563, 556);
            this.panel_co_ganh.TabIndex = 0;
            this.panel_co_ganh.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_co_ganh_Paint);
            this.panel_co_ganh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_co_ganh_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // coghanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 587);
            this.Controls.Add(this.grpOption);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_co_ganh);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "coghanh";
            this.Text = "Cờ gánh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpOption.ResumeLayout(false);
            this.grpOption.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbĐen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_co_ganh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.Label lbsoquanden;
        private System.Windows.Forms.Label lbsoquantrang;
        private System.Windows.Forms.Label lbquanden;
        private System.Windows.Forms.Label lbquantrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbTrang;
        private System.Windows.Forms.PictureBox pcbĐen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tengnuoichoi1;
        private System.Windows.Forms.Label tenguoichoi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

