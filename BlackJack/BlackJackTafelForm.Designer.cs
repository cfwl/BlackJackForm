namespace BlackJack
{
    partial class BlackJackTafelForm
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
            this.pbDealer = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnExtraCard = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.nudBet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBankRoll = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDealer
            // 
            this.pbDealer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDealer.Location = new System.Drawing.Point(128, 36);
            this.pbDealer.Name = "pbDealer";
            this.pbDealer.Size = new System.Drawing.Size(174, 136);
            this.pbDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer.TabIndex = 0;
            this.pbDealer.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayer.Location = new System.Drawing.Point(128, 221);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(174, 136);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 1;
            this.pbPlayer.TabStop = false;
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(12, 221);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(92, 35);
            this.btnPass.TabIndex = 2;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Visible = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnExtraCard
            // 
            this.btnExtraCard.Location = new System.Drawing.Point(12, 262);
            this.btnExtraCard.Name = "btnExtraCard";
            this.btnExtraCard.Size = new System.Drawing.Size(92, 31);
            this.btnExtraCard.TabIndex = 3;
            this.btnExtraCard.Text = "Extra Card";
            this.btnExtraCard.UseVisualStyleBackColor = true;
            this.btnExtraCard.Visible = false;
            this.btnExtraCard.Click += new System.EventHandler(this.btnExtraCard_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(330, 288);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(100, 50);
            this.btnDouble.TabIndex = 4;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Visible = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // nudBet
            // 
            this.nudBet.Location = new System.Drawing.Point(330, 221);
            this.nudBet.Name = "nudBet";
            this.nudBet.Size = new System.Drawing.Size(100, 22);
            this.nudBet.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bet";
            // 
            // tbBankRoll
            // 
            this.tbBankRoll.Location = new System.Drawing.Point(12, 335);
            this.tbBankRoll.Name = "tbBankRoll";
            this.tbBankRoll.ReadOnly = true;
            this.tbBankRoll.Size = new System.Drawing.Size(92, 22);
            this.tbBankRoll.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "BankRoll";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dealer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Player";
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(330, 249);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(100, 23);
            this.btnDeal.TabIndex = 11;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(333, 36);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 23);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // BlackJackTafelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 375);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBankRoll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudBet);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnExtraCard);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbDealer);
            this.Name = "BlackJackTafelForm";
            this.Text = "Black Jack";
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDealer;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnExtraCard;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.NumericUpDown nudBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBankRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnHelp;
    }
}

