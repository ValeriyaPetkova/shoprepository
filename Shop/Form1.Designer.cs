namespace Shop
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
            this.cboxTypeOfProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTypeOfPants = new System.Windows.Forms.Label();
            this.cboxTypeOfPants = new System.Windows.Forms.ComboBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGetSumAll = new System.Windows.Forms.Button();
            this.tbProducts = new System.Windows.Forms.TextBox();
            this.cboxTypeOfCoat = new System.Windows.Forms.ComboBox();
            this.lbTypeOfCoat = new System.Windows.Forms.Label();
            this.chboxTShirt = new System.Windows.Forms.CheckBox();
            this.chboxPants = new System.Windows.Forms.CheckBox();
            this.chboxCoats = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cboxTypeOfProduct
            // 
            this.cboxTypeOfProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTypeOfProduct.FormattingEnabled = true;
            this.cboxTypeOfProduct.Items.AddRange(new object[] {
            "T-Shirt",
            "Pants",
            "Coats"});
            this.cboxTypeOfProduct.Location = new System.Drawing.Point(12, 33);
            this.cboxTypeOfProduct.Name = "cboxTypeOfProduct";
            this.cboxTypeOfProduct.Size = new System.Drawing.Size(140, 21);
            this.cboxTypeOfProduct.TabIndex = 0;
            this.cboxTypeOfProduct.SelectedIndexChanged += new System.EventHandler(this.cboxTypeOfProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Type";
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(12, 90);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(140, 20);
            this.tbColor.TabIndex = 2;
            this.tbColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbColor_KeyPress);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(12, 141);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(140, 20);
            this.tbPrice.TabIndex = 3;            
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(12, 191);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(140, 20);
            this.tbSize.TabIndex = 4;
            this.tbSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSize_KeyPress);
            // 
            // tbMaterial
            // 
            this.tbMaterial.Location = new System.Drawing.Point(12, 246);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(140, 20);
            this.tbMaterial.TabIndex = 5;
            this.tbMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaterial_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Material";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTypeOfPants
            // 
            this.lbTypeOfPants.AutoSize = true;
            this.lbTypeOfPants.Location = new System.Drawing.Point(12, 283);
            this.lbTypeOfPants.Name = "lbTypeOfPants";
            this.lbTypeOfPants.Size = new System.Drawing.Size(73, 13);
            this.lbTypeOfPants.TabIndex = 12;
            this.lbTypeOfPants.Text = "Type of Pants";
            this.lbTypeOfPants.Visible = false;
            // 
            // cboxTypeOfPants
            // 
            this.cboxTypeOfPants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTypeOfPants.FormattingEnabled = true;
            this.cboxTypeOfPants.Items.AddRange(new object[] {
            "Short Pants",
            "Long Pants",
            "Slim Pants",
            "Casual Pants"});
            this.cboxTypeOfPants.Location = new System.Drawing.Point(15, 299);
            this.cboxTypeOfPants.Name = "cboxTypeOfPants";
            this.cboxTypeOfPants.Size = new System.Drawing.Size(137, 21);
            this.cboxTypeOfPants.TabIndex = 14;
            this.cboxTypeOfPants.Visible = false;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(285, 278);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 17;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnGetSumAll
            // 
            this.btnGetSumAll.Location = new System.Drawing.Point(380, 278);
            this.btnGetSumAll.Name = "btnGetSumAll";
            this.btnGetSumAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetSumAll.TabIndex = 18;
            this.btnGetSumAll.Text = "Get the Sum";
            this.btnGetSumAll.UseVisualStyleBackColor = true;
            this.btnGetSumAll.Click += new System.EventHandler(this.btnGetSumAll_Click);
            // 
            // tbProducts
            // 
            this.tbProducts.Location = new System.Drawing.Point(185, 17);
            this.tbProducts.Multiline = true;
            this.tbProducts.Name = "tbProducts";
            this.tbProducts.ReadOnly = true;
            this.tbProducts.Size = new System.Drawing.Size(290, 232);
            this.tbProducts.TabIndex = 19;
            // 
            // cboxTypeOfCoat
            // 
            this.cboxTypeOfCoat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTypeOfCoat.FormattingEnabled = true;
            this.cboxTypeOfCoat.Items.AddRange(new object[] {
            "Long",
            "Normal",
            "Short"});
            this.cboxTypeOfCoat.Location = new System.Drawing.Point(16, 347);
            this.cboxTypeOfCoat.Name = "cboxTypeOfCoat";
            this.cboxTypeOfCoat.Size = new System.Drawing.Size(136, 21);
            this.cboxTypeOfCoat.TabIndex = 21;
            this.cboxTypeOfCoat.Visible = false;
            // 
            // lbTypeOfCoat
            // 
            this.lbTypeOfCoat.AutoSize = true;
            this.lbTypeOfCoat.Location = new System.Drawing.Point(13, 331);
            this.lbTypeOfCoat.Name = "lbTypeOfCoat";
            this.lbTypeOfCoat.Size = new System.Drawing.Size(68, 13);
            this.lbTypeOfCoat.TabIndex = 22;
            this.lbTypeOfCoat.Text = "Type of Coat";
            this.lbTypeOfCoat.Visible = false;
            // 
            // chboxTShirt
            // 
            this.chboxTShirt.AutoSize = true;
            this.chboxTShirt.Location = new System.Drawing.Point(224, 327);
            this.chboxTShirt.Name = "chboxTShirt";
            this.chboxTShirt.Size = new System.Drawing.Size(62, 17);
            this.chboxTShirt.TabIndex = 23;
            this.chboxTShirt.Text = "T-Shirts";
            this.chboxTShirt.UseVisualStyleBackColor = true;
            // 
            // chboxPants
            // 
            this.chboxPants.AutoSize = true;
            this.chboxPants.Location = new System.Drawing.Point(292, 327);
            this.chboxPants.Name = "chboxPants";
            this.chboxPants.Size = new System.Drawing.Size(53, 17);
            this.chboxPants.TabIndex = 24;
            this.chboxPants.Text = "Pants";
            this.chboxPants.UseVisualStyleBackColor = true;
            // 
            // chboxCoats
            // 
            this.chboxCoats.AutoSize = true;
            this.chboxCoats.Location = new System.Drawing.Point(351, 327);
            this.chboxCoats.Name = "chboxCoats";
            this.chboxCoats.Size = new System.Drawing.Size(48, 17);
            this.chboxCoats.TabIndex = 25;
            this.chboxCoats.Text = "Coat";
            this.chboxCoats.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 395);
            this.Controls.Add(this.chboxCoats);
            this.Controls.Add(this.chboxPants);
            this.Controls.Add(this.chboxTShirt);
            this.Controls.Add(this.lbTypeOfCoat);
            this.Controls.Add(this.cboxTypeOfCoat);
            this.Controls.Add(this.tbProducts);
            this.Controls.Add(this.btnGetSumAll);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.cboxTypeOfPants);
            this.Controls.Add(this.lbTypeOfPants);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaterial);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxTypeOfProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxTypeOfProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbTypeOfPants;
        private System.Windows.Forms.ComboBox cboxTypeOfPants;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetSumAll;
        private System.Windows.Forms.TextBox tbProducts;
        private System.Windows.Forms.ComboBox cboxTypeOfCoat;
        private System.Windows.Forms.Label lbTypeOfCoat;
        private System.Windows.Forms.CheckBox chboxTShirt;
        private System.Windows.Forms.CheckBox chboxPants;
        private System.Windows.Forms.CheckBox chboxCoats;
    }
}

