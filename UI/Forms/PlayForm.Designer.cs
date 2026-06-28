namespace TicTacToeGame.UI.Forms
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.lable1 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.White;
            this.lable1.Location = new System.Drawing.Point(223, 271);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(140, 62);
            this.lable1.TabIndex = 1;
            this.lable1.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Tomato;
            this.lblTurn.Location = new System.Drawing.Point(190, 349);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(377, 62);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Current Player";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Tomato;
            this.lblWinner.Location = new System.Drawing.Point(500, 602);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(293, 62);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "Game State";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRestartGame.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(539, 63);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(215, 51);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToeGame.Properties.Resources.TicTacToeGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 780);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lable1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayForm";
            this.Text = "Play";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestartGame;
    }
}