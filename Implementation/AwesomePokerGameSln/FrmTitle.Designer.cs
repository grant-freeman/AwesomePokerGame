namespace AwesomePokerGameSln {
  partial class FrmTitle {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnViewRuleBook = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBackground = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(84, -56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = "Awesome";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(57, 469);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(211, 87);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnViewRuleBook
            // 
            this.btnViewRuleBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnViewRuleBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRuleBook.Location = new System.Drawing.Point(374, 469);
            this.btnViewRuleBook.Name = "btnViewRuleBook";
            this.btnViewRuleBook.Size = new System.Drawing.Size(238, 87);
            this.btnViewRuleBook.TabIndex = 2;
            this.btnViewRuleBook.Text = "View Rule Book";
            this.btnViewRuleBook.UseVisualStyleBackColor = false;
            this.btnViewRuleBook.Click += new System.EventHandler(this.btnViewRuleBook_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(713, 469);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(211, 87);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(31, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 153);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game";
            // 
            // searchBackground
            // 
            this.searchBackground.Image = global::AwesomePokerGameSln.Properties.Resources.search_background;
            this.searchBackground.Location = new System.Drawing.Point(266, 100);
            this.searchBackground.Name = "searchBackground";
            this.searchBackground.Size = new System.Drawing.Size(480, 332);
            this.searchBackground.TabIndex = 5;
            this.searchBackground.TabStop = false;
            this.searchBackground.Visible = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Gold;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(275, 130);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(127, 37);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search:";
            this.searchLabel.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(408, 130);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(145, 20);
            this.searchBox.TabIndex = 7;
            this.searchBox.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(560, 130);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 37);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBackground);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnViewRuleBook);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label1);
            this.Name = "FrmTitle";
            this.Text = "Awesome Poker Game";
            ((System.ComponentModel.ISupportInitialize)(this.searchBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnNewGame;
    private System.Windows.Forms.Button btnViewRuleBook;
    private System.Windows.Forms.Button btnQuit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox searchBackground;
    private System.Windows.Forms.Label searchLabel;
    private System.Windows.Forms.TextBox searchBox;
    private System.Windows.Forms.Button searchButton;
    }
}

