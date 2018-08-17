namespace Skills2
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
            this.lblWel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txt1stName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.rbnPickUp = new System.Windows.Forms.RadioButton();
            this.rbnDelivery = new System.Windows.Forms.RadioButton();
            this.lbxLoc = new System.Windows.Forms.ListBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWel
            // 
            this.lblWel.AutoSize = true;
            this.lblWel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWel.Location = new System.Drawing.Point(69, 24);
            this.lblWel.Name = "lblWel";
            this.lblWel.Size = new System.Drawing.Size(293, 25);
            this.lblWel.TabIndex = 0;
            this.lblWel.Text = "Welcome to Andrew\'s Food App";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Your Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 106);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 17);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Your Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 148);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(141, 17);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Your Phone Number:";
            // 
            // txt1stName
            // 
            this.txt1stName.Location = new System.Drawing.Point(159, 67);
            this.txt1stName.Name = "txt1stName";
            this.txt1stName.Size = new System.Drawing.Size(100, 22);
            this.txt1stName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(310, 69);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(114, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(39, 17);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(265, 72);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(39, 17);
            this.lblLast.TabIndex = 8;
            this.lblLast.Text = "Last:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(159, 106);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(159, 148);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // rbnPickUp
            // 
            this.rbnPickUp.AutoSize = true;
            this.rbnPickUp.Location = new System.Drawing.Point(159, 190);
            this.rbnPickUp.Name = "rbnPickUp";
            this.rbnPickUp.Size = new System.Drawing.Size(78, 21);
            this.rbnPickUp.TabIndex = 10;
            this.rbnPickUp.TabStop = true;
            this.rbnPickUp.Text = "Pick-Up";
            this.rbnPickUp.UseVisualStyleBackColor = true;
            // 
            // rbnDelivery
            // 
            this.rbnDelivery.AutoSize = true;
            this.rbnDelivery.Location = new System.Drawing.Point(310, 190);
            this.rbnDelivery.Name = "rbnDelivery";
            this.rbnDelivery.Size = new System.Drawing.Size(80, 21);
            this.rbnDelivery.TabIndex = 11;
            this.rbnDelivery.TabStop = true;
            this.rbnDelivery.Text = "Delivery";
            this.rbnDelivery.UseVisualStyleBackColor = true;
            // 
            // lbxLoc
            // 
            this.lbxLoc.FormattingEnabled = true;
            this.lbxLoc.ItemHeight = 16;
            this.lbxLoc.Items.AddRange(new object[] {
            "KFC North",
            "KFC South",
            "KFC East"});
            this.lbxLoc.Location = new System.Drawing.Point(156, 237);
            this.lbxLoc.Name = "lbxLoc";
            this.lbxLoc.Size = new System.Drawing.Size(81, 52);
            this.lbxLoc.TabIndex = 12;
            this.lbxLoc.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(12, 237);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(102, 17);
            this.lblPlace.TabIndex = 13;
            this.lblPlace.Text = "Food Location:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(184, 329);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 15;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(335, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Andrew Singley 5173";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lbxLoc);
            this.Controls.Add(this.rbnDelivery);
            this.Controls.Add(this.rbnPickUp);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txt1stName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txt1stName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton rbnPickUp;
        private System.Windows.Forms.RadioButton rbnDelivery;
        private System.Windows.Forms.ListBox lbxLoc;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

