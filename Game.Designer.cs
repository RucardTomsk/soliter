namespace Soliter
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            panel = new Panel();
            reset_timer = new System.Windows.Forms.Timer(components);
            buttonPause = new Button();
            buttonReset = new Button();
            sec_label = new Label();
            sec_timer = new System.Windows.Forms.Timer(components);
            buttonExit = new Button();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(12, 9);
            panel.Name = "panel";
            panel.Size = new Size(910, 1000);
            panel.TabIndex = 2;
            
            panel.Click += panel_Click;
            panel.Paint += panel_Paint;
            // 
            // reset_timer
            // 
            reset_timer.Enabled = true;
            reset_timer.Interval = 25;
            reset_timer.Tick += reset_timer_Tick;
            // 
            // buttonPause
            // 
            buttonPause.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPause.Location = new Point(937, 50);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(134, 46);
            buttonPause.TabIndex = 5;
            buttonPause.Text = "Пауза";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.Location = new Point(937, 102);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(134, 46);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Перезапустить";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // sec_label
            // 
            sec_label.AutoSize = true;
            sec_label.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            sec_label.Location = new Point(960, 9);
            sec_label.Name = "sec_label";
            sec_label.Size = new Size(90, 36);
            sec_label.TabIndex = 7;
            sec_label.Text = "00:00";
            // 
            // sec_timer
            // 
            sec_timer.Interval = 1000;
            sec_timer.Tick += sec_timer_Tick;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(255, 128, 128);
            buttonExit.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(938, 154);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(134, 46);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Game
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(1084, 1011);
            Controls.Add(buttonExit);
            Controls.Add(sec_label);
            Controls.Add(buttonReset);
            Controls.Add(buttonPause);
            Controls.Add(panel);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Косынка";
            WindowState = FormWindowState.Maximized;
            Load += Game_Load;
            Paint += Game_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel;
        private System.Windows.Forms.Timer reset_timer;
        private Button buttonPause;
        private Button buttonReset;
        private Label sec_label;
        private System.Windows.Forms.Timer sec_timer;
        private Button buttonExit;
    }
}