namespace FlashCardGame
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
            this.lblOutcome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTopScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChkAnswer = new System.Windows.Forms.Button();
            this.lblDigitOne = new System.Windows.Forms.Label();
            this.cboOps = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDigitTwo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(6, 30);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(0, 31);
            this.lblOutcome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(337, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correct";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(418, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Incorrect";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentScore);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTopScore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(531, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scores";
            // 
            // lblTopScore
            // 
            this.lblTopScore.AutoSize = true;
            this.lblTopScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopScore.Location = new System.Drawing.Point(101, 108);
            this.lblTopScore.Name = "lblTopScore";
            this.lblTopScore.Size = new System.Drawing.Size(0, 20);
            this.lblTopScore.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Top Score: ";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIncorrect.Location = new System.Drawing.Point(426, 60);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(0, 42);
            this.lblIncorrect.TabIndex = 5;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCorrect.Location = new System.Drawing.Point(345, 60);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(0, 42);
            this.lblCorrect.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(531, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 283);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 258);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnChkAnswer
            // 
            this.btnChkAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChkAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkAnswer.Location = new System.Drawing.Point(331, 236);
            this.btnChkAnswer.Name = "btnChkAnswer";
            this.btnChkAnswer.Size = new System.Drawing.Size(173, 41);
            this.btnChkAnswer.TabIndex = 7;
            this.btnChkAnswer.Text = "Check Answer";
            this.btnChkAnswer.UseVisualStyleBackColor = true;
            this.btnChkAnswer.Click += new System.EventHandler(this.BtnChkAnswer_Click);
            // 
            // lblDigitOne
            // 
            this.lblDigitOne.AutoSize = true;
            this.lblDigitOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblDigitOne.Location = new System.Drawing.Point(55, 114);
            this.lblDigitOne.Name = "lblDigitOne";
            this.lblDigitOne.Size = new System.Drawing.Size(41, 44);
            this.lblDigitOne.TabIndex = 8;
            this.lblDigitOne.Text = "6";
            // 
            // cboOps
            // 
            this.cboOps.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboOps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.cboOps.Location = new System.Drawing.Point(146, 108);
            this.cboOps.Name = "cboOps";
            this.cboOps.Size = new System.Drawing.Size(62, 50);
            this.cboOps.TabIndex = 9;
            this.cboOps.SelectedIndexChanged += new System.EventHandler(this.CboOps_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtAnswer);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblDigitTwo);
            this.groupBox3.Controls.Add(this.btnChkAnswer);
            this.groupBox3.Controls.Add(this.cboOps);
            this.groupBox3.Controls.Add(this.lblDigitOne);
            this.groupBox3.Location = new System.Drawing.Point(15, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 283);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flash Card Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Timer ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "60";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.txtAnswer.Location = new System.Drawing.Point(377, 115);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 49);
            this.txtAnswer.TabIndex = 12;
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnswer_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label8.Location = new System.Drawing.Point(313, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 42);
            this.label8.TabIndex = 11;
            this.label8.Text = "=";
            // 
            // lblDigitTwo
            // 
            this.lblDigitTwo.AutoSize = true;
            this.lblDigitTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lblDigitTwo.Location = new System.Drawing.Point(251, 114);
            this.lblDigitTwo.Name = "lblDigitTwo";
            this.lblDigitTwo.Size = new System.Drawing.Size(39, 42);
            this.lblDigitTwo.TabIndex = 10;
            this.lblDigitTwo.Text = "7";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblOutcome);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblIncorrect);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblCorrect);
            this.groupBox4.Location = new System.Drawing.Point(15, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 149);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test Outcome";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(67, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Current Score";
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCurrentScore.Location = new System.Drawing.Point(112, 46);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(37, 39);
            this.lblCurrentScore.TabIndex = 9;
            this.lblCurrentScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Flash Card Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChkAnswer;
        private System.Windows.Forms.Label lblDigitOne;
        private System.Windows.Forms.ComboBox cboOps;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDigitTwo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTopScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label label6;
    }
}

