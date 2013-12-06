namespace ConnectionStringTester
{
    partial class Main
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
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lConnectionString = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionString.Location = new System.Drawing.Point(13, 29);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(883, 20);
            this.txtConnectionString.TabIndex = 0;
            // 
            // lConnectionString
            // 
            this.lConnectionString.AutoSize = true;
            this.lConnectionString.Location = new System.Drawing.Point(13, 13);
            this.lConnectionString.Name = "lConnectionString";
            this.lConnectionString.Size = new System.Drawing.Size(94, 13);
            this.lConnectionString.TabIndex = 3;
            this.lConnectionString.Text = "Connection String:";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 86);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(884, 154);
            this.txtResult.TabIndex = 2;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(12, 70);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(40, 13);
            this.lResult.TabIndex = 3;
            this.lResult.Text = "Result:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 255);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 469);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lConnectionString);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtConnectionString);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lConnectionString;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Button btnTest;
    }
}

