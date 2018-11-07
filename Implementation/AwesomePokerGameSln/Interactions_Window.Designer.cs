namespace AwesomePokerGameSln
{
    partial class Interactions_Window
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Fold = new System.Windows.Forms.Button();
            this.button_Call = new System.Windows.Forms.Button();
            this.button_All_In = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fiddle With Chips";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 93);
            this.button2.TabIndex = 1;
            this.button2.Text = "Let\'s Emote";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Fold
            // 
            this.button_Fold.Location = new System.Drawing.Point(125, 290);
            this.button_Fold.Name = "button_Fold";
            this.button_Fold.Size = new System.Drawing.Size(147, 93);
            this.button_Fold.TabIndex = 2;
            this.button_Fold.Text = "Fold";
            this.button_Fold.UseVisualStyleBackColor = true;
            this.button_Fold.Click += new System.EventHandler(this.button_Fold_Click);
            // 
            // button_Call
            // 
            this.button_Call.Location = new System.Drawing.Point(340, 290);
            this.button_Call.Name = "button_Call";
            this.button_Call.Size = new System.Drawing.Size(147, 93);
            this.button_Call.TabIndex = 3;
            this.button_Call.Text = "Call";
            this.button_Call.UseVisualStyleBackColor = true;
            this.button_Call.Click += new System.EventHandler(this.button_Call_Click);
            // 
            // button_All_In
            // 
            this.button_All_In.Location = new System.Drawing.Point(559, 290);
            this.button_All_In.Name = "button_All_In";
            this.button_All_In.Size = new System.Drawing.Size(147, 93);
            this.button_All_In.TabIndex = 4;
            this.button_All_In.Text = "All In";
            this.button_All_In.UseVisualStyleBackColor = true;
            this.button_All_In.Click += new System.EventHandler(this.button_All_In_Click);
            // 
            // Interactions_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_All_In);
            this.Controls.Add(this.button_Call);
            this.Controls.Add(this.button_Fold);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Interactions_Window";
            this.Text = "Emote_Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Fold;
        private System.Windows.Forms.Button button_Call;
        private System.Windows.Forms.Button button_All_In;
    }
}