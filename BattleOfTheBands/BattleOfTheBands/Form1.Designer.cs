namespace BattleOfTheBands
{
    partial class BattleOfTheBandsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleOfTheBandsForm));
            this.pilotsBtn = new System.Windows.Forms.Button();
            this.metallicsBtn = new System.Windows.Forms.Button();
            this.beyonceBtn = new System.Windows.Forms.Button();
            this.BattleOfTheBandsLogo = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pilotsBtn
            // 
            this.pilotsBtn.Image = ((System.Drawing.Image)(resources.GetObject("pilotsBtn.Image")));
            this.pilotsBtn.Location = new System.Drawing.Point(31, 448);
            this.pilotsBtn.Name = "pilotsBtn";
            this.pilotsBtn.Size = new System.Drawing.Size(368, 237);
            this.pilotsBtn.TabIndex = 0;
            this.pilotsBtn.UseVisualStyleBackColor = false;
            this.pilotsBtn.Click += new System.EventHandler(this.pilotsBtn_Click);
            // 
            // metallicsBtn
            // 
            this.metallicsBtn.Image = ((System.Drawing.Image)(resources.GetObject("metallicsBtn.Image")));
            this.metallicsBtn.Location = new System.Drawing.Point(405, 448);
            this.metallicsBtn.Name = "metallicsBtn";
            this.metallicsBtn.Size = new System.Drawing.Size(368, 237);
            this.metallicsBtn.TabIndex = 1;
            this.metallicsBtn.UseVisualStyleBackColor = false;
            this.metallicsBtn.Click += new System.EventHandler(this.metallicsBtn_Click);
            // 
            // beyonceBtn
            // 
            this.beyonceBtn.AllowDrop = true;
            this.beyonceBtn.Image = ((System.Drawing.Image)(resources.GetObject("beyonceBtn.Image")));
            this.beyonceBtn.Location = new System.Drawing.Point(779, 448);
            this.beyonceBtn.Name = "beyonceBtn";
            this.beyonceBtn.Size = new System.Drawing.Size(368, 237);
            this.beyonceBtn.TabIndex = 2;
            this.beyonceBtn.UseVisualStyleBackColor = false;
            this.beyonceBtn.Click += new System.EventHandler(this.beyonceBtn_Click);
            // 
            // BattleOfTheBandsLogo
            // 
            this.BattleOfTheBandsLogo.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BattleOfTheBandsLogo.Image = ((System.Drawing.Image)(resources.GetObject("BattleOfTheBandsLogo.Image")));
            this.BattleOfTheBandsLogo.Location = new System.Drawing.Point(405, 34);
            this.BattleOfTheBandsLogo.Name = "BattleOfTheBandsLogo";
            this.BattleOfTheBandsLogo.Size = new System.Drawing.Size(368, 302);
            this.BattleOfTheBandsLogo.TabIndex = 3;
            this.BattleOfTheBandsLogo.Text = "Pick A Winner";
            this.BattleOfTheBandsLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // resultLbl
            // 
            this.resultLbl.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(226, 726);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(708, 127);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "And the Winner is....";
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BattleOfTheBandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 881);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.BattleOfTheBandsLogo);
            this.Controls.Add(this.beyonceBtn);
            this.Controls.Add(this.metallicsBtn);
            this.Controls.Add(this.pilotsBtn);
            this.Name = "BattleOfTheBandsForm";
            this.Text = "Battle of the Bands";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pilotsBtn;
        private System.Windows.Forms.Button metallicsBtn;
        private System.Windows.Forms.Button beyonceBtn;
        private System.Windows.Forms.Label BattleOfTheBandsLogo;
        private System.Windows.Forms.Label resultLbl;
    }
}

