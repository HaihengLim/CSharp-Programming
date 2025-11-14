namespace WinFormsApp4;

public partial class MainForm : Form
{
    List<Person> _per = new List<Person>();

    const string DATA_FILE = "People.txt";
    public MainForm()
    {
        InitializeComponent();

        Person.Created += (per) =>
        {
            _per.Add(per);
            AddPersonToView(per);
        };

        LoadPeople();
        btnReload.Click += (_, _) => { ButtonReload_Click(); };

        btnNew.Click += (sender, e) => { ButtonNew_Click(); };
        btnEdit.Click += (sender, e) =>
        {
            if (dgvPeople.CurrentRow == null) return;
            var editPeople = _per[dgvPeople.CurrentRow.Index];
            var frm = new UpdateForm(editPeople);
            frm.Updated += OnPeopleUpdated;
            frm.Show();
        };

        btnDelete.Click += Delete_Row;
    }

    private void OnPeopleUpdated(Person per)
    {
        if (dgvPeople.CurrentRow == null) return;
        DataGridViewRow? rowEffected = null;

        if (dgvPeople.CurrentRow.Cells[0].Value.Equals(per.Id))
        {
            rowEffected = dgvPeople.CurrentRow;
            dgvPeople.CurrentRow.SetValues(per.Id, per.Name, per.Gender, per.Age);
        } else
        {
            foreach(DataGridViewRow row in dgvPeople.Rows)
            {
                if (row.Cells[0].Value.Equals(per.Name))
                {
                    rowEffected = row;
                    row.SetValues(per.Name, per.Gender, per.Age);
                    break;
                }
            }
        }
        ViewOverallInfo();
    }

    private void LoadPeople()
    {
        _per.Clear();
        dgvPeople.Rows.Clear();

        if (!File.Exists(DATA_FILE)) return;

        string[] lines = File.ReadAllLines(DATA_FILE);

        foreach (string line in lines)
        {
            var trimmed = line?.Trim();
            if (string.IsNullOrEmpty(trimmed)) continue;

            Person.Create(trimmed);
        }

        ViewOverallInfo();
    }

    private void ViewOverallInfo()
    {
        txtCount.Text = _per.Count.ToString();
        txtMaxAge.Text = _per.Max(x => x.Age).ToString();
    }

    private void AddPersonToView(Person p)
    {
        dgvPeople.Rows.Add(p.Id, p.Name, p.Gender.ToString(), p.Age);
        ViewOverallInfo();
    }

    private void ButtonReload_Click()
    {
        LoadPeople();
        ViewOverallInfo();
    }

    private void ButtonNew_Click()
    {
        var frm = new NewForm();
        frm.Show();
    }

    private void Delete_Row(object? sender, EventArgs e)
    {
        if (dgvPeople.CurrentRow == null) return;

        int RowIndex = dgvPeople.CurrentRow.Index;

        if (RowIndex < 0 || RowIndex >= _per.Count) return;

        var PersonToDelete = _per[RowIndex];
        var result = MessageBox.Show(
            $"Are you sure you want ot delete {PersonToDelete.Name}?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (result != DialogResult.Yes) return;

        _per.RemoveAt(RowIndex);

        dgvPeople.Rows.RemoveAt(RowIndex);

        ViewOverallInfo();
    }
}
