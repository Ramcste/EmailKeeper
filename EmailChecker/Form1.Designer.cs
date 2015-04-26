namespace EmailKeeper
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
            this.addEmailListBox = new System.Windows.Forms.ListBox();
            this.searchEmailListBox = new System.Windows.Forms.ListBox();
            this.addEmailButton = new System.Windows.Forms.Button();
            this.searchEmailButton = new System.Windows.Forms.Button();
            this.addEmailTextBox = new System.Windows.Forms.TextBox();
            this.searchEmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addEmailListBox
            // 
            this.addEmailListBox.FormattingEnabled = true;
            this.addEmailListBox.Location = new System.Drawing.Point(135, 137);
            this.addEmailListBox.Name = "addEmailListBox";
            this.addEmailListBox.Size = new System.Drawing.Size(211, 199);
            this.addEmailListBox.TabIndex = 0;
            // 
            // searchEmailListBox
            // 
            this.searchEmailListBox.FormattingEnabled = true;
            this.searchEmailListBox.Location = new System.Drawing.Point(466, 137);
            this.searchEmailListBox.Name = "searchEmailListBox";
            this.searchEmailListBox.Size = new System.Drawing.Size(189, 199);
            this.searchEmailListBox.TabIndex = 1;
            // 
            // addEmailButton
            // 
            this.addEmailButton.Location = new System.Drawing.Point(271, 79);
            this.addEmailButton.Name = "addEmailButton";
            this.addEmailButton.Size = new System.Drawing.Size(75, 23);
            this.addEmailButton.TabIndex = 2;
            this.addEmailButton.Text = "Add";
            this.addEmailButton.UseVisualStyleBackColor = true;
            this.addEmailButton.Click += new System.EventHandler(this.addEmailButton_Click);
            // 
            // searchEmailButton
            // 
            this.searchEmailButton.Location = new System.Drawing.Point(580, 79);
            this.searchEmailButton.Name = "searchEmailButton";
            this.searchEmailButton.Size = new System.Drawing.Size(75, 23);
            this.searchEmailButton.TabIndex = 3;
            this.searchEmailButton.Text = "Search";
            this.searchEmailButton.UseVisualStyleBackColor = true;
            this.searchEmailButton.Click += new System.EventHandler(this.searchEmailButton_Click);
            // 
            // addEmailTextBox
            // 
            this.addEmailTextBox.Location = new System.Drawing.Point(135, 31);
            this.addEmailTextBox.Name = "addEmailTextBox";
            this.addEmailTextBox.Size = new System.Drawing.Size(211, 20);
            this.addEmailTextBox.TabIndex = 4;
            // 
            // searchEmailTextBox
            // 
            this.searchEmailTextBox.Location = new System.Drawing.Point(466, 28);
            this.searchEmailTextBox.Name = "searchEmailTextBox";
            this.searchEmailTextBox.Size = new System.Drawing.Size(189, 20);
            this.searchEmailTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email to Add:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email to Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchEmailTextBox);
            this.Controls.Add(this.addEmailTextBox);
            this.Controls.Add(this.searchEmailButton);
            this.Controls.Add(this.addEmailButton);
            this.Controls.Add(this.searchEmailListBox);
            this.Controls.Add(this.addEmailListBox);
            this.Name = "Form1";
            this.Text = "Email keeper UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox addEmailListBox;
        private System.Windows.Forms.ListBox searchEmailListBox;
        private System.Windows.Forms.Button addEmailButton;
        private System.Windows.Forms.Button searchEmailButton;
        private System.Windows.Forms.TextBox addEmailTextBox;
        private System.Windows.Forms.TextBox searchEmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

