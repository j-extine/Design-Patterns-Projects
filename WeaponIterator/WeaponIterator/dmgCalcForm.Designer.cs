namespace WeaponIterator {
    partial class dmgCalcForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dmgCalcForm));
            this.skillComboBox = new System.Windows.Forms.ComboBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.attributeLbl = new System.Windows.Forms.Label();
            this.attributeBox = new System.Windows.Forms.TextBox();
            this.skillBox = new System.Windows.Forms.TextBox();
            this.skillLbl = new System.Windows.Forms.Label();
            this.atLbl = new System.Windows.Forms.Label();
            this.weaponListBox = new System.Windows.Forms.ListBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skillComboBox
            // 
            this.skillComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skillComboBox.BackColor = System.Drawing.Color.Linen;
            this.skillComboBox.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillComboBox.ForeColor = System.Drawing.Color.DarkRed;
            this.skillComboBox.FormattingEnabled = true;
            this.skillComboBox.Items.AddRange(new object[] {
            "Blade",
            "Blunt",
            "Marksman"});
            this.skillComboBox.Location = new System.Drawing.Point(60, 143);
            this.skillComboBox.Name = "skillComboBox";
            this.skillComboBox.Size = new System.Drawing.Size(211, 35);
            this.skillComboBox.TabIndex = 0;
            this.skillComboBox.Text = "Select a Skill";
            this.skillComboBox.SelectedIndexChanged += new System.EventHandler(this.skillComboBox_SelectedIndexChanged);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Linen;
            this.titleLbl.Font = new System.Drawing.Font("Georgia", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.titleLbl.Location = new System.Drawing.Point(115, 24);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(784, 56);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Oblivion Damage Calculator 2";
            // 
            // attributeLbl
            // 
            this.attributeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attributeLbl.AutoSize = true;
            this.attributeLbl.BackColor = System.Drawing.Color.Linen;
            this.attributeLbl.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeLbl.Location = new System.Drawing.Point(60, 225);
            this.attributeLbl.Name = "attributeLbl";
            this.attributeLbl.Size = new System.Drawing.Size(137, 29);
            this.attributeLbl.TabIndex = 2;
            this.attributeLbl.Text = "Attribute:";
            // 
            // attributeBox
            // 
            this.attributeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attributeBox.BackColor = System.Drawing.Color.Linen;
            this.attributeBox.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeBox.ForeColor = System.Drawing.Color.DarkRed;
            this.attributeBox.Location = new System.Drawing.Point(218, 222);
            this.attributeBox.Name = "attributeBox";
            this.attributeBox.Size = new System.Drawing.Size(53, 34);
            this.attributeBox.TabIndex = 3;
            // 
            // skillBox
            // 
            this.skillBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skillBox.BackColor = System.Drawing.Color.Linen;
            this.skillBox.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillBox.ForeColor = System.Drawing.Color.DarkRed;
            this.skillBox.Location = new System.Drawing.Point(218, 288);
            this.skillBox.Name = "skillBox";
            this.skillBox.Size = new System.Drawing.Size(53, 34);
            this.skillBox.TabIndex = 4;
            // 
            // skillLbl
            // 
            this.skillLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skillLbl.AutoSize = true;
            this.skillLbl.BackColor = System.Drawing.Color.Linen;
            this.skillLbl.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLbl.Location = new System.Drawing.Point(60, 291);
            this.skillLbl.Name = "skillLbl";
            this.skillLbl.Size = new System.Drawing.Size(152, 29);
            this.skillLbl.TabIndex = 5;
            this.skillLbl.Text = "Skill Level:";
            // 
            // atLbl
            // 
            this.atLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.atLbl.AutoSize = true;
            this.atLbl.BackColor = System.Drawing.Color.Linen;
            this.atLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.atLbl.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atLbl.Location = new System.Drawing.Point(265, 222);
            this.atLbl.MinimumSize = new System.Drawing.Size(0, 34);
            this.atLbl.Name = "atLbl";
            this.atLbl.Size = new System.Drawing.Size(168, 34);
            this.atLbl.TabIndex = 6;
            this.atLbl.Text = "_________";
            this.atLbl.Visible = false;
            // 
            // weaponListBox
            // 
            this.weaponListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.weaponListBox.BackColor = System.Drawing.Color.Linen;
            this.weaponListBox.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponListBox.ForeColor = System.Drawing.Color.DarkRed;
            this.weaponListBox.FormattingEnabled = true;
            this.weaponListBox.ItemHeight = 27;
            this.weaponListBox.Location = new System.Drawing.Point(469, 143);
            this.weaponListBox.Name = "weaponListBox";
            this.weaponListBox.Size = new System.Drawing.Size(439, 382);
            this.weaponListBox.TabIndex = 7;
            // 
            // goBtn
            // 
            this.goBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goBtn.BackColor = System.Drawing.Color.Transparent;
            this.goBtn.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.Location = new System.Drawing.Point(83, 375);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(129, 61);
            this.goBtn.TabIndex = 8;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // dmgCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 575);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.weaponListBox);
            this.Controls.Add(this.atLbl);
            this.Controls.Add(this.skillLbl);
            this.Controls.Add(this.skillBox);
            this.Controls.Add(this.attributeBox);
            this.Controls.Add(this.attributeLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.skillComboBox);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dmgCalcForm";
            this.Text = "Oblivion Damage Calculator 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox skillComboBox;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label attributeLbl;
        private System.Windows.Forms.TextBox attributeBox;
        private System.Windows.Forms.TextBox skillBox;
        private System.Windows.Forms.Label skillLbl;
        private System.Windows.Forms.Label atLbl;
        private System.Windows.Forms.ListBox weaponListBox;
        private System.Windows.Forms.Button goBtn;
    }
}

