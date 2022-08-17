namespace Rental_Form_MLLAD007
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
            this.grpBoxGenreType = new System.Windows.Forms.GroupBox();
            this.grpCalculations = new System.Windows.Forms.GroupBox();
            this.radiobtnChildren = new System.Windows.Forms.RadioButton();
            this.radiobtnComedy = new System.Windows.Forms.RadioButton();
            this.radiobtnAction = new System.Windows.Forms.RadioButton();
            this.radiobtnAdventure = new System.Windows.Forms.RadioButton();
            this.lblDVDPrice = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtBoxDVDPrice = new System.Windows.Forms.TextBox();
            this.txtBoxTaxes = new System.Windows.Forms.TextBox();
            this.txtBoxAmountDue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCustomerName = new System.Windows.Forms.TextBox();
            this.grpBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBoxCustomerDetails = new System.Windows.Forms.TextBox();
            this.grpBoxGenreType.SuspendLayout();
            this.grpCalculations.SuspendLayout();
            this.grpBoxCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGenreType
            // 
            this.grpBoxGenreType.Controls.Add(this.radiobtnAdventure);
            this.grpBoxGenreType.Controls.Add(this.radiobtnAction);
            this.grpBoxGenreType.Controls.Add(this.radiobtnComedy);
            this.grpBoxGenreType.Controls.Add(this.radiobtnChildren);
            this.grpBoxGenreType.Location = new System.Drawing.Point(121, 108);
            this.grpBoxGenreType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxGenreType.Name = "grpBoxGenreType";
            this.grpBoxGenreType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxGenreType.Size = new System.Drawing.Size(385, 252);
            this.grpBoxGenreType.TabIndex = 0;
            this.grpBoxGenreType.TabStop = false;
            this.grpBoxGenreType.Text = "Genre type";
            // 
            // grpCalculations
            // 
            this.grpCalculations.Controls.Add(this.btnClear);
            this.grpCalculations.Controls.Add(this.btnCalculate);
            this.grpCalculations.Controls.Add(this.txtBoxAmountDue);
            this.grpCalculations.Controls.Add(this.txtBoxTaxes);
            this.grpCalculations.Controls.Add(this.txtBoxDVDPrice);
            this.grpCalculations.Controls.Add(this.lblAmountDue);
            this.grpCalculations.Controls.Add(this.lblTaxes);
            this.grpCalculations.Controls.Add(this.lblDVDPrice);
            this.grpCalculations.Location = new System.Drawing.Point(551, 111);
            this.grpCalculations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCalculations.Name = "grpCalculations";
            this.grpCalculations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCalculations.Size = new System.Drawing.Size(436, 249);
            this.grpCalculations.TabIndex = 1;
            this.grpCalculations.TabStop = false;
            this.grpCalculations.Text = "Calculations";
            // 
            // radiobtnChildren
            // 
            this.radiobtnChildren.AutoSize = true;
            this.radiobtnChildren.Location = new System.Drawing.Point(10, 39);
            this.radiobtnChildren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiobtnChildren.Name = "radiobtnChildren";
            this.radiobtnChildren.Size = new System.Drawing.Size(100, 24);
            this.radiobtnChildren.TabIndex = 3;
            this.radiobtnChildren.TabStop = true;
            this.radiobtnChildren.Text = "Children";
            this.radiobtnChildren.UseVisualStyleBackColor = true;
            // 
            // radiobtnComedy
            // 
            this.radiobtnComedy.AutoSize = true;
            this.radiobtnComedy.Location = new System.Drawing.Point(10, 88);
            this.radiobtnComedy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiobtnComedy.Name = "radiobtnComedy";
            this.radiobtnComedy.Size = new System.Drawing.Size(97, 24);
            this.radiobtnComedy.TabIndex = 1;
            this.radiobtnComedy.TabStop = true;
            this.radiobtnComedy.Text = "Comedy";
            this.radiobtnComedy.UseVisualStyleBackColor = true;
            // 
            // radiobtnAction
            // 
            this.radiobtnAction.AutoSize = true;
            this.radiobtnAction.Location = new System.Drawing.Point(10, 134);
            this.radiobtnAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiobtnAction.Name = "radiobtnAction";
            this.radiobtnAction.Size = new System.Drawing.Size(83, 24);
            this.radiobtnAction.TabIndex = 2;
            this.radiobtnAction.TabStop = true;
            this.radiobtnAction.Text = "Action";
            this.radiobtnAction.UseVisualStyleBackColor = true;
            // 
            // radiobtnAdventure
            // 
            this.radiobtnAdventure.AutoSize = true;
            this.radiobtnAdventure.Location = new System.Drawing.Point(10, 169);
            this.radiobtnAdventure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiobtnAdventure.Name = "radiobtnAdventure";
            this.radiobtnAdventure.Size = new System.Drawing.Size(114, 24);
            this.radiobtnAdventure.TabIndex = 3;
            this.radiobtnAdventure.TabStop = true;
            this.radiobtnAdventure.Text = "Adventure";
            this.radiobtnAdventure.UseVisualStyleBackColor = true;
            // 
            // lblDVDPrice
            // 
            this.lblDVDPrice.AutoSize = true;
            this.lblDVDPrice.Location = new System.Drawing.Point(10, 35);
            this.lblDVDPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDVDPrice.Name = "lblDVDPrice";
            this.lblDVDPrice.Size = new System.Drawing.Size(99, 20);
            this.lblDVDPrice.TabIndex = 0;
            this.lblDVDPrice.Text = "DVD Price";
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(14, 84);
            this.lblTaxes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(59, 20);
            this.lblTaxes.TabIndex = 1;
            this.lblTaxes.Text = "Taxes";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(18, 130);
            this.lblAmountDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(112, 20);
            this.lblAmountDue.TabIndex = 2;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // txtBoxDVDPrice
            // 
            this.txtBoxDVDPrice.Location = new System.Drawing.Point(148, 35);
            this.txtBoxDVDPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDVDPrice.Name = "txtBoxDVDPrice";
            this.txtBoxDVDPrice.Size = new System.Drawing.Size(136, 27);
            this.txtBoxDVDPrice.TabIndex = 3;
            this.txtBoxDVDPrice.TextChanged += new System.EventHandler(this.txtBoxDVDPrice_TextChanged);
            // 
            // txtBoxTaxes
            // 
            this.txtBoxTaxes.Location = new System.Drawing.Point(148, 76);
            this.txtBoxTaxes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxTaxes.Name = "txtBoxTaxes";
            this.txtBoxTaxes.ReadOnly = true;
            this.txtBoxTaxes.Size = new System.Drawing.Size(136, 27);
            this.txtBoxTaxes.TabIndex = 4;
            // 
            // txtBoxAmountDue
            // 
            this.txtBoxAmountDue.Location = new System.Drawing.Point(148, 130);
            this.txtBoxAmountDue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxAmountDue.Name = "txtBoxAmountDue";
            this.txtBoxAmountDue.ReadOnly = true;
            this.txtBoxAmountDue.Size = new System.Drawing.Size(136, 27);
            this.txtBoxAmountDue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.Location = new System.Drawing.Point(337, 31);
            this.txtBoxCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.Size = new System.Drawing.Size(463, 27);
            this.txtBoxCustomerName.TabIndex = 0;
            this.txtBoxCustomerName.TextChanged += new System.EventHandler(this.txtBoxCustomerName_TextChanged);
            // 
            // grpBoxCustomerDetails
            // 
            this.grpBoxCustomerDetails.Controls.Add(this.txtBoxCustomerDetails);
            this.grpBoxCustomerDetails.Location = new System.Drawing.Point(164, 399);
            this.grpBoxCustomerDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxCustomerDetails.Name = "grpBoxCustomerDetails";
            this.grpBoxCustomerDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxCustomerDetails.Size = new System.Drawing.Size(690, 138);
            this.grpBoxCustomerDetails.TabIndex = 4;
            this.grpBoxCustomerDetails.TabStop = false;
            this.grpBoxCustomerDetails.Text = "Customer Details";
            this.grpBoxCustomerDetails.Enter += new System.EventHandler(this.grpBoxCustomerDetails_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(34, 184);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 47);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(225, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 47);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBoxCustomerDetails
            // 
            this.txtBoxCustomerDetails.ForeColor = System.Drawing.Color.Black;
            this.txtBoxCustomerDetails.Location = new System.Drawing.Point(86, 38);
            this.txtBoxCustomerDetails.Multiline = true;
            this.txtBoxCustomerDetails.Name = "txtBoxCustomerDetails";
            this.txtBoxCustomerDetails.Size = new System.Drawing.Size(527, 84);
            this.txtBoxCustomerDetails.TabIndex = 0;
            this.txtBoxCustomerDetails.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.grpBoxCustomerDetails);
            this.Controls.Add(this.txtBoxCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCalculations);
            this.Controls.Add(this.grpBoxGenreType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Form";
            this.grpBoxGenreType.ResumeLayout(false);
            this.grpBoxGenreType.PerformLayout();
            this.grpCalculations.ResumeLayout(false);
            this.grpCalculations.PerformLayout();
            this.grpBoxCustomerDetails.ResumeLayout(false);
            this.grpBoxCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxGenreType;
        private System.Windows.Forms.RadioButton radiobtnAdventure;
        private System.Windows.Forms.RadioButton radiobtnAction;
        private System.Windows.Forms.RadioButton radiobtnComedy;
        private System.Windows.Forms.RadioButton radiobtnChildren;
        private System.Windows.Forms.GroupBox grpCalculations;
        private System.Windows.Forms.TextBox txtBoxAmountDue;
        private System.Windows.Forms.TextBox txtBoxTaxes;
        private System.Windows.Forms.TextBox txtBoxDVDPrice;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblDVDPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCustomerName;
        private System.Windows.Forms.GroupBox grpBoxCustomerDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBoxCustomerDetails;
    }
}

