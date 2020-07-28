namespace gamefromscratchtry2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameField = new System.Windows.Forms.Panel();
            this.messagelbl = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblDesna = new System.Windows.Forms.Label();
            this.lblLeva = new System.Windows.Forms.Label();
            this.GameField.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.BackColor = System.Drawing.Color.Wheat;
            this.GameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameField.Controls.Add(this.messagelbl);
            this.GameField.Location = new System.Drawing.Point(12, 21);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(1218, 631);
            this.GameField.TabIndex = 0;
            this.GameField.Paint += new System.Windows.Forms.PaintEventHandler(this.GameField_Paint);
            // 
            // messagelbl
            // 
            this.messagelbl.AutoSize = true;
            this.messagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messagelbl.Location = new System.Drawing.Point(289, 148);
            this.messagelbl.Name = "messagelbl";
            this.messagelbl.Size = new System.Drawing.Size(78, 33);
            this.messagelbl.TabIndex = 2;
            this.messagelbl.Text = "0text";
            this.messagelbl.Visible = false;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblscore.Location = new System.Drawing.Point(101, 666);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(24, 25);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1075, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score:";
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblscore1.Location = new System.Drawing.Point(1155, 666);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(24, 25);
            this.lblscore1.TabIndex = 3;
            this.lblscore1.Text = "0";
            // 
            // lblDesna
            // 
            this.lblDesna.AutoSize = true;
            this.lblDesna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDesna.Location = new System.Drawing.Point(934, 666);
            this.lblDesna.Name = "lblDesna";
            this.lblDesna.Size = new System.Drawing.Size(30, 25);
            this.lblDesna.TabIndex = 5;
            this.lblDesna.Text = "t1";
            // 
            // lblLeva
            // 
            this.lblLeva.AutoSize = true;
            this.lblLeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeva.Location = new System.Drawing.Point(218, 666);
            this.lblLeva.Name = "lblLeva";
            this.lblLeva.Size = new System.Drawing.Size(18, 25);
            this.lblLeva.TabIndex = 6;
            this.lblLeva.Text = "t";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 700);
            this.Controls.Add(this.lblLeva);
            this.Controls.Add(this.lblDesna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblscore1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.GameField);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.GameField.ResumeLayout(false);
            this.GameField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label messagelbl;
        public System.Windows.Forms.Panel GameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label lblDesna;
        private System.Windows.Forms.Label lblLeva;
    }
}

