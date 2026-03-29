using MongoDB.Driver;
using MongoDB.Bson;

namespace WinFormsApp1;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshDataGridView();
        MessageBox.Show("Database connected successfully!", "Successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        CreateForm cf = new();
        cf.Show();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        RemoveRowDataGridView();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        EditRowDataGridView();
    }

    private void RefreshDataGridView()
    {
        try
        {
            ConnectionHelper ch = new();
            MongoClient conn = ch.GetConnection();

            var database = conn.GetDatabase("dbM6");
            var collection = database.GetCollection<Student>("students");

            var filter = Builders<Student>.Filter.Empty;

            List<Student> students = collection.Find(filter).ToList();

            BindingSource bs = new();
            bs.DataSource = students;
            dgvStudent.DataSource = bs;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error > " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void RemoveRowDataGridView()
    {
        try
        {
            if (dgvStudent.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select any row for delete",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int rowIndex = dgvStudent.CurrentRow!.Index;
            ObjectId id = ObjectId.Parse(dgvStudent.CurrentRow.Cells["_id"].Value!.ToString());

            ConnectionHelper ch = new();
            MongoClient conn = ch.GetConnection();

            var database = conn.GetDatabase("dbM6");
            var collection = database.GetCollection<Student>("students");
            var filter = Builders<Student>.Filter.Eq("_id", id);

            await collection.FindOneAndDeleteAsync<Student>(filter);

            DialogResult result = MessageBox.Show(
                $"Do you want to delete row: {rowIndex + 1}?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                dgvStudent.Rows.RemoveAt(rowIndex);
                MessageBox.Show(
                    $"Student in row {rowIndex + 1} is removed!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
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

    private async void EditRowDataGridView(){
        try
        {
            if (dgvStudent.CurrentRow == null)
            {
                MessageBox.Show("");
                return;
            }

            int rowIndex = dgvStudent.CurrentRow.Index;
            ObjectId id = ObjectId.Parse(dgvStudent.CurrentRow.Cells["_id"].Value!.ToString());
            string name = (string)dgvStudent.CurrentRow.Cells["name"].Value!;
            string gender = (string)dgvStudent.CurrentRow.Cells["gender"].Value!;
            byte age = Convert.ToByte(dgvStudent.CurrentRow.Cells["age"].Value);
            int score = Convert.ToInt32(dgvStudent.CurrentRow.Cells["score"].Value);

            ConnectionHelper ch = new();
            MongoClient conn = ch.GetConnection();

            UpdateForm uf = new(id, name, gender, age, score);
            uf.Show();
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
