namespace IssueTransactionExample
{
    partial class VideoIssueForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CIDTextBox = new System.Windows.Forms.TextBox();
            this.VideoCodeTextBox = new System.Windows.Forms.TextBox();
            this.DateIssueDTP = new System.Windows.Forms.DateTimePicker();
            this.DateDueDTP = new System.Windows.Forms.DateTimePicker();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CustomerLookupButton = new System.Windows.Forms.Button();
            this.MovieLookupButton = new System.Windows.Forms.Button();
            this.totalStockBox = new System.Windows.Forms.TextBox();
            this.NumberRentedBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Video Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Issue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Due";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remarks";
            // 
            // CIDTextBox
            // 
            this.CIDTextBox.Location = new System.Drawing.Point(220, 54);
            this.CIDTextBox.Name = "CIDTextBox";
            this.CIDTextBox.Size = new System.Drawing.Size(100, 34);
            this.CIDTextBox.TabIndex = 5;
            // 
            // VideoCodeTextBox
            // 
            this.VideoCodeTextBox.Location = new System.Drawing.Point(220, 127);
            this.VideoCodeTextBox.Name = "VideoCodeTextBox";
            this.VideoCodeTextBox.Size = new System.Drawing.Size(100, 34);
            this.VideoCodeTextBox.TabIndex = 6;
            // 
            // DateIssueDTP
            // 
            this.DateIssueDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateIssueDTP.Location = new System.Drawing.Point(220, 213);
            this.DateIssueDTP.Name = "DateIssueDTP";
            this.DateIssueDTP.Size = new System.Drawing.Size(200, 34);
            this.DateIssueDTP.TabIndex = 7;
            // 
            // DateDueDTP
            // 
            this.DateDueDTP.CustomFormat = "dd-MMM-yyyy";
            this.DateDueDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDueDTP.Location = new System.Drawing.Point(220, 259);
            this.DateDueDTP.Name = "DateDueDTP";
            this.DateDueDTP.Size = new System.Drawing.Size(200, 34);
            this.DateDueDTP.TabIndex = 8;
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Location = new System.Drawing.Point(220, 330);
            this.RemarksTextBox.Multiline = true;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(245, 71);
            this.RemarksTextBox.TabIndex = 9;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(220, 89);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.ReadOnly = true;
            this.CustomerNameTextBox.Size = new System.Drawing.Size(256, 34);
            this.CustomerNameTextBox.TabIndex = 10;
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(220, 162);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(256, 34);
            this.MovieTitleTextBox.TabIndex = 11;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(209, 434);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(111, 36);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CustomerLookupButton
            // 
            this.CustomerLookupButton.Location = new System.Drawing.Point(326, 48);
            this.CustomerLookupButton.Name = "CustomerLookupButton";
            this.CustomerLookupButton.Size = new System.Drawing.Size(39, 36);
            this.CustomerLookupButton.TabIndex = 13;
            this.CustomerLookupButton.Text = "...";
            this.CustomerLookupButton.UseVisualStyleBackColor = true;
            this.CustomerLookupButton.Click += new System.EventHandler(this.CustomerLookupButton_Click);
            // 
            // MovieLookupButton
            // 
            this.MovieLookupButton.Location = new System.Drawing.Point(326, 120);
            this.MovieLookupButton.Name = "MovieLookupButton";
            this.MovieLookupButton.Size = new System.Drawing.Size(39, 36);
            this.MovieLookupButton.TabIndex = 14;
            this.MovieLookupButton.Text = "...";
            this.MovieLookupButton.UseVisualStyleBackColor = true;
            this.MovieLookupButton.Click += new System.EventHandler(this.VideoLookupButtonClicked);
            // 
            // totalStockBox
            // 
            this.totalStockBox.Location = new System.Drawing.Point(68, 378);
            this.totalStockBox.Name = "totalStockBox";
            this.totalStockBox.Size = new System.Drawing.Size(100, 34);
            this.totalStockBox.TabIndex = 15;
            // 
            // NumberRentedBox
            // 
            this.NumberRentedBox.Location = new System.Drawing.Point(68, 418);
            this.NumberRentedBox.Name = "NumberRentedBox";
            this.NumberRentedBox.Size = new System.Drawing.Size(100, 34);
            this.NumberRentedBox.TabIndex = 16;
            // 
            // VideoIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 482);
            this.Controls.Add(this.NumberRentedBox);
            this.Controls.Add(this.totalStockBox);
            this.Controls.Add(this.MovieLookupButton);
            this.Controls.Add(this.CustomerLookupButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.RemarksTextBox);
            this.Controls.Add(this.DateDueDTP);
            this.Controls.Add(this.DateIssueDTP);
            this.Controls.Add(this.VideoCodeTextBox);
            this.Controls.Add(this.CIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "VideoIssueForm";
            this.Text = "VideoIssueForm";
            this.Load += new System.EventHandler(this.VideoIssueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CIDTextBox;
        private System.Windows.Forms.TextBox VideoCodeTextBox;
        private System.Windows.Forms.DateTimePicker DateIssueDTP;
        private System.Windows.Forms.DateTimePicker DateDueDTP;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CustomerLookupButton;
        private System.Windows.Forms.Button MovieLookupButton;
        public System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox totalStockBox;
        private System.Windows.Forms.TextBox NumberRentedBox;
    }
}