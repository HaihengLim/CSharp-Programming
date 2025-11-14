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
    public partial class UpdateForm : Form
    {
        public event Action<Person>? Updated;
        private Person _edit;

        public UpdateForm(Person edit)
        {
            InitializeComponent();
            _edit = edit;
            ViewRec();

            btnReset.Click += (_, e) => ViewRec();
            btnUpdate.Click += OnClickUpdate;
        }

        private void OnClickUpdate(object? sender, EventArgs e)
        {
            string name = txtName.Text;
            
            if(!Enum.TryParse<Gender>(txtGender.Text, true, out Gender gender))
            {
                MessageBox.Show("Invalid input of gender", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(byte.TryParse(txtAge.Text, out byte age) == false)
            {
                MessageBox.Show("Invalid input of age", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _edit.Name = name;
            _edit.Gender = gender;
            _edit.Age = age;

            Updated?.Invoke(_edit);

            this.Close();
        }

        private void ViewRec()
        {
            txtName.Text = _edit.Name.ToString();
            txtGender.Text = _edit.Gender.ToString();
            txtAge.Text = _edit.Age.ToString();
        }
    }
}
