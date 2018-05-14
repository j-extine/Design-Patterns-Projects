namespace LibraryFacadeDemo {
    partial class LibraryForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.titleLbl = new System.Windows.Forms.Label();
            this.bookPnl = new System.Windows.Forms.Panel();
            this.bookTitleBox = new System.Windows.Forms.TextBox();
            this.bookLbl = new System.Windows.Forms.Label();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.renewBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.borrowedBookLbl = new System.Windows.Forms.Label();
            this.bookPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Linen;
            this.titleLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titleLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLbl.Font = new System.Drawing.Font("Gabriola", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleLbl.Location = new System.Drawing.Point(240, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(496, 112);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Welcome to The Library";
            // 
            // bookPnl
            // 
            this.bookPnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bookPnl.BackColor = System.Drawing.Color.Linen;
            this.bookPnl.Controls.Add(this.bookTitleBox);
            this.bookPnl.Controls.Add(this.bookLbl);
            this.bookPnl.Location = new System.Drawing.Point(321, 174);
            this.bookPnl.Name = "bookPnl";
            this.bookPnl.Size = new System.Drawing.Size(325, 161);
            this.bookPnl.TabIndex = 1;
            // 
            // bookTitleBox
            // 
            this.bookTitleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookTitleBox.BackColor = System.Drawing.Color.Linen;
            this.bookTitleBox.Font = new System.Drawing.Font("Gabriola", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleBox.Location = new System.Drawing.Point(3, 48);
            this.bookTitleBox.Multiline = true;
            this.bookTitleBox.Name = "bookTitleBox";
            this.bookTitleBox.Size = new System.Drawing.Size(319, 110);
            this.bookTitleBox.TabIndex = 1;
            this.bookTitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookLbl
            // 
            this.bookLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookLbl.AutoSize = true;
            this.bookLbl.Font = new System.Drawing.Font("Gabriola", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLbl.Location = new System.Drawing.Point(78, 0);
            this.bookLbl.Name = "bookLbl";
            this.bookLbl.Size = new System.Drawing.Size(170, 45);
            this.bookLbl.TabIndex = 0;
            this.bookLbl.Text = "Enter a Book Title";
            // 
            // borrowBtn
            // 
            this.borrowBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borrowBtn.BackColor = System.Drawing.Color.Linen;
            this.borrowBtn.Font = new System.Drawing.Font("Gabriola", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.Location = new System.Drawing.Point(240, 419);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(114, 84);
            this.borrowBtn.TabIndex = 2;
            this.borrowBtn.Text = "Borrow";
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // renewBtn
            // 
            this.renewBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.renewBtn.BackColor = System.Drawing.Color.Linen;
            this.renewBtn.Font = new System.Drawing.Font("Gabriola", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewBtn.Location = new System.Drawing.Point(422, 419);
            this.renewBtn.Name = "renewBtn";
            this.renewBtn.Size = new System.Drawing.Size(114, 84);
            this.renewBtn.TabIndex = 3;
            this.renewBtn.Text = "Renew";
            this.renewBtn.UseVisualStyleBackColor = false;
            this.renewBtn.Click += new System.EventHandler(this.renewBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnBtn.BackColor = System.Drawing.Color.Linen;
            this.returnBtn.Font = new System.Drawing.Font("Gabriola", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(622, 419);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(114, 84);
            this.returnBtn.TabIndex = 4;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // borrowedBookLbl
            // 
            this.borrowedBookLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.borrowedBookLbl.BackColor = System.Drawing.Color.Linen;
            this.borrowedBookLbl.Font = new System.Drawing.Font("Gabriola", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedBookLbl.Location = new System.Drawing.Point(240, 589);
            this.borrowedBookLbl.Name = "borrowedBookLbl";
            this.borrowedBookLbl.Size = new System.Drawing.Size(496, 175);
            this.borrowedBookLbl.TabIndex = 5;
            this.borrowedBookLbl.Text = "                                   ";
            this.borrowedBookLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(965, 789);
            this.Controls.Add(this.borrowedBookLbl);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.renewBtn);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.bookPnl);
            this.Controls.Add(this.titleLbl);
            this.Name = "LibraryForm";
            this.Text = "The Library";
            this.bookPnl.ResumeLayout(false);
            this.bookPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel bookPnl;
        private System.Windows.Forms.TextBox bookTitleBox;
        private System.Windows.Forms.Label bookLbl;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Button renewBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label borrowedBookLbl;
    }
}

