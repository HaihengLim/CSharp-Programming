namespace WinFormsApp1
{
    partial class CreateForm
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtScore = new TextBox();
            btnClose = new Button();
            btnReset = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(83, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(329, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Gender:";
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(83, 76);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(51, 19);
            radioMale.TabIndex = 3;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(154, 76);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(63, 19);
            radioFemale.TabIndex = 4;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(83, 125);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(65, 23);
            txtAge.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 128);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "years old";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 175);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 8;
            label5.Text = "Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(83, 172);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(79, 23);
            txtScore.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 211);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(148, 211);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 23);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(284, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 247);
            Controls.Add(btnAdd);
            Controls.Add(btnReset);
            Controls.Add(btnClose);
            Controls.Add(txtScore);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAge);
            Controls.Add(label3);
            Controls.Add(radioFemale);
            Controls.Add(radioMale);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "CreateForm";
            Text = "CreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private Label label5;
        private TextBox txtScore;
        private Button btnClose;
        private Button btnReset;
        private Button btnAdd;
    }
}