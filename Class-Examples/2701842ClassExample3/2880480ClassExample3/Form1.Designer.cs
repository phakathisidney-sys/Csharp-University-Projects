namespace _2701842ClassExample3
{
    partial class ClassEg3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAmtOwing = new System.Windows.Forms.Label();
            this.lblVATAmt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotDiscAmt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCard = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.chkVIPcard = new System.Windows.Forms.CheckBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SO YUM!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table number";
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(104, 51);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(100, 20);
            this.txtTableNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item code";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(104, 104);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 20);
            this.txtItemCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(104, 153);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount owing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "VAT amount";
            // 
            // lblAmtOwing
            // 
            this.lblAmtOwing.AutoSize = true;
            this.lblAmtOwing.Location = new System.Drawing.Point(169, 271);
            this.lblAmtOwing.Name = "lblAmtOwing";
            this.lblAmtOwing.Size = new System.Drawing.Size(31, 15);
            this.lblAmtOwing.TabIndex = 11;
            this.lblAmtOwing.Text = "0.00";
            // 
            // lblVATAmt
            // 
            this.lblVATAmt.AutoSize = true;
            this.lblVATAmt.Location = new System.Drawing.Point(169, 309);
            this.lblVATAmt.Name = "lblVATAmt";
            this.lblVATAmt.Size = new System.Drawing.Size(31, 15);
            this.lblVATAmt.TabIndex = 12;
            this.lblVATAmt.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total discount amount";
            // 
            // lblTotDiscAmt
            // 
            this.lblTotDiscAmt.AutoSize = true;
            this.lblTotDiscAmt.Location = new System.Drawing.Point(525, 292);
            this.lblTotDiscAmt.Name = "lblTotDiscAmt";
            this.lblTotDiscAmt.Size = new System.Drawing.Size(31, 15);
            this.lblTotDiscAmt.TabIndex = 14;
            this.lblTotDiscAmt.Text = "0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCard);
            this.groupBox1.Controls.Add(this.radCash);
            this.groupBox1.Location = new System.Drawing.Point(392, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment method";
            // 
            // radCard
            // 
            this.radCard.AutoSize = true;
            this.radCard.Location = new System.Drawing.Point(43, 67);
            this.radCard.Name = "radCard";
            this.radCard.Size = new System.Drawing.Size(54, 19);
            this.radCard.TabIndex = 1;
            this.radCard.TabStop = true;
            this.radCard.Text = "Card";
            this.radCard.UseVisualStyleBackColor = true;
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(43, 22);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(56, 19);
            this.radCash.TabIndex = 0;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.toolTip1.SetToolTip(this.radCash, "2% discount given");
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // chkVIPcard
            // 
            this.chkVIPcard.AutoSize = true;
            this.chkVIPcard.Location = new System.Drawing.Point(409, 202);
            this.chkVIPcard.Name = "chkVIPcard";
            this.chkVIPcard.Size = new System.Drawing.Size(81, 19);
            this.chkVIPcard.TabIndex = 8;
            this.chkVIPcard.Text = "VIP card?";
            this.toolTip1.SetToolTip(this.chkVIPcard, "5% discount given");
            this.chkVIPcard.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(52, 370);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(97, 37);
            this.btnProcess.TabIndex = 15;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(252, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 37);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(435, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 37);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ClassEg3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.chkVIPcard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotDiscAmt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblVATAmt);
            this.Controls.Add(this.lblAmtOwing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClassEg3";
            this.Text = "Class Example 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAmtOwing;
        private System.Windows.Forms.Label lblVATAmt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotDiscAmt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCard;
        private System.Windows.Forms.CheckBox chkVIPcard;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

