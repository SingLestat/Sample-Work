namespace GradingProgram
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
            this.Banner = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxClass = new System.Windows.Forms.ListBox();
            this.txtClass = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.Label();
            this.boxGrade = new System.Windows.Forms.TextBox();
            this.btnEnterGrade = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.Label();
            this.txtScoresEntered = new System.Windows.Forms.Label();
            this.txtCurrentAverage = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.txtLowScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Banner.AutoSize = true;
            this.Banner.BackColor = System.Drawing.SystemColors.Control;
            this.Banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.Location = new System.Drawing.Point(33, 9);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(319, 33);
            this.Banner.TabIndex = 1;
            this.Banner.Text = "Class Grading Program";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbxClass);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 117);
            this.panel1.TabIndex = 2;
            // 
            // lbxClass
            // 
            this.lbxClass.FormattingEnabled = true;
            this.lbxClass.Items.AddRange(new object[] {
            "Programming",
            "Art",
            "Science",
            "Math",
            "History"});
            this.lbxClass.Location = new System.Drawing.Point(3, 16);
            this.lbxClass.Name = "lbxClass";
            this.lbxClass.Size = new System.Drawing.Size(80, 95);
            this.lbxClass.TabIndex = 1;
            this.lbxClass.SelectedIndexChanged += new System.EventHandler(this.lbxClass_SelectedIndexChanged);
            // 
            // txtClass
            // 
            this.txtClass.AutoSize = true;
            this.txtClass.Location = new System.Drawing.Point(18, 0);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(32, 13);
            this.txtClass.TabIndex = 0;
            this.txtClass.Text = "Class";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(142, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 29);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(142, 290);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 29);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(142, 255);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(100, 29);
            this.btnCal.TabIndex = 16;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Visible = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.AutoSize = true;
            this.txtGrade.Location = new System.Drawing.Point(104, 49);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(42, 13);
            this.txtGrade.TabIndex = 19;
            this.txtGrade.Text = "Grade: ";
            // 
            // boxGrade
            // 
            this.boxGrade.Location = new System.Drawing.Point(152, 46);
            this.boxGrade.Name = "boxGrade";
            this.boxGrade.Size = new System.Drawing.Size(100, 20);
            this.boxGrade.TabIndex = 20;
            // 
            // btnEnterGrade
            // 
            this.btnEnterGrade.Location = new System.Drawing.Point(258, 44);
            this.btnEnterGrade.Name = "btnEnterGrade";
            this.btnEnterGrade.Size = new System.Drawing.Size(75, 23);
            this.btnEnterGrade.TabIndex = 21;
            this.btnEnterGrade.Text = "Enter";
            this.btnEnterGrade.UseVisualStyleBackColor = true;
            this.btnEnterGrade.Visible = false;
            this.btnEnterGrade.Click += new System.EventHandler(this.btnEnterGrade_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.AutoSize = true;
            this.txtClassName.Location = new System.Drawing.Point(12, 177);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(38, 13);
            this.txtClassName.TabIndex = 22;
            this.txtClassName.Text = "Class: ";
            // 
            // txtScoresEntered
            // 
            this.txtScoresEntered.AutoSize = true;
            this.txtScoresEntered.Location = new System.Drawing.Point(12, 204);
            this.txtScoresEntered.Name = "txtScoresEntered";
            this.txtScoresEntered.Size = new System.Drawing.Size(86, 13);
            this.txtScoresEntered.TabIndex = 23;
            this.txtScoresEntered.Text = "Scores Entered: ";
            // 
            // txtCurrentAverage
            // 
            this.txtCurrentAverage.AutoSize = true;
            this.txtCurrentAverage.Location = new System.Drawing.Point(139, 228);
            this.txtCurrentAverage.Name = "txtCurrentAverage";
            this.txtCurrentAverage.Size = new System.Drawing.Size(90, 13);
            this.txtCurrentAverage.TabIndex = 24;
            this.txtCurrentAverage.Text = "Current Average: ";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Location = new System.Drawing.Point(286, 228);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(66, 13);
            this.txtHighScore.TabIndex = 25;
            this.txtHighScore.Text = "High Score: ";
            // 
            // txtLowScore
            // 
            this.txtLowScore.AutoSize = true;
            this.txtLowScore.Location = new System.Drawing.Point(12, 228);
            this.txtLowScore.Name = "txtLowScore";
            this.txtLowScore.Size = new System.Drawing.Size(64, 13);
            this.txtLowScore.TabIndex = 26;
            this.txtLowScore.Text = "Low Score: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Andrew Singley. 10:48. #2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLowScore);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtCurrentAverage);
            this.Controls.Add(this.txtScoresEntered);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.btnEnterGrade);
            this.Controls.Add(this.boxGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Banner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Banner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxClass;
        private System.Windows.Forms.Label txtClass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label txtGrade;
        private System.Windows.Forms.TextBox boxGrade;
        private System.Windows.Forms.Button btnEnterGrade;
        private System.Windows.Forms.Label txtClassName;
        private System.Windows.Forms.Label txtScoresEntered;
        private System.Windows.Forms.Label txtCurrentAverage;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Label txtLowScore;
        private System.Windows.Forms.Label label1;
    }
}

