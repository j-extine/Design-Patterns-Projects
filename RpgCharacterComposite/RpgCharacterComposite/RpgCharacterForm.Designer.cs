namespace RpgCharacterComposite {
    partial class RpgCharacterForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.characterCb = new System.Windows.Forms.ComboBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.descTb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // characterCb
            // 
            this.characterCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.characterCb.BackColor = System.Drawing.Color.Linen;
            this.characterCb.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterCb.FormattingEnabled = true;
            this.characterCb.Items.AddRange(new object[] {
            "Sir Galahad the Valiant",
            "Rivel the Knave",
            "Vilnar the Wizened"});
            this.characterCb.Location = new System.Drawing.Point(124, 145);
            this.characterCb.Name = "characterCb";
            this.characterCb.Size = new System.Drawing.Size(463, 58);
            this.characterCb.TabIndex = 0;
            this.characterCb.SelectedIndexChanged += new System.EventHandler(this.characterCb_SelectedIndexChanged);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(52, 31);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(612, 79);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "RPG Hero Selection";
            // 
            // descLbl
            // 
            this.descLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descLbl.AutoSize = true;
            this.descLbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.Location = new System.Drawing.Point(201, 230);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(320, 40);
            this.descLbl.TabIndex = 9;
            this.descLbl.Text = "Character Description";
            // 
            // descTb
            // 
            this.descTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descTb.BackColor = System.Drawing.Color.Linen;
            this.descTb.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTb.Location = new System.Drawing.Point(66, 301);
            this.descTb.Name = "descTb";
            this.descTb.Size = new System.Drawing.Size(598, 411);
            this.descTb.TabIndex = 10;
            this.descTb.Text = "";
            // 
            // RpgCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(713, 814);
            this.Controls.Add(this.descTb);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.characterCb);
            this.Name = "RpgCharacterForm";
            this.Text = "Choose Your Hero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox characterCb;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.RichTextBox descTb;
    }
}

