using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to close this form?",
                "Information",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtScore.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try {
                ConnectionHelper ch = new();
                MongoClient conn = ch.GetConnection();

                var database = conn.GetDatabase("dbM6");
                var collection = database.GetCollection<Student>("students");

                string name = txtName.Text;
                string gender = radioMale.Checked ? "Male" : "Female";
                byte age = Convert.ToByte(txtAge.Text);
                int score = Convert.ToInt32(txtScore.Text);

                await collection.InsertOneAsync(new Student {
                    name = name,
                    gender = gender,
                    age = age,
                    score = score
                });

                MessageBox.Show(
                    "Student is added successfully!", 
                    "Success", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                );
            } catch(Exception ex){
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
