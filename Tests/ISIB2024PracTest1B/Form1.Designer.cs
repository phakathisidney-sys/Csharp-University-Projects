namespace ISIB2024PracTest1B
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTarot = new System.Windows.Forms.RadioButton();
            this.radHitman = new System.Windows.Forms.RadioButton();
            this.rad10Lives = new System.Windows.Forms.RadioButton();
            this.txtNoTickets = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblMovieCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad20h00 = new System.Windows.Forms.RadioButton();
            this.rad15h00 = new System.Windows.Forms.RadioButton();
            this.rad10h00 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTarot);
            this.groupBox1.Controls.Add(this.radHitman);
            this.groupBox1.Controls.Add(this.rad10Lives);
            this.groupBox1.Location = new System.Drawing.Point(467, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 207);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie choice";
            // 
            // radTarot
            // 
            this.radTarot.AutoSize = true;
            this.radTarot.Location = new System.Drawing.Point(35, 142);
            this.radTarot.Name = "radTarot";
            this.radTarot.Size = new System.Drawing.Size(60, 20);
            this.radTarot.TabIndex = 2;
            this.radTarot.TabStop = true;
            this.radTarot.Text = "Tarot";
            this.radTarot.UseVisualStyleBackColor = true;
            // 
            // radHitman
            // 
            this.radHitman.AutoSize = true;
            this.radHitman.Location = new System.Drawing.Point(35, 93);
            this.radHitman.Name = "radHitman";
            this.radHitman.Size = new System.Drawing.Size(73, 20);
            this.radHitman.TabIndex = 1;
            this.radHitman.TabStop = true;
            this.radHitman.Text = "Hit man";
            this.radHitman.UseVisualStyleBackColor = true;
            // 
            // rad10Lives
            // 
            this.rad10Lives.AutoSize = true;
            this.rad10Lives.Location = new System.Drawing.Point(35, 49);
            this.rad10Lives.Name = "rad10Lives";
            this.rad10Lives.Size = new System.Drawing.Size(77, 20);
            this.rad10Lives.TabIndex = 0;
            this.rad10Lives.TabStop = true;
            this.rad10Lives.Text = "10 Lives";
            this.rad10Lives.UseVisualStyleBackColor = true;
            // 
            // txtNoTickets
            // 
            this.txtNoTickets.Location = new System.Drawing.Point(279, 196);
            this.txtNoTickets.Name = "txtNoTickets";
            this.txtNoTickets.Size = new System.Drawing.Size(100, 22);
            this.txtNoTickets.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number of tickets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "MOVIE TIME!";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(695, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 48);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(399, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 48);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(116, 446);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(139, 48);
            this.btnProcess.TabIndex = 17;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblMovieCost
            // 
            this.lblMovieCost.AutoSize = true;
            this.lblMovieCost.Location = new System.Drawing.Point(287, 344);
            this.lblMovieCost.Name = "lblMovieCost";
            this.lblMovieCost.Size = new System.Drawing.Size(31, 16);
            this.lblMovieCost.TabIndex = 16;
            this.lblMovieCost.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Movie cost";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad20h00);
            this.groupBox2.Controls.Add(this.rad15h00);
            this.groupBox2.Controls.Add(this.rad10h00);
            this.groupBox2.Location = new System.Drawing.Point(729, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 210);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time";
            // 
            // rad20h00
            // 
            this.rad20h00.AutoSize = true;
            this.rad20h00.Location = new System.Drawing.Point(25, 146);
            this.rad20h00.Name = "rad20h00";
            this.rad20h00.Size = new System.Drawing.Size(63, 20);
            this.rad20h00.TabIndex = 2;
            this.rad20h00.TabStop = true;
            this.rad20h00.Text = "20h00";
            this.rad20h00.UseVisualStyleBackColor = true;
            // 
            // rad15h00
            // 
            this.rad15h00.AutoSize = true;
            this.rad15h00.Location = new System.Drawing.Point(25, 97);
            this.rad15h00.Name = "rad15h00";
            this.rad15h00.Size = new System.Drawing.Size(63, 20);
            this.rad15h00.TabIndex = 1;
            this.rad15h00.TabStop = true;
            this.rad15h00.Text = "15h00";
            this.rad15h00.UseVisualStyleBackColor = true;
            // 
            // rad10h00
            // 
            this.rad10h00.AutoSize = true;
            this.rad10h00.Location = new System.Drawing.Point(25, 53);
            this.rad10h00.Name = "rad10h00";
            this.rad10h00.Size = new System.Drawing.Size(63, 20);
            this.rad10h00.TabIndex = 0;
            this.rad10h00.TabStop = true;
            this.rad10h00.Text = "10h00";
            this.rad10h00.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNoTickets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblMovieCost);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "ISIB 2024 Practical test 1B";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTarot;
        private System.Windows.Forms.RadioButton radHitman;
        private System.Windows.Forms.RadioButton rad10Lives;
        private System.Windows.Forms.TextBox txtNoTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblMovieCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad20h00;
        private System.Windows.Forms.RadioButton rad15h00;
        private System.Windows.Forms.RadioButton rad10h00;
    }
}

