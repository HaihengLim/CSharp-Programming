namespace WinFormsApp1
{
    partial class UpdateForm
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
            btnEdit = new Button();
            btnReset = new Button();
            btnClose = new Button();
            txtScore = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            radioFemale = new RadioButton();
            radioMale = new RadioButton();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(283, 203);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 23);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(147, 203);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 23);
            btnReset.TabIndex = 22;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(11, 203);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 23);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(82, 164);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(79, 23);
            txtScore.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 167);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 19;
            label5.Text = "Score:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 120);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 18;
            label4.Text = "years old";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(82, 117);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(65, 23);
            txtAge.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 120);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 16;
            label3.Text = "Age:";
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(153, 68);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(63, 19);
            radioFemale.TabIndex = 15;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(82, 68);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(51, 19);
            radioMale.TabIndex = 14;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 70);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 13;
            label2.Text = "Gender:";
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(329, 23);
            txtName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 11;
            label1.Text = "Name:";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 247);
            Controls.Add(btnEdit);
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
            Name = "UpdateForm";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnReset;
        private Button btnClose;
        private TextBox txtScore;
        private Label label5;
        private Label label4;
        private TextBox txtAge;
        private Label label3;
        private RadioButton radioFemale;
        private RadioButton radioMale;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}