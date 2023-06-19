namespace Dodge_in_the_BOX
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.jumpTimer = new System.Windows.Forms.Timer(this.components);
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.countDownLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.gimmick6Timer = new System.Windows.Forms.Timer(this.components);
            this.gimmick7Timer = new System.Windows.Forms.Timer(this.components);
            this.gameResultLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.startCountDonwLabel = new System.Windows.Forms.Label();
            this.characterLabelPic = new System.Windows.Forms.PictureBox();
            this.playerPic = new System.Windows.Forms.PictureBox();
            this.gameMenuPIc = new System.Windows.Forms.PictureBox();
            this.playagainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.characterLabelPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMenuPIc)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 35;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // jumpTimer
            // 
            this.jumpTimer.Interval = 30;
            this.jumpTimer.Tick += new System.EventHandler(this.jumpTimer_Tick);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // countDownLabel
            // 
            this.countDownLabel.BackColor = System.Drawing.Color.Transparent;
            this.countDownLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.countDownLabel.Location = new System.Drawing.Point(219, 33);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(162, 51);
            this.countDownLabel.TabIndex = 1;
            this.countDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endLabel
            // 
            this.endLabel.BackColor = System.Drawing.Color.Transparent;
            this.endLabel.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.endLabel.Location = new System.Drawing.Point(34, 504);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(319, 40);
            this.endLabel.TabIndex = 2;
            this.endLabel.Text = "Lock him in a BOX again?";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endLabel.Visible = false;
            // 
            // gimmick6Timer
            // 
            this.gimmick6Timer.Interval = 60;
            this.gimmick6Timer.Tick += new System.EventHandler(this.gimmick6Timer_Tick);
            // 
            // gimmick7Timer
            // 
            this.gimmick7Timer.Interval = 30;
            this.gimmick7Timer.Tick += new System.EventHandler(this.gimmick7Timer_Tick);
            // 
            // gameResultLabel
            // 
            this.gameResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameResultLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameResultLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gameResultLabel.Location = new System.Drawing.Point(60, 183);
            this.gameResultLabel.Name = "gameResultLabel";
            this.gameResultLabel.Size = new System.Drawing.Size(480, 70);
            this.gameResultLabel.TabIndex = 3;
            this.gameResultLabel.Text = "Game Clear";
            this.gameResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameResultLabel.Visible = false;
            // 
            // hpLabel
            // 
            this.hpLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hpLabel.Location = new System.Drawing.Point(130, 574);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(58, 35);
            this.hpLabel.TabIndex = 5;
            this.hpLabel.Text = "HP";
            this.hpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hpLabel.Visible = false;
            // 
            // yesButton
            // 
            this.yesButton.Enabled = false;
            this.yesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.yesButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(367, 511);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(80, 30);
            this.yesButton.TabIndex = 6;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Enabled = false;
            this.noButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.noButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(473, 511);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(80, 30);
            this.noButton.TabIndex = 7;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menuLabel.Location = new System.Drawing.Point(141, 520);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(319, 40);
            this.menuLabel.TabIndex = 9;
            this.menuLabel.Text = "Press \"SPACE\" to start game";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuLabel.Visible = false;
            // 
            // startCountDonwLabel
            // 
            this.startCountDonwLabel.BackColor = System.Drawing.Color.Transparent;
            this.startCountDonwLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCountDonwLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startCountDonwLabel.Location = new System.Drawing.Point(262, 283);
            this.startCountDonwLabel.Name = "startCountDonwLabel";
            this.startCountDonwLabel.Size = new System.Drawing.Size(77, 70);
            this.startCountDonwLabel.TabIndex = 10;
            this.startCountDonwLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startCountDonwLabel.Visible = false;
            // 
            // characterLabelPic
            // 
            this.characterLabelPic.BackgroundImage = global::Dodge_in_the_BOX.Properties.Resources.characterLabel;
            this.characterLabelPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.characterLabelPic.Location = new System.Drawing.Point(187, 382);
            this.characterLabelPic.Name = "characterLabelPic";
            this.characterLabelPic.Size = new System.Drawing.Size(230, 59);
            this.characterLabelPic.TabIndex = 4;
            this.characterLabelPic.TabStop = false;
            this.characterLabelPic.Visible = false;
            // 
            // playerPic
            // 
            this.playerPic.BackColor = System.Drawing.Color.Transparent;
            this.playerPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerPic.BackgroundImage")));
            this.playerPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerPic.Location = new System.Drawing.Point(280, 447);
            this.playerPic.Name = "playerPic";
            this.playerPic.Size = new System.Drawing.Size(45, 24);
            this.playerPic.TabIndex = 0;
            this.playerPic.TabStop = false;
            // 
            // gameMenuPIc
            // 
            this.gameMenuPIc.BackgroundImage = global::Dodge_in_the_BOX.Properties.Resources.Game_Menu;
            this.gameMenuPIc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gameMenuPIc.Location = new System.Drawing.Point(74, 141);
            this.gameMenuPIc.Name = "gameMenuPIc";
            this.gameMenuPIc.Size = new System.Drawing.Size(452, 256);
            this.gameMenuPIc.TabIndex = 8;
            this.gameMenuPIc.TabStop = false;
            this.gameMenuPIc.Visible = false;
            // 
            // playagainLabel
            // 
            this.playagainLabel.BackColor = System.Drawing.Color.Transparent;
            this.playagainLabel.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.playagainLabel.Location = new System.Drawing.Point(102, 505);
            this.playagainLabel.Name = "playagainLabel";
            this.playagainLabel.Size = new System.Drawing.Size(166, 40);
            this.playagainLabel.TabIndex = 11;
            this.playagainLabel.Text = "Play again?";
            this.playagainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playagainLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(171, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter the player NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(438, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 31);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 637);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playagainLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.startCountDonwLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.characterLabelPic);
            this.Controls.Add(this.gameResultLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.countDownLabel);
            this.Controls.Add(this.playerPic);
            this.Controls.Add(this.gameMenuPIc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.characterLabelPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMenuPIc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPic;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer jumpTimer;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label countDownLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Timer gimmick6Timer;
        private System.Windows.Forms.Timer gimmick7Timer;
        private System.Windows.Forms.Label gameResultLabel;
        private System.Windows.Forms.PictureBox characterLabelPic;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.PictureBox gameMenuPIc;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Label startCountDonwLabel;
        private System.Windows.Forms.Label playagainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

