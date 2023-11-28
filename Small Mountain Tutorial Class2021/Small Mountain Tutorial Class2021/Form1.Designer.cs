namespace Small_Mountain_Tutorial_Class2021
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
            this.ConfigUserButton = new System.Windows.Forms.Button();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.RepayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User1Input = new System.Windows.Forms.TextBox();
            this.User2Input = new System.Windows.Forms.TextBox();
            this.User1Name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.User1NameText = new System.Windows.Forms.Label();
            this.User1MoneyText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.User2NameText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.User2MoneyText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfigUserButton
            // 
            this.ConfigUserButton.Location = new System.Drawing.Point(600, 38);
            this.ConfigUserButton.Name = "ConfigUserButton";
            this.ConfigUserButton.Size = new System.Drawing.Size(118, 95);
            this.ConfigUserButton.TabIndex = 0;
            this.ConfigUserButton.Text = "確認用戶";
            this.ConfigUserButton.UseVisualStyleBackColor = true;
            this.ConfigUserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrowButton
            // 
            this.BorrowButton.Enabled = false;
            this.BorrowButton.Location = new System.Drawing.Point(310, 301);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(193, 43);
            this.BorrowButton.TabIndex = 1;
            this.BorrowButton.Text = "向使用者2借錢";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // RepayButton
            // 
            this.RepayButton.Enabled = false;
            this.RepayButton.Location = new System.Drawing.Point(310, 364);
            this.RepayButton.Name = "RepayButton";
            this.RepayButton.Size = new System.Drawing.Size(196, 43);
            this.RepayButton.TabIndex = 2;
            this.RepayButton.Text = "向使用者2還錢";
            this.RepayButton.UseVisualStyleBackColor = true;
            this.RepayButton.Click += new System.EventHandler(this.RepayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "使用者1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "使用者2";
            // 
            // User1Input
            // 
            this.User1Input.Location = new System.Drawing.Point(286, 38);
            this.User1Input.Name = "User1Input";
            this.User1Input.Size = new System.Drawing.Size(148, 23);
            this.User1Input.TabIndex = 5;
            // 
            // User2Input
            // 
            this.User2Input.Location = new System.Drawing.Point(286, 98);
            this.User2Input.Name = "User2Input";
            this.User2Input.Size = new System.Drawing.Size(148, 23);
            this.User2Input.TabIndex = 6;
            // 
            // User1Name
            // 
            this.User1Name.AutoSize = true;
            this.User1Name.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User1Name.Location = new System.Drawing.Point(36, 154);
            this.User1Name.Name = "User1Name";
            this.User1Name.Size = new System.Drawing.Size(157, 30);
            this.User1Name.TabIndex = 3;
            this.User1Name.Text = "使用者名稱：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "使用者存款：";
            // 
            // User1NameText
            // 
            this.User1NameText.AutoSize = true;
            this.User1NameText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User1NameText.Location = new System.Drawing.Point(187, 154);
            this.User1NameText.Name = "User1NameText";
            this.User1NameText.Size = new System.Drawing.Size(85, 30);
            this.User1NameText.TabIndex = 3;
            this.User1NameText.Text = "一名字";
            // 
            // User1MoneyText
            // 
            this.User1MoneyText.AutoSize = true;
            this.User1MoneyText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User1MoneyText.Location = new System.Drawing.Point(187, 211);
            this.User1MoneyText.Name = "User1MoneyText";
            this.User1MoneyText.Size = new System.Drawing.Size(27, 30);
            this.User1MoneyText.TabIndex = 3;
            this.User1MoneyText.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(395, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "使用者名稱：";
            // 
            // User2NameText
            // 
            this.User2NameText.AutoSize = true;
            this.User2NameText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User2NameText.Location = new System.Drawing.Point(546, 154);
            this.User2NameText.Name = "User2NameText";
            this.User2NameText.Size = new System.Drawing.Size(85, 30);
            this.User2NameText.TabIndex = 3;
            this.User2NameText.Text = "二名字";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(395, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 30);
            this.label9.TabIndex = 3;
            this.label9.Text = "使用者存款：";
            // 
            // User2MoneyText
            // 
            this.User2MoneyText.AutoSize = true;
            this.User2MoneyText.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User2MoneyText.Location = new System.Drawing.Point(546, 211);
            this.User2MoneyText.Name = "User2MoneyText";
            this.User2MoneyText.Size = new System.Drawing.Size(27, 30);
            this.User2MoneyText.TabIndex = 3;
            this.User2MoneyText.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.User2MoneyText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.User2NameText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.User1MoneyText);
            this.Controls.Add(this.User1NameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.User1Name);
            this.Controls.Add(this.User2Input);
            this.Controls.Add(this.User1Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepayButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.ConfigUserButton);
            this.Name = "Form1";
            this.Text = "第20課-TextBox 與 借還錢模擬小程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfigUserButton;
        private System.Windows.Forms.Button BorrowButton;
        private System.Windows.Forms.Button RepayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User1Input;
        private System.Windows.Forms.TextBox User2Input;
        private System.Windows.Forms.Label User1Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label User1NameText;
        private System.Windows.Forms.Label User1MoneyText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label User2NameText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label User2MoneyText;
    }
}

