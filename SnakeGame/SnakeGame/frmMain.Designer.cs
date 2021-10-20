namespace SnakeGame
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnStop = new DevComponents.DotNetBar.ButtonX();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.rdbback1 = new System.Windows.Forms.RadioButton();
            this.rdbback2 = new System.Windows.Forms.RadioButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblScore = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblscoreValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(615, 46);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(104, 33);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "label1";
            this.lblGameOver.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.picCanvas;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 818);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.rdbback2);
            this.panel4.Controls.Add(this.rdbback1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnStop);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 639);
            this.panel4.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 69);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.Symbol = "";
            this.btnExit.SymbolColor = System.Drawing.Color.Gray;
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "        Exit";
            this.btnExit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnExit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStop
            // 
            this.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStop.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(0, 69);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(204, 69);
            this.btnStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStop.Symbol = "57398";
            this.btnStop.SymbolColor = System.Drawing.Color.Gray;
            this.btnStop.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "        Stop";
            this.btnStop.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnStop.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(204, 69);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.Symbol = "57401";
            this.btnStart.SymbolColor = System.Drawing.Color.Gray;
            this.btnStart.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "       Start ";
            this.btnStart.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnStart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdbback1
            // 
            this.rdbback1.AutoSize = true;
            this.rdbback1.Location = new System.Drawing.Point(11, 223);
            this.rdbback1.Name = "rdbback1";
            this.rdbback1.Size = new System.Drawing.Size(119, 24);
            this.rdbback1.TabIndex = 8;
            this.rdbback1.TabStop = true;
            this.rdbback1.Text = "BackGround 1";
            this.rdbback1.UseVisualStyleBackColor = true;
            this.rdbback1.CheckedChanged += new System.EventHandler(this.rdbback1_CheckedChanged);
            // 
            // rdbback2
            // 
            this.rdbback2.AutoSize = true;
            this.rdbback2.Location = new System.Drawing.Point(11, 367);
            this.rdbback2.Name = "rdbback2";
            this.rdbback2.Size = new System.Drawing.Size(119, 24);
            this.rdbback2.TabIndex = 10;
            this.rdbback2.TabStop = true;
            this.rdbback2.Text = "BackGround 2";
            this.rdbback2.UseVisualStyleBackColor = true;
            this.rdbback2.CheckedChanged += new System.EventHandler(this.rdbback2_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1270, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Image = global::SnakeGame.Properties.Resources._2;
            this.picCanvas.Location = new System.Drawing.Point(206, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1111, 818);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SnakeGame.Properties.Resources.maino;
            this.pictureBox2.Location = new System.Drawing.Point(11, 397);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnakeGame.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(11, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblscoreValue);
            this.panel3.Controls.Add(this.lblScore);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 177);
            this.panel3.TabIndex = 7;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblScore.Location = new System.Drawing.Point(3, 139);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(121, 36);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score :";
            // 
            // lblscoreValue
            // 
            this.lblscoreValue.AutoSize = true;
            this.lblscoreValue.BackColor = System.Drawing.Color.Transparent;
            this.lblscoreValue.Font = new System.Drawing.Font("Showcard Gothic", 21.75F);
            this.lblscoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblscoreValue.Location = new System.Drawing.Point(140, 139);
            this.lblscoreValue.Name = "lblscoreValue";
            this.lblscoreValue.Size = new System.Drawing.Size(32, 36);
            this.lblscoreValue.TabIndex = 3;
            this.lblscoreValue.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::SnakeGame.Properties.Resources.original;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 136);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 818);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private Bunifu.Framework.UI.BunifuCustomLabel lblScore;
        private Bunifu.Framework.UI.BunifuCustomLabel lblscoreValue;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnStop;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private System.Windows.Forms.RadioButton rdbback2;
        private System.Windows.Forms.RadioButton rdbback1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

