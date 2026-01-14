namespace oo
{
    partial class todoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblJudul = new Label();
            txtboxJudul = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtboxDeskripsi = new TextBox();
            btnTambah = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            todoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)todoListView).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(344, 9);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(92, 21);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "To Do List";
            // 
            // txtboxJudul
            // 
            txtboxJudul.Location = new Point(12, 79);
            txtboxJudul.Name = "txtboxJudul";
            txtboxJudul.Size = new Size(624, 23);
            txtboxJudul.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 55);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 4;
            label1.Text = "Judul";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 122);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 6;
            label2.Text = "Deskripsi";
            // 
            // txtboxDeskripsi
            // 
            txtboxDeskripsi.Location = new Point(12, 146);
            txtboxDeskripsi.Name = "txtboxDeskripsi";
            txtboxDeskripsi.Size = new Size(624, 23);
            txtboxDeskripsi.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(657, 195);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(131, 40);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(657, 269);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 40);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(657, 352);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(657, 428);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 40);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // todoListView
            // 
            todoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todoListView.Location = new Point(12, 195);
            todoListView.Name = "todoListView";
            todoListView.Size = new Size(624, 273);
            todoListView.TabIndex = 7;
            // 
            // todoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(todoListView);
            Controls.Add(label2);
            Controls.Add(txtboxDeskripsi);
            Controls.Add(label1);
            Controls.Add(txtboxJudul);
            Controls.Add(lblJudul);
            Name = "todoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            Load += todoList_Load;
            ((System.ComponentModel.ISupportInitialize)todoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private TextBox txtboxJudul;
        private Label label1;
        private Label label2;
        private TextBox txtboxDeskripsi;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView todoListView;
    }
}
