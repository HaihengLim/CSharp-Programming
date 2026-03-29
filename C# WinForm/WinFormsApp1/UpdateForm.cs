using MongoDB.Driver;
using MongoDB.Bson;

namespace WinFormsApp1
{
    public partial class UpdateForm : Form
    {
        private ObjectId selectedId;
        public UpdateForm()
        {
            InitializeComponent();
        }

        public UpdateForm(ObjectId _id, string name, string gender, byte age, int score) : this()
        {
            txtName.Text = name;
            radioMale.Checked = gender == "Male";
            radioFemale.Checked = gender != "Male";
            txtAge.Text = Convert.ToString(age);
            txtScore.Text = Convert.ToString(score);
            selectedId = _id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to close this from?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
            txtAge.Text = "";
            txtScore.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private async void UpdateDataGridView(){
            try
            {
                ConnectionHelper ch = new();
                MongoClient conn = ch.GetConnection();
                var database = conn.GetDatabase("dbM6");
                var collection = database.GetCollection<Student>("students");
                string name = txtName.Text;
                string gender = radioMale.Checked ? "Male" : "Female";
                byte age = Convert.ToByte(txtAge.Text);
                int score = Convert.ToInt32(txtScore.Text);
                
                var filter = Builders<Student>.Filter.Eq("_id", selectedId);
                var update = Builders<Student>.Update
                    .Set(s => s.name, name)
                    .Set(s => s.gender, gender)
                    .Set(s => s.age, age)
                    .Set(s => s.score, score);
                await collection.UpdateOneAsync(filter, update);

                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
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
