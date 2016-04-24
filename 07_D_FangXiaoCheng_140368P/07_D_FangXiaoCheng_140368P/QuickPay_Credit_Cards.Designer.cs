namespace _07_D_FangXiaoCheng_140368P
{
    partial class QuickPay_Credit_Cards
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cbTypeOfCard = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.tbContactNo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalutation = new System.Windows.Forms.Label();
            this.cbSalutation = new System.Windows.Forms.ComboBox();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(481, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 43);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear Display";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(376, 289);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(79, 43);
            this.btnDisplay.TabIndex = 32;
            this.btnDisplay.Text = "Display All";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(155, 289);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 43);
            this.btnRemove.TabIndex = 31;
            this.btnRemove.Text = "Remove Application";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(200, 152);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 20);
            this.tbSalary.TabIndex = 30;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(78, 155);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(46, 13);
            this.lblSalary.TabIndex = 29;
            this.lblSalary.Text = "Salary* :";
            // 
            // cbTypeOfCard
            // 
            this.cbTypeOfCard.FormattingEnabled = true;
            this.cbTypeOfCard.Items.AddRange(new object[] {
            "Corporate",
            "International",
            "Individual"});
            this.cbTypeOfCard.Location = new System.Drawing.Point(189, 47);
            this.cbTypeOfCard.Name = "cbTypeOfCard";
            this.cbTypeOfCard.Size = new System.Drawing.Size(121, 21);
            this.cbTypeOfCard.TabIndex = 28;
            this.cbTypeOfCard.Text = "  -- Please Select --";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(68, 50);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(110, 13);
            this.lblType.TabIndex = 27;
            this.lblType.Text = "Type Of Credit Card* :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(48, 289);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 43);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit Application";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(343, 47);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDisplay.Size = new System.Drawing.Size(267, 191);
            this.tbDisplay.TabIndex = 25;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(200, 218);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 24;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(78, 221);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 13);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Address* :";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(78, 193);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(90, 13);
            this.lblContactNo.TabIndex = 22;
            this.lblContactNo.Text = "Contact Number :";
            // 
            // tbContactNo
            // 
            this.tbContactNo.Location = new System.Drawing.Point(200, 186);
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.Size = new System.Drawing.Size(100, 20);
            this.tbContactNo.TabIndex = 21;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(200, 122);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(78, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name* :";
            // 
            // lblSalutation
            // 
            this.lblSalutation.AutoSize = true;
            this.lblSalutation.Location = new System.Drawing.Point(78, 85);
            this.lblSalutation.Name = "lblSalutation";
            this.lblSalutation.Size = new System.Drawing.Size(67, 13);
            this.lblSalutation.TabIndex = 18;
            this.lblSalutation.Text = "Salutation* : ";
            // 
            // cbSalutation
            // 
            this.cbSalutation.FormattingEnabled = true;
            this.cbSalutation.Items.AddRange(new object[] {
            "Mr. ",
            "Mrs. ",
            "Ms. ",
            "Dr. ",
            "Madam "});
            this.cbSalutation.Location = new System.Drawing.Point(189, 82);
            this.cbSalutation.Name = "cbSalutation";
            this.cbSalutation.Size = new System.Drawing.Size(121, 21);
            this.cbSalutation.TabIndex = 17;
            this.cbSalutation.Text = "  -- Please Select --";
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(268, 289);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(86, 43);
            this.btnClearInput.TabIndex = 34;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // QuickPay_Credit_Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 379);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.cbTypeOfCard);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.tbContactNo);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSalutation);
            this.Controls.Add(this.cbSalutation);
            this.Name = "QuickPay_Credit_Cards";
            this.Text = "Credit Card Application Form";
            this.Load += new System.EventHandler(this.QuickPay_Credit_Cards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.ComboBox cbTypeOfCard;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox tbContactNo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalutation;
        private System.Windows.Forms.ComboBox cbSalutation;
        private System.Windows.Forms.Button btnClearInput;
    }
}

