namespace co_ganh
{
    partial class newGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtontrang = new System.Windows.Forms.RadioButton();
            this.radioButtonđen = new System.Windows.Forms.RadioButton();
            this.buttonchonquan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnguoi1 = new System.Windows.Forms.TextBox();
            this.txtnguoi2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtontrang);
            this.groupBox1.Controls.Add(this.radioButtonđen);
            this.groupBox1.Location = new System.Drawing.Point(31, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn quân đi trước";
            // 
            // radioButtontrang
            // 
            this.radioButtontrang.AutoSize = true;
            this.radioButtontrang.Location = new System.Drawing.Point(24, 64);
            this.radioButtontrang.Name = "radioButtontrang";
            this.radioButtontrang.Size = new System.Drawing.Size(78, 17);
            this.radioButtontrang.TabIndex = 0;
            this.radioButtontrang.TabStop = true;
            this.radioButtontrang.Text = "Quân trắng";
            this.radioButtontrang.UseVisualStyleBackColor = true;
            // 
            // radioButtonđen
            // 
            this.radioButtonđen.AutoSize = true;
            this.radioButtonđen.Location = new System.Drawing.Point(24, 31);
            this.radioButtonđen.Name = "radioButtonđen";
            this.radioButtonđen.Size = new System.Drawing.Size(73, 17);
            this.radioButtonđen.TabIndex = 0;
            this.radioButtonđen.TabStop = true;
            this.radioButtonđen.Text = "Quân đen";
            this.radioButtonđen.UseVisualStyleBackColor = true;
            this.radioButtonđen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonchonquan
            // 
            this.buttonchonquan.Location = new System.Drawing.Point(92, 282);
            this.buttonchonquan.Name = "buttonchonquan";
            this.buttonchonquan.Size = new System.Drawing.Size(75, 23);
            this.buttonchonquan.TabIndex = 1;
            this.buttonchonquan.Text = "ok";
            this.buttonchonquan.UseVisualStyleBackColor = true;
            this.buttonchonquan.Click += new System.EventHandler(this.buttonchonquan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnguoi2);
            this.groupBox2.Controls.Add(this.txtnguoi1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(31, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên người chơi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người chơi 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người chơi 2";
            // 
            // txtnguoi1
            // 
            this.txtnguoi1.Location = new System.Drawing.Point(24, 42);
            this.txtnguoi1.Name = "txtnguoi1";
            this.txtnguoi1.Size = new System.Drawing.Size(154, 20);
            this.txtnguoi1.TabIndex = 1;
            // 
            // txtnguoi2
            // 
            this.txtnguoi2.Location = new System.Drawing.Point(24, 79);
            this.txtnguoi2.Name = "txtnguoi2";
            this.txtnguoi2.Size = new System.Drawing.Size(154, 20);
            this.txtnguoi2.TabIndex = 1;
            // 
            // newGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonchonquan);
            this.Controls.Add(this.groupBox1);
            this.Name = "newGame";
            this.Text = "New Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtontrang;
        private System.Windows.Forms.RadioButton radioButtonđen;
        private System.Windows.Forms.Button buttonchonquan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnguoi2;
        private System.Windows.Forms.TextBox txtnguoi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}