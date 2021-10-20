namespace PuzzleGame
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnmReset = new System.Windows.Forms.ToolStripMenuItem();
            this.btnmSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.btnmNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnmExit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.btn2 = new DevComponents.DotNetBar.ButtonX();
            this.btn3 = new DevComponents.DotNetBar.ButtonX();
            this.btn4 = new DevComponents.DotNetBar.ButtonX();
            this.btn8 = new DevComponents.DotNetBar.ButtonX();
            this.btn7 = new DevComponents.DotNetBar.ButtonX();
            this.btn6 = new DevComponents.DotNetBar.ButtonX();
            this.btn5 = new DevComponents.DotNetBar.ButtonX();
            this.btn12 = new DevComponents.DotNetBar.ButtonX();
            this.btn11 = new DevComponents.DotNetBar.ButtonX();
            this.btn10 = new DevComponents.DotNetBar.ButtonX();
            this.btn9 = new DevComponents.DotNetBar.ButtonX();
            this.btn = new DevComponents.DotNetBar.ButtonX();
            this.btn15 = new DevComponents.DotNetBar.ButtonX();
            this.btn14 = new DevComponents.DotNetBar.ButtonX();
            this.btn13 = new DevComponents.DotNetBar.ButtonX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new DevComponents.DotNetBar.ButtonX();
            this.NewGame = new DevComponents.DotNetBar.ButtonX();
            this.Solution = new DevComponents.DotNetBar.ButtonX();
            this.Reset = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.btnmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnmReset,
            this.btnmSolution,
            this.btnmNewGame,
            this.toolStripMenuItem1,
            this.btnmExit2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnmReset
            // 
            this.btnmReset.Name = "btnmReset";
            this.btnmReset.Size = new System.Drawing.Size(180, 26);
            this.btnmReset.Text = "Reset";
            this.btnmReset.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnmSolution
            // 
            this.btnmSolution.Name = "btnmSolution";
            this.btnmSolution.Size = new System.Drawing.Size(180, 26);
            this.btnmSolution.Text = "Solotion";
            this.btnmSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // btnmNewGame
            // 
            this.btnmNewGame.Name = "btnmNewGame";
            this.btnmNewGame.Size = new System.Drawing.Size(180, 26);
            this.btnmNewGame.Text = "New Game";
            this.btnmNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // btnmExit2
            // 
            this.btnmExit2.Name = "btnmExit2";
            this.btnmExit2.Size = new System.Drawing.Size(180, 26);
            this.btnmExit2.Text = "Exit";
            // 
            // btnmExit
            // 
            this.btnmExit.Name = "btnmExit";
            this.btnmExit.Size = new System.Drawing.Size(51, 25);
            this.btnmExit.Text = "Exit";
            this.btnmExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.menuStrip1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn);
            this.panel3.Controls.Add(this.btn15);
            this.panel3.Controls.Add(this.btn14);
            this.panel3.Controls.Add(this.btn13);
            this.panel3.Controls.Add(this.btn12);
            this.panel3.Controls.Add(this.btn11);
            this.panel3.Controls.Add(this.btn10);
            this.panel3.Controls.Add(this.btn9);
            this.panel3.Controls.Add(this.btn8);
            this.panel3.Controls.Add(this.btn7);
            this.panel3.Controls.Add(this.btn6);
            this.panel3.Controls.Add(this.btn5);
            this.panel3.Controls.Add(this.btn4);
            this.panel3.Controls.Add(this.btn3);
            this.panel3.Controls.Add(this.btn2);
            this.panel3.Controls.Add(this.btn1);
            this.panel3.Location = new System.Drawing.Point(4, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 326);
            this.panel3.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(79, 78);
            this.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(84, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 78);
            this.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(165, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(79, 78);
            this.btn3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(246, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(79, 78);
            this.btn4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn8.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(246, 83);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(79, 78);
            this.btn8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn7.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(165, 83);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(79, 78);
            this.btn7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn6.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(84, 83);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(79, 78);
            this.btn6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn5.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(3, 83);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(79, 78);
            this.btn5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn12
            // 
            this.btn12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn12.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn12.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(246, 164);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(79, 78);
            this.btn12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn12.TabIndex = 11;
            this.btn12.Text = "12";
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn11
            // 
            this.btn11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn11.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn11.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(165, 164);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(79, 78);
            this.btn11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn11.TabIndex = 10;
            this.btn11.Text = "11";
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn10
            // 
            this.btn10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn10.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn10.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(84, 164);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(79, 78);
            this.btn10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn10.TabIndex = 9;
            this.btn10.Text = "10";
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn9.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(3, 164);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(79, 78);
            this.btn9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn
            // 
            this.btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn.BackColor = System.Drawing.Color.Black;
            this.btn.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(246, 244);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(79, 78);
            this.btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn.SymbolColor = System.Drawing.Color.White;
            this.btn.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn.TabIndex = 15;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn15
            // 
            this.btn15.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn15.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn15.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.Location = new System.Drawing.Point(165, 244);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(79, 78);
            this.btn15.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn15.TabIndex = 14;
            this.btn15.Text = "15";
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn14
            // 
            this.btn14.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn14.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn14.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14.Location = new System.Drawing.Point(84, 244);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(79, 78);
            this.btn14.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn14.TabIndex = 13;
            this.btn14.Text = "14";
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // btn13
            // 
            this.btn13.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn13.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btn13.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(3, 244);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(79, 78);
            this.btn13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn13.TabIndex = 12;
            this.btn13.Text = "13";
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(4, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 56);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.Exit);
            this.panel5.Controls.Add(this.NewGame);
            this.panel5.Controls.Add(this.Solution);
            this.panel5.Controls.Add(this.Reset);
            this.panel5.Location = new System.Drawing.Point(339, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 385);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(3, 303);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(153, 78);
            this.Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NewGame
            // 
            this.NewGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.NewGame.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.NewGame.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Location = new System.Drawing.Point(3, 223);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(153, 78);
            this.NewGame.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.NewGame.TabIndex = 18;
            this.NewGame.Text = "New Game";
            this.NewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Solution
            // 
            this.Solution.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Solution.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.Solution.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solution.Location = new System.Drawing.Point(3, 142);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(153, 78);
            this.Solution.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.Solution.TabIndex = 17;
            this.Solution.Text = "Solution";
            this.Solution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // Reset
            // 
            this.Reset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Reset.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.Reset.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(3, 58);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(153, 81);
            this.Reset.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.Reset.TabIndex = 16;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(503, 420);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnmReset;
        private System.Windows.Forms.ToolStripMenuItem btnmSolution;
        private System.Windows.Forms.ToolStripMenuItem btnmNewGame;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnmExit2;
        private System.Windows.Forms.ToolStripMenuItem btnmExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX btn4;
        private DevComponents.DotNetBar.ButtonX btn3;
        private DevComponents.DotNetBar.ButtonX btn2;
        private DevComponents.DotNetBar.ButtonX btn1;
        private DevComponents.DotNetBar.ButtonX btn;
        private DevComponents.DotNetBar.ButtonX btn15;
        private DevComponents.DotNetBar.ButtonX btn14;
        private DevComponents.DotNetBar.ButtonX btn13;
        private DevComponents.DotNetBar.ButtonX btn12;
        private DevComponents.DotNetBar.ButtonX btn11;
        private DevComponents.DotNetBar.ButtonX btn10;
        private DevComponents.DotNetBar.ButtonX btn9;
        private DevComponents.DotNetBar.ButtonX btn8;
        private DevComponents.DotNetBar.ButtonX btn7;
        private DevComponents.DotNetBar.ButtonX btn6;
        private DevComponents.DotNetBar.ButtonX btn5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.ButtonX Exit;
        private DevComponents.DotNetBar.ButtonX NewGame;
        private DevComponents.DotNetBar.ButtonX Solution;
        private DevComponents.DotNetBar.ButtonX Reset;
        private System.Windows.Forms.Label label2;
    }
}

