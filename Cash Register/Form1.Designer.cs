namespace Cash_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelQuadruple = new System.Windows.Forms.Label();
            this.labelMcDonalds = new System.Windows.Forms.Label();
            this.labelOnePounder = new System.Windows.Forms.Label();
            this.labelMilkshake = new System.Windows.Forms.Label();
            this.textQuadruple = new System.Windows.Forms.TextBox();
            this.textOnePounder = new System.Windows.Forms.TextBox();
            this.textMilkshake = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTendered = new System.Windows.Forms.Label();
            this.textTendered = new System.Windows.Forms.MaskedTextBox();
            this.buttonCalculateChange = new System.Windows.Forms.Button();
            this.labelReceipt = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.buttonReceipt = new System.Windows.Forms.Button();
            this.labelReceiptTitle = new System.Windows.Forms.Label();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelReceiptDate = new System.Windows.Forms.Label();
            this.labelQuadrupleReceipt = new System.Windows.Forms.Label();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.labelTitleSubtotal = new System.Windows.Forms.Label();
            this.labelTaxTitle = new System.Windows.Forms.Label();
            this.labelTotalTitle = new System.Windows.Forms.Label();
            this.labelChangeTitle = new System.Windows.Forms.Label();
            this.labelOnepounderReceipt = new System.Windows.Forms.Label();
            this.labelMilkshakeReceipt = new System.Windows.Forms.Label();
            this.labelSubtotalReceipt = new System.Windows.Forms.Label();
            this.labelTaxReceipt = new System.Windows.Forms.Label();
            this.labelTotalReceipt = new System.Windows.Forms.Label();
            this.labelTenderedReceipt = new System.Windows.Forms.Label();
            this.labelChangeReceipt = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelGoodbye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuadruple
            // 
            this.labelQuadruple.Font = new System.Drawing.Font("Millenium BdEx BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuadruple.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelQuadruple.Location = new System.Drawing.Point(12, 45);
            this.labelQuadruple.Name = "labelQuadruple";
            this.labelQuadruple.Size = new System.Drawing.Size(218, 42);
            this.labelQuadruple.TabIndex = 0;
            this.labelQuadruple.Text = "Quadruple Patty Burger";
            this.labelQuadruple.Click += new System.EventHandler(this.LabelQuadruple_Click);
            // 
            // labelMcDonalds
            // 
            this.labelMcDonalds.AutoSize = true;
            this.labelMcDonalds.Font = new System.Drawing.Font("Novarese Bk BT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMcDonalds.ForeColor = System.Drawing.Color.OldLace;
            this.labelMcDonalds.Location = new System.Drawing.Point(471, 9);
            this.labelMcDonalds.Name = "labelMcDonalds";
            this.labelMcDonalds.Size = new System.Drawing.Size(180, 47);
            this.labelMcDonalds.TabIndex = 1;
            this.labelMcDonalds.Text = "Burgville";
            // 
            // labelOnePounder
            // 
            this.labelOnePounder.Font = new System.Drawing.Font("Millenium BdEx BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnePounder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOnePounder.Location = new System.Drawing.Point(12, 87);
            this.labelOnePounder.Name = "labelOnePounder";
            this.labelOnePounder.Size = new System.Drawing.Size(218, 33);
            this.labelOnePounder.TabIndex = 2;
            this.labelOnePounder.Text = "The One Pounder";
            this.labelOnePounder.Click += new System.EventHandler(this.LabelOnePounder_Click);
            // 
            // labelMilkshake
            // 
            this.labelMilkshake.Font = new System.Drawing.Font("Millenium BdEx BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMilkshake.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMilkshake.Location = new System.Drawing.Point(89, 120);
            this.labelMilkshake.Name = "labelMilkshake";
            this.labelMilkshake.Size = new System.Drawing.Size(120, 33);
            this.labelMilkshake.TabIndex = 3;
            this.labelMilkshake.Text = "Milkshake";
            // 
            // textQuadruple
            // 
            this.textQuadruple.Location = new System.Drawing.Point(219, 45);
            this.textQuadruple.Name = "textQuadruple";
            this.textQuadruple.Size = new System.Drawing.Size(100, 20);
            this.textQuadruple.TabIndex = 4;
            // 
            // textOnePounder
            // 
            this.textOnePounder.Location = new System.Drawing.Point(219, 85);
            this.textOnePounder.Name = "textOnePounder";
            this.textOnePounder.Size = new System.Drawing.Size(100, 20);
            this.textOnePounder.TabIndex = 5;
            // 
            // textMilkshake
            // 
            this.textMilkshake.Location = new System.Drawing.Point(219, 118);
            this.textMilkshake.Name = "textMilkshake";
            this.textMilkshake.Size = new System.Drawing.Size(100, 20);
            this.textMilkshake.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(77, 144);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(208, 31);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSubtotal.Location = new System.Drawing.Point(185, 178);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(0, 17);
            this.labelSubtotal.TabIndex = 9;
            this.labelSubtotal.Click += new System.EventHandler(this.LabelSubtotal_Click);
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTax.Location = new System.Drawing.Point(182, 195);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(0, 17);
            this.labelTax.TabIndex = 10;
            this.labelTax.Click += new System.EventHandler(this.LabelTax_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotal.Location = new System.Drawing.Point(182, 212);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 17);
            this.labelTotal.TabIndex = 11;
            // 
            // labelTendered
            // 
            this.labelTendered.AutoSize = true;
            this.labelTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTendered.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTendered.Location = new System.Drawing.Point(123, 244);
            this.labelTendered.Name = "labelTendered";
            this.labelTendered.Size = new System.Drawing.Size(70, 17);
            this.labelTendered.TabIndex = 13;
            this.labelTendered.Text = "Tendered";
            // 
            // textTendered
            // 
            this.textTendered.Location = new System.Drawing.Point(219, 244);
            this.textTendered.Name = "textTendered";
            this.textTendered.Size = new System.Drawing.Size(100, 20);
            this.textTendered.TabIndex = 14;
            // 
            // buttonCalculateChange
            // 
            this.buttonCalculateChange.BackColor = System.Drawing.Color.Azure;
            this.buttonCalculateChange.Location = new System.Drawing.Point(77, 281);
            this.buttonCalculateChange.Name = "buttonCalculateChange";
            this.buttonCalculateChange.Size = new System.Drawing.Size(208, 23);
            this.buttonCalculateChange.TabIndex = 15;
            this.buttonCalculateChange.Text = "Calculate Change";
            this.buttonCalculateChange.UseVisualStyleBackColor = false;
            this.buttonCalculateChange.Click += new System.EventHandler(this.ButtonCalculateChange_Click);
            // 
            // labelReceipt
            // 
            this.labelReceipt.BackColor = System.Drawing.Color.Azure;
            this.labelReceipt.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceipt.Location = new System.Drawing.Point(439, 68);
            this.labelReceipt.Name = "labelReceipt";
            this.labelReceipt.Size = new System.Drawing.Size(272, 323);
            this.labelReceipt.TabIndex = 16;
            this.labelReceipt.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelChange.Location = new System.Drawing.Point(165, 319);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(0, 17);
            this.labelChange.TabIndex = 17;
            // 
            // buttonReceipt
            // 
            this.buttonReceipt.BackColor = System.Drawing.Color.Azure;
            this.buttonReceipt.Location = new System.Drawing.Point(15, 353);
            this.buttonReceipt.Name = "buttonReceipt";
            this.buttonReceipt.Size = new System.Drawing.Size(304, 85);
            this.buttonReceipt.TabIndex = 18;
            this.buttonReceipt.Text = "Print Receipt";
            this.buttonReceipt.UseVisualStyleBackColor = false;
            this.buttonReceipt.Click += new System.EventHandler(this.ButtonReceipt_Click);
            // 
            // labelReceiptTitle
            // 
            this.labelReceiptTitle.AutoSize = true;
            this.labelReceiptTitle.BackColor = System.Drawing.Color.Azure;
            this.labelReceiptTitle.Font = new System.Drawing.Font("Modern880 BT", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiptTitle.Location = new System.Drawing.Point(512, 80);
            this.labelReceiptTitle.Name = "labelReceiptTitle";
            this.labelReceiptTitle.Size = new System.Drawing.Size(0, 23);
            this.labelReceiptTitle.TabIndex = 19;
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.BackColor = System.Drawing.Color.Azure;
            this.labelOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNumber.Location = new System.Drawing.Point(441, 118);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(0, 17);
            this.labelOrderNumber.TabIndex = 20;
            // 
            // labelReceiptDate
            // 
            this.labelReceiptDate.AutoSize = true;
            this.labelReceiptDate.BackColor = System.Drawing.Color.Azure;
            this.labelReceiptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiptDate.Location = new System.Drawing.Point(441, 136);
            this.labelReceiptDate.Name = "labelReceiptDate";
            this.labelReceiptDate.Size = new System.Drawing.Size(0, 17);
            this.labelReceiptDate.TabIndex = 21;
            // 
            // labelQuadrupleReceipt
            // 
            this.labelQuadrupleReceipt.BackColor = System.Drawing.Color.Azure;
            this.labelQuadrupleReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuadrupleReceipt.Location = new System.Drawing.Point(441, 178);
            this.labelQuadrupleReceipt.Name = "labelQuadrupleReceipt";
            this.labelQuadrupleReceipt.Size = new System.Drawing.Size(245, 17);
            this.labelQuadrupleReceipt.TabIndex = 22;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Snow;
            this.labelErrorMessage.Location = new System.Drawing.Point(285, 141);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(150, 38);
            this.labelErrorMessage.TabIndex = 23;
            this.labelErrorMessage.Click += new System.EventHandler(this.LabelErrorMessage_Click);
            // 
            // labelTitleSubtotal
            // 
            this.labelTitleSubtotal.AutoSize = true;
            this.labelTitleSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSubtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitleSubtotal.Location = new System.Drawing.Point(123, 178);
            this.labelTitleSubtotal.Name = "labelTitleSubtotal";
            this.labelTitleSubtotal.Size = new System.Drawing.Size(64, 17);
            this.labelTitleSubtotal.TabIndex = 24;
            this.labelTitleSubtotal.Text = "Subtotal:";
            // 
            // labelTaxTitle
            // 
            this.labelTaxTitle.AutoSize = true;
            this.labelTaxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTaxTitle.Location = new System.Drawing.Point(150, 195);
            this.labelTaxTitle.Name = "labelTaxTitle";
            this.labelTaxTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTaxTitle.TabIndex = 25;
            this.labelTaxTitle.Text = "Tax:";
            // 
            // labelTotalTitle
            // 
            this.labelTotalTitle.AutoSize = true;
            this.labelTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalTitle.Location = new System.Drawing.Point(141, 212);
            this.labelTotalTitle.Name = "labelTotalTitle";
            this.labelTotalTitle.Size = new System.Drawing.Size(44, 17);
            this.labelTotalTitle.TabIndex = 26;
            this.labelTotalTitle.Text = "Total:";
            // 
            // labelChangeTitle
            // 
            this.labelChangeTitle.AutoSize = true;
            this.labelChangeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelChangeTitle.Location = new System.Drawing.Point(104, 319);
            this.labelChangeTitle.Name = "labelChangeTitle";
            this.labelChangeTitle.Size = new System.Drawing.Size(65, 17);
            this.labelChangeTitle.TabIndex = 27;
            this.labelChangeTitle.Text = "Change: ";
            // 
            // labelOnepounderReceipt
            // 
            this.labelOnepounderReceipt.BackColor = System.Drawing.Color.Azure;
            this.labelOnepounderReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnepounderReceipt.Location = new System.Drawing.Point(441, 195);
            this.labelOnepounderReceipt.Name = "labelOnepounderReceipt";
            this.labelOnepounderReceipt.Size = new System.Drawing.Size(253, 13);
            this.labelOnepounderReceipt.TabIndex = 28;
            // 
            // labelMilkshakeReceipt
            // 
            this.labelMilkshakeReceipt.BackColor = System.Drawing.Color.Azure;
            this.labelMilkshakeReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMilkshakeReceipt.Location = new System.Drawing.Point(441, 208);
            this.labelMilkshakeReceipt.Name = "labelMilkshakeReceipt";
            this.labelMilkshakeReceipt.Size = new System.Drawing.Size(253, 13);
            this.labelMilkshakeReceipt.TabIndex = 29;
            // 
            // labelSubtotalReceipt
            // 
            this.labelSubtotalReceipt.BackColor = System.Drawing.Color.Azure;
            this.labelSubtotalReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotalReceipt.Location = new System.Drawing.Point(441, 245);
            this.labelSubtotalReceipt.Name = "labelSubtotalReceipt";
            this.labelSubtotalReceipt.Size = new System.Drawing.Size(231, 13);
            this.labelSubtotalReceipt.TabIndex = 30;
            // 
            // labelTaxReceipt
            // 
            this.labelTaxReceipt.BackColor = System.Drawing.Color.Azure;
            this.labelTaxReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxReceipt.Location = new System.Drawing.Point(441, 258);
            this.labelTaxReceipt.Name = "labelTaxReceipt";
            this.labelTaxReceipt.Size = new System.Drawing.Size(245, 13);
            this.labelTaxReceipt.TabIndex = 31;
            // 
            // labelTotalReceipt
            // 
            this.labelTotalReceipt.BackColor = System.Drawing.Color.Azure;
            this.labelTotalReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalReceipt.Location = new System.Drawing.Point(441, 271);
            this.labelTotalReceipt.Name = "labelTotalReceipt";
            this.labelTotalReceipt.Size = new System.Drawing.Size(253, 13);
            this.labelTotalReceipt.TabIndex = 32;
            // 
            // labelTenderedReceipt
            // 
            this.labelTenderedReceipt.BackColor = System.Drawing.Color.Azure;
            this.labelTenderedReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenderedReceipt.Location = new System.Drawing.Point(441, 301);
            this.labelTenderedReceipt.Name = "labelTenderedReceipt";
            this.labelTenderedReceipt.Size = new System.Drawing.Size(231, 13);
            this.labelTenderedReceipt.TabIndex = 33;
            // 
            // labelChangeReceipt
            // 
            this.labelChangeReceipt.BackColor = System.Drawing.Color.Azure;
            this.labelChangeReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeReceipt.Location = new System.Drawing.Point(443, 314);
            this.labelChangeReceipt.Name = "labelChangeReceipt";
            this.labelChangeReceipt.Size = new System.Drawing.Size(243, 13);
            this.labelChangeReceipt.TabIndex = 34;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Azure;
            this.buttonReset.Location = new System.Drawing.Point(717, 98);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 229);
            this.buttonReset.TabIndex = 35;
            this.buttonReset.Text = " New Order";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // labelGoodbye
            // 
            this.labelGoodbye.BackColor = System.Drawing.Color.Azure;
            this.labelGoodbye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoodbye.Location = new System.Drawing.Point(443, 353);
            this.labelGoodbye.Name = "labelGoodbye";
            this.labelGoodbye.Size = new System.Drawing.Size(253, 13);
            this.labelGoodbye.TabIndex = 37;
            this.labelGoodbye.Click += new System.EventHandler(this.LabelGoodbye_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGoodbye);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelChangeReceipt);
            this.Controls.Add(this.labelTenderedReceipt);
            this.Controls.Add(this.labelTotalReceipt);
            this.Controls.Add(this.labelTaxReceipt);
            this.Controls.Add(this.labelSubtotalReceipt);
            this.Controls.Add(this.labelMilkshakeReceipt);
            this.Controls.Add(this.labelOnepounderReceipt);
            this.Controls.Add(this.labelChangeTitle);
            this.Controls.Add(this.labelTotalTitle);
            this.Controls.Add(this.labelTaxTitle);
            this.Controls.Add(this.labelTitleSubtotal);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.labelQuadrupleReceipt);
            this.Controls.Add(this.labelReceiptDate);
            this.Controls.Add(this.labelOrderNumber);
            this.Controls.Add(this.labelReceiptTitle);
            this.Controls.Add(this.buttonReceipt);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelReceipt);
            this.Controls.Add(this.buttonCalculateChange);
            this.Controls.Add(this.textTendered);
            this.Controls.Add(this.labelTendered);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textMilkshake);
            this.Controls.Add(this.textOnePounder);
            this.Controls.Add(this.textQuadruple);
            this.Controls.Add(this.labelMilkshake);
            this.Controls.Add(this.labelOnePounder);
            this.Controls.Add(this.labelMcDonalds);
            this.Controls.Add(this.labelQuadruple);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Burgville";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuadruple;
        private System.Windows.Forms.Label labelMcDonalds;
        private System.Windows.Forms.Label labelOnePounder;
        private System.Windows.Forms.Label labelMilkshake;
        private System.Windows.Forms.TextBox textQuadruple;
        private System.Windows.Forms.TextBox textOnePounder;
        private System.Windows.Forms.TextBox textMilkshake;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTendered;
        private System.Windows.Forms.MaskedTextBox textTendered;
        private System.Windows.Forms.Button buttonCalculateChange;
        private System.Windows.Forms.Label labelReceipt;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Button buttonReceipt;
        private System.Windows.Forms.Label labelReceiptTitle;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Label labelReceiptDate;
        private System.Windows.Forms.Label labelQuadrupleReceipt;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Label labelTitleSubtotal;
        private System.Windows.Forms.Label labelTaxTitle;
        private System.Windows.Forms.Label labelTotalTitle;
        private System.Windows.Forms.Label labelChangeTitle;
        private System.Windows.Forms.Label labelOnepounderReceipt;
        private System.Windows.Forms.Label labelMilkshakeReceipt;
        private System.Windows.Forms.Label labelSubtotalReceipt;
        private System.Windows.Forms.Label labelTaxReceipt;
        private System.Windows.Forms.Label labelTotalReceipt;
        private System.Windows.Forms.Label labelTenderedReceipt;
        private System.Windows.Forms.Label labelChangeReceipt;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelGoodbye;
    }
}

