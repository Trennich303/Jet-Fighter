namespace Jet_Fighter
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerWhite = new System.Windows.Forms.Label();
            this.playerBlack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // playerWhite
            // 
            this.playerWhite.AutoSize = true;
            this.playerWhite.ForeColor = System.Drawing.Color.White;
            this.playerWhite.Location = new System.Drawing.Point(25, 25);
            this.playerWhite.Name = "playerWhite";
            this.playerWhite.Size = new System.Drawing.Size(35, 13);
            this.playerWhite.TabIndex = 0;
            this.playerWhite.Text = "label1";
            // 
            // playerBlack
            // 
            this.playerBlack.AutoSize = true;
            this.playerBlack.Location = new System.Drawing.Point(512, 25);
            this.playerBlack.Name = "playerBlack";
            this.playerBlack.Size = new System.Drawing.Size(35, 13);
            this.playerBlack.TabIndex = 1;
            this.playerBlack.Text = "label1";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.playerBlack);
            this.Controls.Add(this.playerWhite);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerWhite;
        private System.Windows.Forms.Label playerBlack;
    }
}
