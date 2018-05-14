namespace GibsonGuitarsFactory {
    partial class GuitarFactoryForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuitarFactoryForm));
            this.guitarComboBox = new System.Windows.Forms.ComboBox();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.guitarDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guitarDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // guitarComboBox
            // 
            this.guitarComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guitarComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.guitarComboBox.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guitarComboBox.FormattingEnabled = true;
            this.guitarComboBox.Items.AddRange(new object[] {
            "Les Paul",
            "SG",
            "ES",
            "Archtop",
            "Explorer",
            "Firebird",
            "Flying V",
            "RD"});
            this.guitarComboBox.Location = new System.Drawing.Point(562, 346);
            this.guitarComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guitarComboBox.Name = "guitarComboBox";
            this.guitarComboBox.Size = new System.Drawing.Size(295, 44);
            this.guitarComboBox.TabIndex = 0;
            this.guitarComboBox.TabStop = false;
            this.guitarComboBox.Text = "Select a Guitar";
            this.guitarComboBox.SelectedIndexChanged += new System.EventHandler(this.guitarComboBox_SelectedIndexChanged);
            // 
            // logoPanel
            // 
            this.logoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Location = new System.Drawing.Point(1, 3);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(1356, 334);
            this.logoPanel.TabIndex = 1;
            // 
            // guitarDisplay
            // 
            this.guitarDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guitarDisplay.BackColor = System.Drawing.Color.White;
            this.guitarDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guitarDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guitarDisplay.Location = new System.Drawing.Point(73, 399);
            this.guitarDisplay.Name = "guitarDisplay";
            this.guitarDisplay.Size = new System.Drawing.Size(1213, 494);
            this.guitarDisplay.TabIndex = 3;
            this.guitarDisplay.TabStop = false;
            // 
            // GuitarFactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1358, 971);
            this.Controls.Add(this.guitarDisplay);
            this.Controls.Add(this.guitarComboBox);
            this.Controls.Add(this.logoPanel);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "GuitarFactoryForm";
            this.Text = "Gibson Guitars Factory";
            ((System.ComponentModel.ISupportInitialize)(this.guitarDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox guitarComboBox;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox guitarDisplay;
    }
}

