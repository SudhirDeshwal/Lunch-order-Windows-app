namespace Week_3_Lab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkboxLettuce = new System.Windows.Forms.CheckBox();
            this.chkboxKetchup = new System.Windows.Forms.CheckBox();
            this.chkboxFrenchFries = new System.Windows.Forms.CheckBox();
            this.rdobtnHamburger = new System.Windows.Forms.RadioButton();
            this.rdobtnPizza = new System.Windows.Forms.RadioButton();
            this.rdobtnSalad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTaxtotal = new System.Windows.Forms.TextBox();
            this.textOrderTotal = new System.Windows.Forms.TextBox();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtnSalad);
            this.groupBox1.Controls.Add(this.rdobtnPizza);
            this.groupBox1.Controls.Add(this.rdobtnHamburger);
            this.groupBox1.Location = new System.Drawing.Point(57, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Course";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkboxFrenchFries);
            this.groupBox2.Controls.Add(this.chkboxKetchup);
            this.groupBox2.Controls.Add(this.chkboxLettuce);
            this.groupBox2.Location = new System.Drawing.Point(376, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add-on Item($0.75/ each)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textOrderTotal);
            this.groupBox3.Controls.Add(this.txtTaxtotal);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(57, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 167);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // chkboxLettuce
            // 
            this.chkboxLettuce.AutoSize = true;
            this.chkboxLettuce.Location = new System.Drawing.Point(32, 37);
            this.chkboxLettuce.Name = "chkboxLettuce";
            this.chkboxLettuce.Size = new System.Drawing.Size(210, 21);
            this.chkboxLettuce.TabIndex = 0;
            this.chkboxLettuce.Text = "Lettuce, Tomato and Onions";
            this.chkboxLettuce.UseVisualStyleBackColor = true;
            // 
            // chkboxKetchup
            // 
            this.chkboxKetchup.AutoSize = true;
            this.chkboxKetchup.Location = new System.Drawing.Point(32, 79);
            this.chkboxKetchup.Name = "chkboxKetchup";
            this.chkboxKetchup.Size = new System.Drawing.Size(207, 21);
            this.chkboxKetchup.TabIndex = 1;
            this.chkboxKetchup.Text = "Ketchup, mustard and mayo";
            this.chkboxKetchup.UseVisualStyleBackColor = true;
            // 
            // chkboxFrenchFries
            // 
            this.chkboxFrenchFries.AutoSize = true;
            this.chkboxFrenchFries.Location = new System.Drawing.Point(32, 122);
            this.chkboxFrenchFries.Name = "chkboxFrenchFries";
            this.chkboxFrenchFries.Size = new System.Drawing.Size(105, 21);
            this.chkboxFrenchFries.TabIndex = 2;
            this.chkboxFrenchFries.Text = "French fries";
            this.chkboxFrenchFries.UseVisualStyleBackColor = true;
            // 
            // rdobtnHamburger
            // 
            this.rdobtnHamburger.AutoSize = true;
            this.rdobtnHamburger.Location = new System.Drawing.Point(25, 37);
            this.rdobtnHamburger.Name = "rdobtnHamburger";
            this.rdobtnHamburger.Size = new System.Drawing.Size(149, 21);
            this.rdobtnHamburger.TabIndex = 0;
            this.rdobtnHamburger.TabStop = true;
            this.rdobtnHamburger.Text = "Hamburger - $6.95";
            this.rdobtnHamburger.UseVisualStyleBackColor = true;
            // 
            // rdobtnPizza
            // 
            this.rdobtnPizza.AutoSize = true;
            this.rdobtnPizza.Location = new System.Drawing.Point(25, 79);
            this.rdobtnPizza.Name = "rdobtnPizza";
            this.rdobtnPizza.Size = new System.Drawing.Size(112, 21);
            this.rdobtnPizza.TabIndex = 1;
            this.rdobtnPizza.TabStop = true;
            this.rdobtnPizza.Text = "Pizza - $5.95";
            this.rdobtnPizza.UseVisualStyleBackColor = true;
            // 
            // rdobtnSalad
            // 
            this.rdobtnSalad.AutoSize = true;
            this.rdobtnSalad.Location = new System.Drawing.Point(25, 122);
            this.rdobtnSalad.Name = "rdobtnSalad";
            this.rdobtnSalad.Size = new System.Drawing.Size(114, 21);
            this.rdobtnSalad.TabIndex = 2;
            this.rdobtnSalad.TabStop = true;
            this.rdobtnSalad.Text = "Salad - $4.95";
            this.rdobtnSalad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SubTotal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax (7.75%) :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total :";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(212, 34);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 3;
            // 
            // txtTaxtotal
            // 
            this.txtTaxtotal.Location = new System.Drawing.Point(212, 82);
            this.txtTaxtotal.Name = "txtTaxtotal";
            this.txtTaxtotal.Size = new System.Drawing.Size(100, 22);
            this.txtTaxtotal.TabIndex = 4;
            // 
            // textOrderTotal
            // 
            this.textOrderTotal.Location = new System.Drawing.Point(212, 127);
            this.textOrderTotal.Name = "textOrderTotal";
            this.textOrderTotal.Size = new System.Drawing.Size(100, 22);
            this.textOrderTotal.TabIndex = 5;
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.Location = new System.Drawing.Point(541, 293);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(116, 54);
            this.btnPlaceorder.TabIndex = 3;
            this.btnPlaceorder.Text = "Place Order !";
            this.btnPlaceorder.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(541, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(231, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceorder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdobtnSalad;
        private System.Windows.Forms.RadioButton rdobtnPizza;
        private System.Windows.Forms.RadioButton rdobtnHamburger;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkboxFrenchFries;
        private System.Windows.Forms.CheckBox chkboxKetchup;
        private System.Windows.Forms.CheckBox chkboxLettuce;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOrderTotal;
        private System.Windows.Forms.TextBox txtTaxtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnPlaceorder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}

