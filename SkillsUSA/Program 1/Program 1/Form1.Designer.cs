namespace Program_1
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
            this.lblCon = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.rbnFeet = new System.Windows.Forms.RadioButton();
            this.rbnYards = new System.Windows.Forms.RadioButton();
            this.lblMiles = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(228, 26);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(98, 25);
            this.lblCon.TabIndex = 0;
            this.lblCon.Text = "Converter";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(31, 68);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(80, 17);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(283, 66);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(80, 17);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(31, 165);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(131, 17);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Number to Convert:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(168, 63);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 22);
            this.txtFName.TabIndex = 4;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(369, 65);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 22);
            this.txtLname.TabIndex = 5;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(168, 165);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 6;
            // 
            // rbnFeet
            // 
            this.rbnFeet.AutoSize = true;
            this.rbnFeet.Location = new System.Drawing.Point(34, 116);
            this.rbnFeet.Name = "rbnFeet";
            this.rbnFeet.Size = new System.Drawing.Size(143, 21);
            this.rbnFeet.TabIndex = 7;
            this.rbnFeet.TabStop = true;
            this.rbnFeet.Text = "Feet to Millimeters";
            this.rbnFeet.UseVisualStyleBackColor = true;
            // 
            // rbnYards
            // 
            this.rbnYards.AutoSize = true;
            this.rbnYards.Location = new System.Drawing.Point(206, 116);
            this.rbnYards.Name = "rbnYards";
            this.rbnYards.Size = new System.Drawing.Size(129, 21);
            this.rbnYards.TabIndex = 8;
            this.rbnYards.TabStop = true;
            this.rbnYards.Text = "Yards to Meters";
            this.rbnYards.UseVisualStyleBackColor = true;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(384, 116);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(147, 21);
            this.lblMiles.TabIndex = 9;
            this.lblMiles.TabStop = true;
            this.lblMiles.Text = "Miles to Kilometers";
            this.lblMiles.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(233, 345);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 11;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(456, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(31, 240);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(59, 17);
            this.lblResults.TabIndex = 13;
            this.lblResults.Text = "Results:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Andrew Singley 5173";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.rbnYards);
            this.Controls.Add(this.rbnFeet);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.RadioButton rbnFeet;
        private System.Windows.Forms.RadioButton rbnYards;
        private System.Windows.Forms.RadioButton lblMiles;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label1;
    }
}

