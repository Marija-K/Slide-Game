namespace Slide_game
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
            this.components = new System.ComponentModel.Container();
            this.Player_Movement_UP = new System.Windows.Forms.Timer(this.components);
            this.Player_Movement_DOWN = new System.Windows.Forms.Timer(this.components);
            this.Player_Movement_LEFT = new System.Windows.Forms.Timer(this.components);
            this.Player_Movement_RIGHT = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.Score_Timer = new System.Windows.Forms.Timer(this.components);
            this.Dead = new System.Windows.Forms.Label();
            this.Start_Game_Button = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.High_Score_Button = new System.Windows.Forms.Button();
            this.How_To_Play_Button = new System.Windows.Forms.Button();
            this.Level_Select_Button = new System.Windows.Forms.Button();
            this.HighScorePanel = new System.Windows.Forms.Panel();
            this.PausePanel = new System.Windows.Forms.Panel();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.RetryButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.DeathPanel = new System.Windows.Forms.Panel();
            this.QuitPanel = new System.Windows.Forms.Panel();
            this.No_Button = new System.Windows.Forms.Button();
            this.Yes_Button = new System.Windows.Forms.Button();
            this.Quit_Check_Label = new System.Windows.Forms.Label();
            this.LevelSelectPanel = new System.Windows.Forms.Panel();
            this.Back_Button2 = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Level_Selection_Panel = new System.Windows.Forms.Panel();
            this.Level5_Button = new System.Windows.Forms.Button();
            this.Level4_Button = new System.Windows.Forms.Button();
            this.Level3_Button = new System.Windows.Forms.Button();
            this.Level2_Button = new System.Windows.Forms.Button();
            this.Level1_Button = new System.Windows.Forms.Button();
            this.Level_Select_Label = new System.Windows.Forms.Label();
            this.LevelCompletePanel = new System.Windows.Forms.Panel();
            this.MainMenu2 = new System.Windows.Forms.Button();
            this.CoinsLeft = new System.Windows.Forms.Label();
            this.CurrentLevel = new System.Windows.Forms.Label();
            this.Pause_Button = new System.Windows.Forms.Button();
            this.StatsPanel = new System.Windows.Forms.Panel();
            this.Back_Button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HighScoreDisplayPanel = new System.Windows.Forms.Panel();
            this.Levels_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Level1_Score = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Level2_Score = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Level3_Score = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Level4_Score = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Level5_Score = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Total_Score = new System.Windows.Forms.Label();
            this.Reset_Score_Button = new System.Windows.Forms.Button();
            this.TimerScore_Timer = new System.Windows.Forms.Timer(this.components);
            this.Retry_Button2 = new System.Windows.Forms.Button();
            this.Next_Level_Button = new System.Windows.Forms.Button();
            this.Score_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Current_Level_Timer_Score = new System.Windows.Forms.Label();
            this.Coins_Bonus_Score = new System.Windows.Forms.Label();
            this.Total_Current_Level_Score = new System.Windows.Forms.Label();
            this.Coins_Ratio = new System.Windows.Forms.Label();
            this.Retry_Button3 = new System.Windows.Forms.Button();
            this.MainMenu_Button3 = new System.Windows.Forms.Button();
            this.PBSlideGame = new System.Windows.Forms.PictureBox();
            this.HowtoPlayPanel = new System.Windows.Forms.Panel();
            this.Back_Button = new System.Windows.Forms.Button();
            this.GameWonPanel = new System.Windows.Forms.Panel();
            this.GameWon_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Enemy_Movement_Timer = new System.Windows.Forms.Timer(this.components);
            this.MainMenuPanel.SuspendLayout();
            this.HighScorePanel.SuspendLayout();
            this.PausePanel.SuspendLayout();
            this.DeathPanel.SuspendLayout();
            this.QuitPanel.SuspendLayout();
            this.LevelSelectPanel.SuspendLayout();
            this.Level_Selection_Panel.SuspendLayout();
            this.LevelCompletePanel.SuspendLayout();
            this.StatsPanel.SuspendLayout();
            this.HighScoreDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSlideGame)).BeginInit();
            this.HowtoPlayPanel.SuspendLayout();
            this.GameWonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player_Movement_UP
            // 
            this.Player_Movement_UP.Interval = 10;
            this.Player_Movement_UP.Tick += new System.EventHandler(this.Player_Movement_Timer_Tick_UP);
            // 
            // Player_Movement_DOWN
            // 
            this.Player_Movement_DOWN.Interval = 10;
            this.Player_Movement_DOWN.Tick += new System.EventHandler(this.Player_Movement_DOWN_Tick);
            // 
            // Player_Movement_LEFT
            // 
            this.Player_Movement_LEFT.Interval = 10;
            this.Player_Movement_LEFT.Tick += new System.EventHandler(this.Player_Movement_LEFT_Tick);
            // 
            // Player_Movement_RIGHT
            // 
            this.Player_Movement_RIGHT.Interval = 10;
            this.Player_Movement_RIGHT.Tick += new System.EventHandler(this.Player_Movement_RIGHT_Tick);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.BackColor = System.Drawing.Color.Transparent;
            this.Timer.Location = new System.Drawing.Point(75, 35);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(35, 13);
            this.Timer.TabIndex = 2;
            this.Timer.Text = "label1";
            // 
            // Score_Timer
            // 
            this.Score_Timer.Enabled = true;
            this.Score_Timer.Tick += new System.EventHandler(this.Score_Timer_Tick);
            // 
            // Dead
            // 
            this.Dead.AutoSize = true;
            this.Dead.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dead.ForeColor = System.Drawing.Color.Black;
            this.Dead.Location = new System.Drawing.Point(68, 85);
            this.Dead.Name = "Dead";
            this.Dead.Size = new System.Drawing.Size(144, 31);
            this.Dead.TabIndex = 0;
            this.Dead.Text = "You died!!!";
            // 
            // Start_Game_Button
            // 
            this.Start_Game_Button.Location = new System.Drawing.Point(255, 300);
            this.Start_Game_Button.Name = "Start_Game_Button";
            this.Start_Game_Button.Size = new System.Drawing.Size(90, 23);
            this.Start_Game_Button.TabIndex = 4;
            this.Start_Game_Button.Text = "Start Game";
            this.Start_Game_Button.UseVisualStyleBackColor = true;
            this.Start_Game_Button.Click += new System.EventHandler(this.Start_Game_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.QuitButton);
            this.MainMenuPanel.Controls.Add(this.High_Score_Button);
            this.MainMenuPanel.Controls.Add(this.How_To_Play_Button);
            this.MainMenuPanel.Controls.Add(this.Level_Select_Button);
            this.MainMenuPanel.Controls.Add(this.PBSlideGame);
            this.MainMenuPanel.Controls.Add(this.Start_Game_Button);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(600, 687);
            this.MainMenuPanel.TabIndex = 6;
            this.MainMenuPanel.Visible = false;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(255, 460);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(90, 23);
            this.QuitButton.TabIndex = 9;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // High_Score_Button
            // 
            this.High_Score_Button.Location = new System.Drawing.Point(255, 420);
            this.High_Score_Button.Name = "High_Score_Button";
            this.High_Score_Button.Size = new System.Drawing.Size(90, 23);
            this.High_Score_Button.TabIndex = 8;
            this.High_Score_Button.Text = "High Score";
            this.High_Score_Button.UseVisualStyleBackColor = true;
            this.High_Score_Button.Click += new System.EventHandler(this.High_Score_Button_Click);
            // 
            // How_To_Play_Button
            // 
            this.How_To_Play_Button.Location = new System.Drawing.Point(255, 380);
            this.How_To_Play_Button.Name = "How_To_Play_Button";
            this.How_To_Play_Button.Size = new System.Drawing.Size(90, 23);
            this.How_To_Play_Button.TabIndex = 7;
            this.How_To_Play_Button.Text = "How To Play";
            this.How_To_Play_Button.UseVisualStyleBackColor = true;
            this.How_To_Play_Button.Click += new System.EventHandler(this.How_To_Play_Button_Click);
            // 
            // Level_Select_Button
            // 
            this.Level_Select_Button.Location = new System.Drawing.Point(255, 340);
            this.Level_Select_Button.Name = "Level_Select_Button";
            this.Level_Select_Button.Size = new System.Drawing.Size(90, 23);
            this.Level_Select_Button.TabIndex = 6;
            this.Level_Select_Button.Text = "Level Select";
            this.Level_Select_Button.UseVisualStyleBackColor = true;
            this.Level_Select_Button.Click += new System.EventHandler(this.Level_Select_Button_Click);
            // 
            // HighScorePanel
            // 
            this.HighScorePanel.Controls.Add(this.Reset_Score_Button);
            this.HighScorePanel.Controls.Add(this.HighScoreDisplayPanel);
            this.HighScorePanel.Controls.Add(this.label1);
            this.HighScorePanel.Controls.Add(this.Back_Button3);
            this.HighScorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HighScorePanel.Location = new System.Drawing.Point(0, 0);
            this.HighScorePanel.Name = "HighScorePanel";
            this.HighScorePanel.Size = new System.Drawing.Size(600, 687);
            this.HighScorePanel.TabIndex = 0;
            this.HighScorePanel.Visible = false;
            // 
            // PausePanel
            // 
            this.PausePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PausePanel.Controls.Add(this.MainMenuButton);
            this.PausePanel.Controls.Add(this.RetryButton);
            this.PausePanel.Controls.Add(this.ContinueButton);
            this.PausePanel.Location = new System.Drawing.Point(162, 153);
            this.PausePanel.Name = "PausePanel";
            this.PausePanel.Size = new System.Drawing.Size(276, 227);
            this.PausePanel.TabIndex = 0;
            this.PausePanel.Visible = false;
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(101, 160);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.MainMenuButton.TabIndex = 3;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // RetryButton
            // 
            this.RetryButton.Location = new System.Drawing.Point(101, 108);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(75, 23);
            this.RetryButton.TabIndex = 2;
            this.RetryButton.Text = "Retry";
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Click += new System.EventHandler(this.Retry_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(101, 59);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // DeathPanel
            // 
            this.DeathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeathPanel.Controls.Add(this.MainMenu_Button3);
            this.DeathPanel.Controls.Add(this.Retry_Button3);
            this.DeathPanel.Controls.Add(this.Dead);
            this.DeathPanel.Location = new System.Drawing.Point(159, 153);
            this.DeathPanel.Name = "DeathPanel";
            this.DeathPanel.Size = new System.Drawing.Size(282, 233);
            this.DeathPanel.TabIndex = 2;
            this.DeathPanel.Visible = false;
            // 
            // QuitPanel
            // 
            this.QuitPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuitPanel.Controls.Add(this.No_Button);
            this.QuitPanel.Controls.Add(this.Yes_Button);
            this.QuitPanel.Controls.Add(this.Quit_Check_Label);
            this.QuitPanel.Location = new System.Drawing.Point(193, 196);
            this.QuitPanel.Name = "QuitPanel";
            this.QuitPanel.Size = new System.Drawing.Size(214, 140);
            this.QuitPanel.TabIndex = 2;
            this.QuitPanel.Visible = false;
            // 
            // No_Button
            // 
            this.No_Button.Location = new System.Drawing.Point(130, 100);
            this.No_Button.Name = "No_Button";
            this.No_Button.Size = new System.Drawing.Size(52, 23);
            this.No_Button.TabIndex = 2;
            this.No_Button.Text = "No";
            this.No_Button.UseVisualStyleBackColor = true;
            this.No_Button.Click += new System.EventHandler(this.No_Button_Click);
            // 
            // Yes_Button
            // 
            this.Yes_Button.Location = new System.Drawing.Point(36, 100);
            this.Yes_Button.Name = "Yes_Button";
            this.Yes_Button.Size = new System.Drawing.Size(48, 23);
            this.Yes_Button.TabIndex = 1;
            this.Yes_Button.Text = "Yes";
            this.Yes_Button.UseVisualStyleBackColor = true;
            this.Yes_Button.Click += new System.EventHandler(this.Yes_Button_Click);
            // 
            // Quit_Check_Label
            // 
            this.Quit_Check_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_Check_Label.Location = new System.Drawing.Point(32, 32);
            this.Quit_Check_Label.Name = "Quit_Check_Label";
            this.Quit_Check_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Quit_Check_Label.Size = new System.Drawing.Size(150, 56);
            this.Quit_Check_Label.TabIndex = 0;
            this.Quit_Check_Label.Text = "Are you sure you want to quit?";
            this.Quit_Check_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LevelSelectPanel
            // 
            this.LevelSelectPanel.Controls.Add(this.Back_Button2);
            this.LevelSelectPanel.Controls.Add(this.Reset_Button);
            this.LevelSelectPanel.Controls.Add(this.Level_Selection_Panel);
            this.LevelSelectPanel.Controls.Add(this.Level_Select_Label);
            this.LevelSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.LevelSelectPanel.Name = "LevelSelectPanel";
            this.LevelSelectPanel.Size = new System.Drawing.Size(600, 687);
            this.LevelSelectPanel.TabIndex = 2;
            this.LevelSelectPanel.Visible = false;
            // 
            // Back_Button2
            // 
            this.Back_Button2.Location = new System.Drawing.Point(255, 442);
            this.Back_Button2.Name = "Back_Button2";
            this.Back_Button2.Size = new System.Drawing.Size(92, 38);
            this.Back_Button2.TabIndex = 1;
            this.Back_Button2.Text = "Back";
            this.Back_Button2.UseVisualStyleBackColor = true;
            this.Back_Button2.Click += new System.EventHandler(this.Back_Button2_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(255, 508);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Reset_Button.Size = new System.Drawing.Size(92, 38);
            this.Reset_Button.TabIndex = 2;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Level_Selection_Panel
            // 
            this.Level_Selection_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Level_Selection_Panel.Controls.Add(this.Level5_Button);
            this.Level_Selection_Panel.Controls.Add(this.Level4_Button);
            this.Level_Selection_Panel.Controls.Add(this.Level3_Button);
            this.Level_Selection_Panel.Controls.Add(this.Level2_Button);
            this.Level_Selection_Panel.Controls.Add(this.Level1_Button);
            this.Level_Selection_Panel.Location = new System.Drawing.Point(113, 153);
            this.Level_Selection_Panel.Name = "Level_Selection_Panel";
            this.Level_Selection_Panel.Size = new System.Drawing.Size(375, 262);
            this.Level_Selection_Panel.TabIndex = 1;
            // 
            // Level5_Button
            // 
            this.Level5_Button.Enabled = false;
            this.Level5_Button.Location = new System.Drawing.Point(150, 152);
            this.Level5_Button.Name = "Level5_Button";
            this.Level5_Button.Size = new System.Drawing.Size(75, 75);
            this.Level5_Button.TabIndex = 4;
            this.Level5_Button.Text = "5";
            this.Level5_Button.UseVisualStyleBackColor = true;
            this.Level5_Button.Click += new System.EventHandler(this.Level5_Button_Click);
            // 
            // Level4_Button
            // 
            this.Level4_Button.Enabled = false;
            this.Level4_Button.Location = new System.Drawing.Point(31, 152);
            this.Level4_Button.Name = "Level4_Button";
            this.Level4_Button.Size = new System.Drawing.Size(75, 75);
            this.Level4_Button.TabIndex = 3;
            this.Level4_Button.Text = "4";
            this.Level4_Button.UseVisualStyleBackColor = true;
            this.Level4_Button.Click += new System.EventHandler(this.Level4_Button_Click);
            // 
            // Level3_Button
            // 
            this.Level3_Button.Enabled = false;
            this.Level3_Button.Location = new System.Drawing.Point(268, 43);
            this.Level3_Button.Name = "Level3_Button";
            this.Level3_Button.Size = new System.Drawing.Size(75, 75);
            this.Level3_Button.TabIndex = 2;
            this.Level3_Button.Text = "3";
            this.Level3_Button.UseVisualStyleBackColor = true;
            this.Level3_Button.Click += new System.EventHandler(this.Level3_Button_Click);
            // 
            // Level2_Button
            // 
            this.Level2_Button.Enabled = false;
            this.Level2_Button.Location = new System.Drawing.Point(150, 43);
            this.Level2_Button.Name = "Level2_Button";
            this.Level2_Button.Size = new System.Drawing.Size(75, 75);
            this.Level2_Button.TabIndex = 1;
            this.Level2_Button.Text = "2";
            this.Level2_Button.UseVisualStyleBackColor = true;
            this.Level2_Button.Click += new System.EventHandler(this.Level2_Button_Click);
            // 
            // Level1_Button
            // 
            this.Level1_Button.Location = new System.Drawing.Point(31, 43);
            this.Level1_Button.Name = "Level1_Button";
            this.Level1_Button.Size = new System.Drawing.Size(75, 75);
            this.Level1_Button.TabIndex = 0;
            this.Level1_Button.Text = "1";
            this.Level1_Button.UseVisualStyleBackColor = true;
            this.Level1_Button.Click += new System.EventHandler(this.Level1_Button_Click);
            // 
            // Level_Select_Label
            // 
            this.Level_Select_Label.AutoSize = true;
            this.Level_Select_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_Select_Label.Location = new System.Drawing.Point(150, 50);
            this.Level_Select_Label.Name = "Level_Select_Label";
            this.Level_Select_Label.Size = new System.Drawing.Size(301, 59);
            this.Level_Select_Label.TabIndex = 0;
            this.Level_Select_Label.Text = "Level Select";
            // 
            // LevelCompletePanel
            // 
            this.LevelCompletePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LevelCompletePanel.Controls.Add(this.Coins_Ratio);
            this.LevelCompletePanel.Controls.Add(this.Total_Current_Level_Score);
            this.LevelCompletePanel.Controls.Add(this.Coins_Bonus_Score);
            this.LevelCompletePanel.Controls.Add(this.Current_Level_Timer_Score);
            this.LevelCompletePanel.Controls.Add(this.label8);
            this.LevelCompletePanel.Controls.Add(this.label6);
            this.LevelCompletePanel.Controls.Add(this.label4);
            this.LevelCompletePanel.Controls.Add(this.Score_Label);
            this.LevelCompletePanel.Controls.Add(this.Next_Level_Button);
            this.LevelCompletePanel.Controls.Add(this.Retry_Button2);
            this.LevelCompletePanel.Controls.Add(this.MainMenu2);
            this.LevelCompletePanel.Location = new System.Drawing.Point(150, 175);
            this.LevelCompletePanel.Name = "LevelCompletePanel";
            this.LevelCompletePanel.Size = new System.Drawing.Size(300, 200);
            this.LevelCompletePanel.TabIndex = 6;
            this.LevelCompletePanel.Visible = false;
            // 
            // MainMenu2
            // 
            this.MainMenu2.Location = new System.Drawing.Point(25, 163);
            this.MainMenu2.Name = "MainMenu2";
            this.MainMenu2.Size = new System.Drawing.Size(75, 23);
            this.MainMenu2.TabIndex = 4;
            this.MainMenu2.Text = "Main Menu";
            this.MainMenu2.UseVisualStyleBackColor = true;
            this.MainMenu2.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // CoinsLeft
            // 
            this.CoinsLeft.AutoSize = true;
            this.CoinsLeft.Location = new System.Drawing.Point(187, 35);
            this.CoinsLeft.Name = "CoinsLeft";
            this.CoinsLeft.Size = new System.Drawing.Size(35, 13);
            this.CoinsLeft.TabIndex = 10;
            this.CoinsLeft.Text = "label1";
            // 
            // CurrentLevel
            // 
            this.CurrentLevel.AutoSize = true;
            this.CurrentLevel.Location = new System.Drawing.Point(338, 35);
            this.CurrentLevel.Name = "CurrentLevel";
            this.CurrentLevel.Size = new System.Drawing.Size(35, 13);
            this.CurrentLevel.TabIndex = 11;
            this.CurrentLevel.Text = "label1";
            // 
            // Pause_Button
            // 
            this.Pause_Button.Location = new System.Drawing.Point(472, 30);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(75, 23);
            this.Pause_Button.TabIndex = 12;
            this.Pause_Button.Text = "Pause";
            this.Pause_Button.UseVisualStyleBackColor = true;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // StatsPanel
            // 
            this.StatsPanel.Controls.Add(this.Pause_Button);
            this.StatsPanel.Controls.Add(this.CurrentLevel);
            this.StatsPanel.Controls.Add(this.CoinsLeft);
            this.StatsPanel.Controls.Add(this.Timer);
            this.StatsPanel.Location = new System.Drawing.Point(3, 604);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(594, 80);
            this.StatsPanel.TabIndex = 13;
            this.StatsPanel.Visible = false;
            // 
            // Back_Button3
            // 
            this.Back_Button3.Location = new System.Drawing.Point(246, 464);
            this.Back_Button3.Name = "Back_Button3";
            this.Back_Button3.Size = new System.Drawing.Size(92, 38);
            this.Back_Button3.TabIndex = 3;
            this.Back_Button3.Text = "Back";
            this.Back_Button3.UseVisualStyleBackColor = true;
            this.Back_Button3.Click += new System.EventHandler(this.Back_Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "High Scores";
            // 
            // HighScoreDisplayPanel
            // 
            this.HighScoreDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighScoreDisplayPanel.Controls.Add(this.Total_Score);
            this.HighScoreDisplayPanel.Controls.Add(this.label13);
            this.HighScoreDisplayPanel.Controls.Add(this.Level5_Score);
            this.HighScoreDisplayPanel.Controls.Add(this.label11);
            this.HighScoreDisplayPanel.Controls.Add(this.Level4_Score);
            this.HighScoreDisplayPanel.Controls.Add(this.label9);
            this.HighScoreDisplayPanel.Controls.Add(this.Level3_Score);
            this.HighScoreDisplayPanel.Controls.Add(this.label7);
            this.HighScoreDisplayPanel.Controls.Add(this.Level2_Score);
            this.HighScoreDisplayPanel.Controls.Add(this.label5);
            this.HighScoreDisplayPanel.Controls.Add(this.Level1_Score);
            this.HighScoreDisplayPanel.Controls.Add(this.label3);
            this.HighScoreDisplayPanel.Controls.Add(this.label2);
            this.HighScoreDisplayPanel.Controls.Add(this.Levels_Label);
            this.HighScoreDisplayPanel.Location = new System.Drawing.Point(131, 158);
            this.HighScoreDisplayPanel.Name = "HighScoreDisplayPanel";
            this.HighScoreDisplayPanel.Size = new System.Drawing.Size(339, 253);
            this.HighScoreDisplayPanel.TabIndex = 5;
            // 
            // Levels_Label
            // 
            this.Levels_Label.AutoSize = true;
            this.Levels_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Levels_Label.Location = new System.Drawing.Point(55, 37);
            this.Levels_Label.Name = "Levels_Label";
            this.Levels_Label.Size = new System.Drawing.Size(64, 25);
            this.Levels_Label.TabIndex = 0;
            this.Levels_Label.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1";
            // 
            // Level1_Score
            // 
            this.Level1_Score.AutoSize = true;
            this.Level1_Score.Location = new System.Drawing.Point(230, 85);
            this.Level1_Score.Name = "Level1_Score";
            this.Level1_Score.Size = new System.Drawing.Size(35, 13);
            this.Level1_Score.TabIndex = 3;
            this.Level1_Score.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "2";
            // 
            // Level2_Score
            // 
            this.Level2_Score.AutoSize = true;
            this.Level2_Score.Location = new System.Drawing.Point(230, 110);
            this.Level2_Score.Name = "Level2_Score";
            this.Level2_Score.Size = new System.Drawing.Size(35, 13);
            this.Level2_Score.TabIndex = 5;
            this.Level2_Score.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "3";
            // 
            // Level3_Score
            // 
            this.Level3_Score.AutoSize = true;
            this.Level3_Score.Location = new System.Drawing.Point(230, 135);
            this.Level3_Score.Name = "Level3_Score";
            this.Level3_Score.Size = new System.Drawing.Size(35, 13);
            this.Level3_Score.TabIndex = 7;
            this.Level3_Score.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "4";
            // 
            // Level4_Score
            // 
            this.Level4_Score.AutoSize = true;
            this.Level4_Score.Location = new System.Drawing.Point(230, 159);
            this.Level4_Score.Name = "Level4_Score";
            this.Level4_Score.Size = new System.Drawing.Size(41, 13);
            this.Level4_Score.TabIndex = 9;
            this.Level4_Score.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "5";
            // 
            // Level5_Score
            // 
            this.Level5_Score.AutoSize = true;
            this.Level5_Score.Location = new System.Drawing.Point(230, 185);
            this.Level5_Score.Name = "Level5_Score";
            this.Level5_Score.Size = new System.Drawing.Size(41, 13);
            this.Level5_Score.TabIndex = 11;
            this.Level5_Score.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total";
            // 
            // Total_Score
            // 
            this.Total_Score.AutoSize = true;
            this.Total_Score.Location = new System.Drawing.Point(230, 215);
            this.Total_Score.Name = "Total_Score";
            this.Total_Score.Size = new System.Drawing.Size(41, 13);
            this.Total_Score.TabIndex = 13;
            this.Total_Score.Text = "label14";
            // 
            // Reset_Score_Button
            // 
            this.Reset_Score_Button.Location = new System.Drawing.Point(246, 534);
            this.Reset_Score_Button.Name = "Reset_Score_Button";
            this.Reset_Score_Button.Size = new System.Drawing.Size(92, 38);
            this.Reset_Score_Button.TabIndex = 6;
            this.Reset_Score_Button.Text = "Reset";
            this.Reset_Score_Button.UseVisualStyleBackColor = true;
            this.Reset_Score_Button.Click += new System.EventHandler(this.Reset_Score_Button_Click);
            // 
            // TimerScore_Timer
            // 
            this.TimerScore_Timer.Interval = 500;
            this.TimerScore_Timer.Tick += new System.EventHandler(this.TimerScore_Timer_Tick);
            // 
            // Retry_Button2
            // 
            this.Retry_Button2.Location = new System.Drawing.Point(113, 163);
            this.Retry_Button2.Name = "Retry_Button2";
            this.Retry_Button2.Size = new System.Drawing.Size(75, 23);
            this.Retry_Button2.TabIndex = 5;
            this.Retry_Button2.Text = "Retry";
            this.Retry_Button2.UseVisualStyleBackColor = true;
            this.Retry_Button2.Click += new System.EventHandler(this.Retry_Click);
            // 
            // Next_Level_Button
            // 
            this.Next_Level_Button.Location = new System.Drawing.Point(208, 163);
            this.Next_Level_Button.Name = "Next_Level_Button";
            this.Next_Level_Button.Size = new System.Drawing.Size(75, 23);
            this.Next_Level_Button.TabIndex = 6;
            this.Next_Level_Button.Text = "Next Level";
            this.Next_Level_Button.UseVisualStyleBackColor = true;
            this.Next_Level_Button.Click += new System.EventHandler(this.Next_Level_Click);
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Label.Location = new System.Drawing.Point(113, 20);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(58, 20);
            this.Score_Label.TabIndex = 7;
            this.Score_Label.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Bonus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Coins Bonus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Score";
            // 
            // Current_Level_Timer_Score
            // 
            this.Current_Level_Timer_Score.AutoSize = true;
            this.Current_Level_Timer_Score.Location = new System.Drawing.Point(145, 63);
            this.Current_Level_Timer_Score.Name = "Current_Level_Timer_Score";
            this.Current_Level_Timer_Score.Size = new System.Drawing.Size(41, 13);
            this.Current_Level_Timer_Score.TabIndex = 11;
            this.Current_Level_Timer_Score.Text = "label10";
            // 
            // Coins_Bonus_Score
            // 
            this.Coins_Bonus_Score.AutoSize = true;
            this.Coins_Bonus_Score.Location = new System.Drawing.Point(144, 93);
            this.Coins_Bonus_Score.Name = "Coins_Bonus_Score";
            this.Coins_Bonus_Score.Size = new System.Drawing.Size(41, 13);
            this.Coins_Bonus_Score.TabIndex = 12;
            this.Coins_Bonus_Score.Text = "label10";
            // 
            // Total_Current_Level_Score
            // 
            this.Total_Current_Level_Score.AutoSize = true;
            this.Total_Current_Level_Score.Location = new System.Drawing.Point(144, 131);
            this.Total_Current_Level_Score.Name = "Total_Current_Level_Score";
            this.Total_Current_Level_Score.Size = new System.Drawing.Size(41, 13);
            this.Total_Current_Level_Score.TabIndex = 13;
            this.Total_Current_Level_Score.Text = "label10";
            // 
            // Coins_Ratio
            // 
            this.Coins_Ratio.AutoSize = true;
            this.Coins_Ratio.Location = new System.Drawing.Point(214, 93);
            this.Coins_Ratio.Name = "Coins_Ratio";
            this.Coins_Ratio.Size = new System.Drawing.Size(41, 13);
            this.Coins_Ratio.TabIndex = 14;
            this.Coins_Ratio.Text = "label10";
            // 
            // Retry_Button3
            // 
            this.Retry_Button3.Location = new System.Drawing.Point(182, 172);
            this.Retry_Button3.Name = "Retry_Button3";
            this.Retry_Button3.Size = new System.Drawing.Size(75, 23);
            this.Retry_Button3.TabIndex = 6;
            this.Retry_Button3.Text = "Retry";
            this.Retry_Button3.UseVisualStyleBackColor = true;
            this.Retry_Button3.Click += new System.EventHandler(this.Retry_Click);
            // 
            // MainMenu_Button3
            // 
            this.MainMenu_Button3.Location = new System.Drawing.Point(32, 172);
            this.MainMenu_Button3.Name = "MainMenu_Button3";
            this.MainMenu_Button3.Size = new System.Drawing.Size(75, 23);
            this.MainMenu_Button3.TabIndex = 7;
            this.MainMenu_Button3.Text = "Main Menu";
            this.MainMenu_Button3.UseVisualStyleBackColor = true;
            this.MainMenu_Button3.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // PBSlideGame
            // 
            this.PBSlideGame.Image = global::Slide_game.Properties.Resources.Title;
            this.PBSlideGame.Location = new System.Drawing.Point(50, 57);
            this.PBSlideGame.MaximumSize = new System.Drawing.Size(500, 150);
            this.PBSlideGame.MinimumSize = new System.Drawing.Size(500, 150);
            this.PBSlideGame.Name = "PBSlideGame";
            this.PBSlideGame.Size = new System.Drawing.Size(500, 150);
            this.PBSlideGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSlideGame.TabIndex = 5;
            this.PBSlideGame.TabStop = false;
            // 
            // HowtoPlayPanel
            // 
            this.HowtoPlayPanel.BackgroundImage = global::Slide_game.Properties.Resources.HowToPlay;
            this.HowtoPlayPanel.Controls.Add(this.Back_Button);
            this.HowtoPlayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HowtoPlayPanel.Location = new System.Drawing.Point(0, 0);
            this.HowtoPlayPanel.Name = "HowtoPlayPanel";
            this.HowtoPlayPanel.Size = new System.Drawing.Size(600, 687);
            this.HowtoPlayPanel.TabIndex = 0;
            this.HowtoPlayPanel.Visible = false;
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(28, 34);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(85, 44);
            this.Back_Button.TabIndex = 0;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // GameWonPanel
            // 
            this.GameWonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameWonPanel.Controls.Add(this.button1);
            this.GameWonPanel.Controls.Add(this.GameWon_Label);
            this.GameWonPanel.Location = new System.Drawing.Point(174, 141);
            this.GameWonPanel.Name = "GameWonPanel";
            this.GameWonPanel.Size = new System.Drawing.Size(252, 163);
            this.GameWonPanel.TabIndex = 10;
            this.GameWonPanel.Visible = false;
            // 
            // GameWon_Label
            // 
            this.GameWon_Label.AutoSize = true;
            this.GameWon_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameWon_Label.Location = new System.Drawing.Point(13, 25);
            this.GameWon_Label.Name = "GameWon_Label";
            this.GameWon_Label.Size = new System.Drawing.Size(226, 50);
            this.GameWon_Label.TabIndex = 0;
            this.GameWon_Label.Text = "Good Job!!\r\nYou beat the last level";
            this.GameWon_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // Enemy_Movement_Timer
            // 
            this.Enemy_Movement_Timer.Interval = 20;
            this.Enemy_Movement_Timer.Tick += new System.EventHandler(this.Enemy_Movement_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 687);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.LevelSelectPanel);
            this.Controls.Add(this.HowtoPlayPanel);
            this.Controls.Add(this.StatsPanel);
            this.Controls.Add(this.DeathPanel);
            this.Controls.Add(this.HighScorePanel);
            this.Controls.Add(this.QuitPanel);
            this.Controls.Add(this.GameWonPanel);
            this.Controls.Add(this.PausePanel);
            this.Controls.Add(this.LevelCompletePanel);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(616, 726);
            this.MinimumSize = new System.Drawing.Size(616, 726);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MainMenuPanel.ResumeLayout(false);
            this.HighScorePanel.ResumeLayout(false);
            this.HighScorePanel.PerformLayout();
            this.PausePanel.ResumeLayout(false);
            this.DeathPanel.ResumeLayout(false);
            this.DeathPanel.PerformLayout();
            this.QuitPanel.ResumeLayout(false);
            this.LevelSelectPanel.ResumeLayout(false);
            this.LevelSelectPanel.PerformLayout();
            this.Level_Selection_Panel.ResumeLayout(false);
            this.LevelCompletePanel.ResumeLayout(false);
            this.LevelCompletePanel.PerformLayout();
            this.StatsPanel.ResumeLayout(false);
            this.StatsPanel.PerformLayout();
            this.HighScoreDisplayPanel.ResumeLayout(false);
            this.HighScoreDisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSlideGame)).EndInit();
            this.HowtoPlayPanel.ResumeLayout(false);
            this.GameWonPanel.ResumeLayout(false);
            this.GameWonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Player_Movement_UP;
        private System.Windows.Forms.Timer Player_Movement_DOWN;
        private System.Windows.Forms.Timer Player_Movement_LEFT;
        private System.Windows.Forms.Timer Player_Movement_RIGHT;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer Score_Timer;
        private System.Windows.Forms.Label Dead;
        private System.Windows.Forms.PictureBox PBSlideGame;
        private System.Windows.Forms.Button Start_Game_Button;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Panel HowtoPlayPanel;
        private System.Windows.Forms.Panel HighScorePanel;
        private System.Windows.Forms.Panel PausePanel;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Panel DeathPanel;
        private System.Windows.Forms.Panel QuitPanel;
        private System.Windows.Forms.Panel LevelSelectPanel;
        private System.Windows.Forms.Panel LevelCompletePanel;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Button MainMenu2;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button High_Score_Button;
        private System.Windows.Forms.Button How_To_Play_Button;
        private System.Windows.Forms.Button Level_Select_Button;
        private System.Windows.Forms.Button No_Button;
        private System.Windows.Forms.Button Yes_Button;
        private System.Windows.Forms.Label Quit_Check_Label;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label Level_Select_Label;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Panel Level_Selection_Panel;
        private System.Windows.Forms.Button Level5_Button;
        private System.Windows.Forms.Button Level4_Button;
        private System.Windows.Forms.Button Level3_Button;
        private System.Windows.Forms.Button Level2_Button;
        private System.Windows.Forms.Button Level1_Button;
        private System.Windows.Forms.Button Back_Button2;
        private System.Windows.Forms.Label CoinsLeft;
        private System.Windows.Forms.Label CurrentLevel;
        private System.Windows.Forms.Button Pause_Button;
        private System.Windows.Forms.Panel StatsPanel;
        private System.Windows.Forms.Button Back_Button3;
        private System.Windows.Forms.Button Reset_Score_Button;
        private System.Windows.Forms.Panel HighScoreDisplayPanel;
        private System.Windows.Forms.Label Total_Score;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Level5_Score;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Level4_Score;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Level3_Score;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Level2_Score;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Level1_Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Levels_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerScore_Timer;
        private System.Windows.Forms.Label Coins_Ratio;
        private System.Windows.Forms.Label Total_Current_Level_Score;
        private System.Windows.Forms.Label Coins_Bonus_Score;
        private System.Windows.Forms.Label Current_Level_Timer_Score;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Score_Label;
        private System.Windows.Forms.Button Next_Level_Button;
        private System.Windows.Forms.Button Retry_Button2;
        private System.Windows.Forms.Button MainMenu_Button3;
        private System.Windows.Forms.Button Retry_Button3;
        private System.Windows.Forms.Panel GameWonPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GameWon_Label;
        private System.Windows.Forms.Timer Enemy_Movement_Timer;
    }
}

