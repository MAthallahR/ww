using System.Data;



namespace oo

{

    public partial class todoList : Form

    {

        public todoList()

        {

            InitializeComponent();

        }



        DataTable todoTable = new DataTable();

        bool isEditing = false;



        private void todoList_Load(object sender, EventArgs e)

        {

            // Membuat kolum

            todoTable.Columns.Add("Judul");

            todoTable.Columns.Add("Deskripsi");



            // Mengambil data grid dari data source

            todoListView.DataSource = todoTable;



        }



        private void btnTambah_Click(object sender, EventArgs e)

        {

            txtboxJudul.Text = "";

            txtboxDeskripsi.Text = "";

            isEditing = false;

        }



        private void btnEdit_Click(object sender, EventArgs e)

        {

            isEditing = true;



            // Mengisi kedua txtbox dengan data dari table



            txtboxJudul.Text = todoTable.Rows[todoListView.CurrentCell.RowIndex].ItemArray[0].ToString();

            txtboxDeskripsi.Text = todoTable.Rows[todoListView.CurrentCell.RowIndex].ItemArray[1].ToString();



        }



        private void btnDelete_Click(object sender, EventArgs e)

        {

            try

            {

                todoTable.Rows[todoListView.CurrentCell.RowIndex].Delete();

            }

            catch (Exception ex)

            {

                Console.WriteLine("Error " + ex);

            }

        }



        private void btnSave_Click(object sender, EventArgs e)

        {

            if (isEditing)

            {

                todoTable.Rows[todoListView.CurrentCell.RowIndex]["Judul"] = txtboxJudul.Text;

                todoTable.Rows[todoListView.CurrentCell.RowIndex]["Deskripsi"] = txtboxDeskripsi.Text;

            }

            else

            {

                todoTable.Rows.Add(txtboxJudul.Text, txtboxDeskripsi.Text);

            }

            txtboxJudul.Text = "";

            txtboxDeskripsi.Text = "";

            isEditing = false;

        }

    }

}
