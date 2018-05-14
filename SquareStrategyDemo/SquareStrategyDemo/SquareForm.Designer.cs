namespace SquareStrategyDemo
{
    partial class SquareForm
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
            this.squareBtn = new System.Windows.Forms.Button();
            this.stratCb = new System.Windows.Forms.ComboBox();
            this.numberLbl = new System.Windows.Forms.Label();
            this.inputTb = new System.Windows.Forms.TextBox();
            this.stratLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // squareBtn
            // 
            this.squareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareBtn.Location = new System.Drawing.Point(212, 229);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(86, 71);
            this.squareBtn.TabIndex = 0;
            this.squareBtn.Text = "Square it!";
            this.squareBtn.UseVisualStyleBackColor = true;
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // stratCb
            // 
            this.stratCb.AutoCompleteCustomSource.AddRange(new string[] {
            "Power",
            "Multiply"});
            this.stratCb.FormattingEnabled = true;
            this.stratCb.Items.AddRange(new object[] {
            "Power",
            "Multiply"});
            this.stratCb.Location = new System.Drawing.Point(370, 178);
            this.stratCb.Name = "stratCb";
            this.stratCb.Size = new System.Drawing.Size(121, 24);
            this.stratCb.TabIndex = 1;
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(22, 113);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(183, 29);
            this.numberLbl.TabIndex = 2;
            this.numberLbl.Text = "Enter a number:";
            // 
            // inputTb
            // 
            this.inputTb.Location = new System.Drawing.Point(370, 120);
            this.inputTb.Name = "inputTb";
            this.inputTb.Size = new System.Drawing.Size(121, 22);
            this.inputTb.TabIndex = 3;
            // 
            // stratLbl
            // 
            this.stratLbl.AutoSize = true;
            this.stratLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stratLbl.Location = new System.Drawing.Point(22, 171);
            this.stratLbl.Name = "stratLbl";
            this.stratLbl.Size = new System.Drawing.Size(334, 29);
            this.stratLbl.TabIndex = 4;
            this.stratLbl.Text = "Choose a method of squaring:";
            // 
            // resultLbl
            // 
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(27, 334);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(464, 29);
            this.resultLbl.TabIndex = 5;
            this.resultLbl.Text = "______________";
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SquareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 481);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.stratLbl);
            this.Controls.Add(this.inputTb);
            this.Controls.Add(this.numberLbl);
            this.Controls.Add(this.stratCb);
            this.Controls.Add(this.squareBtn);
            this.Name = "SquareForm";
            this.Text = "Square Strategy Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.ComboBox stratCb;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.TextBox inputTb;
        private System.Windows.Forms.Label stratLbl;
        private System.Windows.Forms.Label resultLbl;
    }
}

