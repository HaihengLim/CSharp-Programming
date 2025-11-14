using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();

            btnReset.Click += (sender, e) =>
            {
                txtName.Clear();
                txtGender.Clear();
                txtAge.Clear();
                txtName.Focus();
            };
            btnSubmit.Click += OnClickNew;
        }

        private void OnClickNew(object? sender, EventArgs e)
        {
            var name = txtName.Text;
            var gender = txtGender.Text;
            
            if(byte.TryParse(txtAge.Text, out byte age) == false)
            {
                MessageBox.Show("Invalid input of Age!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string data = $"{name}/{gender}/{age}";

            Person.Create(data);
        }
    }
}
