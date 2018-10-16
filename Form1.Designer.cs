namespace tictactoe
{
    partial class board_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutTicTacToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.board_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newGame_Button = new System.Windows.Forms.Button();
            this.turn_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStatisticsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutTicTacToeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 38);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // viewStatisticsToolStripMenuItem
            // 
            this.viewStatisticsToolStripMenuItem.Name = "viewStatisticsToolStripMenuItem";
            this.viewStatisticsToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.viewStatisticsToolStripMenuItem.Text = "View Statistics";
            this.viewStatisticsToolStripMenuItem.Click += new System.EventHandler(this.viewStatisticsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(298, 6);
            // 
            // aboutTicTacToeToolStripMenuItem
            // 
            this.aboutTicTacToeToolStripMenuItem.Name = "aboutTicTacToeToolStripMenuItem";
            this.aboutTicTacToeToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.aboutTicTacToeToolStripMenuItem.Text = "About Tic Tac Toe";
            // 
            // board_Panel
            // 
            this.board_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.board_Panel.Location = new System.Drawing.Point(0, 42);
            this.board_Panel.Name = "board_Panel";
            this.board_Panel.Size = new System.Drawing.Size(538, 341);
            this.board_Panel.TabIndex = 1;
            this.board_Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_Panel_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newGame_Button);
            this.panel1.Controls.Add(this.turn_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 68);
            this.panel1.TabIndex = 0;
            // 
            // newGame_Button
            // 
            this.newGame_Button.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame_Button.Location = new System.Drawing.Point(385, 11);
            this.newGame_Button.Name = "newGame_Button";
            this.newGame_Button.Size = new System.Drawing.Size(141, 45);
            this.newGame_Button.TabIndex = 1;
            this.newGame_Button.Text = "New Game";
            this.newGame_Button.UseVisualStyleBackColor = true;
            this.newGame_Button.Click += new System.EventHandler(this.newGame_Button_Click);
            // 
            // turn_Label
            // 
            this.turn_Label.AutoSize = true;
            this.turn_Label.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn_Label.Location = new System.Drawing.Point(12, 24);
            this.turn_Label.Name = "turn_Label";
            this.turn_Label.Size = new System.Drawing.Size(102, 32);
            this.turn_Label.TabIndex = 0;
            this.turn_Label.Text = "Turn: X";
            // 
            // board_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 451);
            this.Controls.Add(this.board_Panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "board_Form";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.board_Form_Load);
            this.Shown += new System.EventHandler(this.board_Form_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel board_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newGame_Button;
        private System.Windows.Forms.Label turn_Label;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutTicTacToeToolStripMenuItem;
    }
}

