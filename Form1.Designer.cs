namespace Threading
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultOne = new System.Windows.Forms.Label();
            this.lblResultTwo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listboxOne = new System.Windows.Forms.ListBox();
            this.lsbTwo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(11, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(56, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number 1:";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(62, 147);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(73, 19);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOne.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 2:";
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(73, 45);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(100, 20);
            this.txtNumberTwo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Result 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Result 1";
            // 
            // lblResultOne
            // 
            this.lblResultOne.AccessibleDescription = "lblResultOne";
            this.lblResultOne.AccessibleName = "lblResultOne";
            this.lblResultOne.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.lblResultOne.AutoSize = true;
            this.lblResultOne.Location = new System.Drawing.Point(70, 84);
            this.lblResultOne.Name = "lblResultOne";
            this.lblResultOne.Size = new System.Drawing.Size(12, 13);
            this.lblResultOne.TabIndex = 0;
            this.lblResultOne.Text = "x";
            // 
            // lblResultTwo
            // 
            this.lblResultTwo.AccessibleDescription = "lblResultTwo";
            this.lblResultTwo.AccessibleName = "lblResultTwo";
            this.lblResultTwo.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.lblResultTwo.AutoSize = true;
            this.lblResultTwo.Location = new System.Drawing.Point(70, 113);
            this.lblResultTwo.Name = "lblResultTwo";
            this.lblResultTwo.Size = new System.Drawing.Size(12, 13);
            this.lblResultTwo.TabIndex = 0;
            this.lblResultTwo.Text = "x";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumberOne);
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblResultOne);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumberTwo);
            this.groupBox1.Controls.Add(this.lblResultTwo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listboxOne);
            this.groupBox2.Location = new System.Drawing.Point(219, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 316);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsbTwo);
            this.groupBox3.Location = new System.Drawing.Point(425, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 316);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox2";
            // 
            // listboxOne
            // 
            this.listboxOne.FormattingEnabled = true;
            this.listboxOne.Location = new System.Drawing.Point(6, 19);
            this.listboxOne.Name = "listboxOne";
            this.listboxOne.Size = new System.Drawing.Size(188, 290);
            this.listboxOne.TabIndex = 0;
            // 
            // lsbTwo
            // 
            this.lsbTwo.FormattingEnabled = true;
            this.lsbTwo.Location = new System.Drawing.Point(6, 19);
            this.lsbTwo.Name = "lsbTwo";
            this.lsbTwo.Size = new System.Drawing.Size(188, 290);
            this.lsbTwo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 340);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultOne;
        private System.Windows.Forms.Label lblResultTwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listboxOne;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lsbTwo;
    }
}

