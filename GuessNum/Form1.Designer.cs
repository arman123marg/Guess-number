
namespace GuessNum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.txtPlayerVariant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbComputer = new System.Windows.Forms.GroupBox();
            this.txtCompGuessNum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbGreate = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.gbPlayer.SuspendLayout();
            this.gbComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.lstHistory);
            this.gbPlayer.Controls.Add(this.txtPlayerVariant);
            this.gbPlayer.Controls.Add(this.button1);
            this.gbPlayer.Location = new System.Drawing.Point(10, 10);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(241, 409);
            this.gbPlayer.TabIndex = 1;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "Player";
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 20;
            this.lstHistory.Location = new System.Drawing.Point(25, 164);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(150, 224);
            this.lstHistory.TabIndex = 2;
            // 
            // txtPlayerVariant
            // 
            this.txtPlayerVariant.Location = new System.Drawing.Point(56, 49);
            this.txtPlayerVariant.Name = "txtPlayerVariant";
            this.txtPlayerVariant.Size = new System.Drawing.Size(125, 27);
            this.txtPlayerVariant.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbComputer
            // 
            this.gbComputer.Controls.Add(this.rbLess);
            this.gbComputer.Controls.Add(this.rbGreate);
            this.gbComputer.Controls.Add(this.rbEqual);
            this.gbComputer.Controls.Add(this.button2);
            this.gbComputer.Controls.Add(this.txtCompGuessNum);
            this.gbComputer.Location = new System.Drawing.Point(257, 23);
            this.gbComputer.Name = "gbComputer";
            this.gbComputer.Size = new System.Drawing.Size(250, 396);
            this.gbComputer.TabIndex = 2;
            this.gbComputer.TabStop = false;
            this.gbComputer.Text = "Computer";
            // 
            // txtCompGuessNum
            // 
            this.txtCompGuessNum.Location = new System.Drawing.Point(20, 36);
            this.txtCompGuessNum.Name = "txtCompGuessNum";
            this.txtCompGuessNum.Size = new System.Drawing.Size(125, 27);
            this.txtCompGuessNum.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hastatel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Location = new System.Drawing.Point(167, 32);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(40, 24);
            this.rbEqual.TabIndex = 2;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "=";
            this.rbEqual.UseVisualStyleBackColor = true;
            // 
            // rbGreate
            // 
            this.rbGreate.AutoSize = true;
            this.rbGreate.Location = new System.Drawing.Point(167, 63);
            this.rbGreate.Name = "rbGreate";
            this.rbGreate.Size = new System.Drawing.Size(40, 24);
            this.rbGreate.TabIndex = 3;
            this.rbGreate.TabStop = true;
            this.rbGreate.Text = ">";
            this.rbGreate.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.Location = new System.Drawing.Point(167, 86);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(40, 24);
            this.rbLess.TabIndex = 4;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "<";
            this.rbLess.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbComputer);
            this.Controls.Add(this.gbPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.gbComputer.ResumeLayout(false);
            this.gbComputer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.TextBox txtPlayerVariant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.GroupBox gbComputer;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbGreate;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCompGuessNum;
    }
}

