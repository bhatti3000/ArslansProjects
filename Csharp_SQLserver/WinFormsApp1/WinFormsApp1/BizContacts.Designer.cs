namespace WinFormsApp1
{
    partial class BizContacts
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            Website = new TextBox();
            label3 = new Label();
            CompanyName = new TextBox();
            label4 = new Label();
            txtPLZ = new TextBox();
            label5 = new Label();
            txtState = new TextBox();
            label6 = new Label();
            txtCity = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            txtLName = new TextBox();
            label9 = new Label();
            txtFName = new TextBox();
            label10 = new Label();
            txtNotes = new TextBox();
            label11 = new Label();
            MobileNumber = new TextBox();
            label12 = new Label();
            btnEdit = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            label13 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(110, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 283);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Search";
            // 
            // Website
            // 
            Website.Location = new Point(110, 253);
            Website.Name = "Website";
            Website.Size = new Size(100, 23);
            Website.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 254);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Website";
            // 
            // CompanyName
            // 
            CompanyName.Location = new Point(110, 223);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(100, 23);
            CompanyName.TabIndex = 7;
            CompanyName.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 225);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Company";
            // 
            // txtPLZ
            // 
            txtPLZ.Location = new Point(110, 189);
            txtPLZ.Name = "txtPLZ";
            txtPLZ.Size = new Size(100, 23);
            txtPLZ.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 190);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 8;
            label5.Text = "PLZ";
            // 
            // txtState
            // 
            txtState.Location = new Point(110, 157);
            txtState.Name = "txtState";
            txtState.Size = new Size(100, 23);
            txtState.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 161);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 10;
            label6.Text = "State:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(110, 131);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 132);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 12;
            label7.Text = "City";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(110, 101);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 103);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 14;
            label8.Text = "Address";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(110, 74);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(100, 23);
            txtLName.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 74);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 16;
            label9.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(110, 45);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(100, 23);
            txtFName.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 45);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 18;
            label10.Text = "First Name";
            label10.Click += label10_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(324, 103);
            txtNotes.MaximumSize = new Size(400, 300);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(400, 166);
            txtNotes.TabIndex = 21;
            txtNotes.TextChanged += textBox10_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(235, 105);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 20;
            label11.Text = "Notes";
            // 
            // MobileNumber
            // 
            MobileNumber.Location = new Point(324, 11);
            MobileNumber.Name = "MobileNumber";
            MobileNumber.Size = new Size(403, 23);
            MobileNumber.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(235, 14);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 22;
            label12.Text = "Mobile";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(511, 283);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 24;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(406, 283);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(609, 283);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(700, 283);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(235, 63);
            label13.Name = "label13";
            label13.Size = new Size(74, 15);
            label13.TabIndex = 28;
            label13.Text = "Date Entered";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(324, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "First Name", "Last Name", "Company" });
            comboBox1.Location = new Point(244, 283);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 30;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(110, 283);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(889, 187);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellEndEdit += dataGridView1_CellContentClick;
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // BizContacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 520);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label13);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(btnEdit);
            Controls.Add(MobileNumber);
            Controls.Add(label12);
            Controls.Add(txtNotes);
            Controls.Add(label11);
            Controls.Add(txtFName);
            Controls.Add(label10);
            Controls.Add(txtLName);
            Controls.Add(label9);
            Controls.Add(txtAddress);
            Controls.Add(label8);
            Controls.Add(txtCity);
            Controls.Add(label7);
            Controls.Add(txtState);
            Controls.Add(label6);
            Controls.Add(txtPLZ);
            Controls.Add(label5);
            Controls.Add(CompanyName);
            Controls.Add(label4);
            Controls.Add(Website);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "BizContacts";
            Text = "BizContacts";
            Load += BizContacts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private TextBox Website;
        private Label label3;
        private TextBox CompanyName;
        private Label label4;
        private TextBox txtPLZ;
        private Label label5;
        private TextBox txtState;
        private Label label6;
        private TextBox txtCity;
        private Label label7;
        private TextBox txtAddress;
        private Label label8;
        private TextBox txtLName;
        private Label label9;
        private TextBox txtFName;
        private Label label10;
        private TextBox txtNotes;
        private Label label11;
        private TextBox MobileNumber;
        private Label label12;
        private Button btnEdit;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnDelete;
        private Label label13;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
    }
}