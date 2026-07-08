using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsApp1
{
    public partial class BizContacts : Form
    {
        string connString = @"Data Source=ARSLAN-HP-PC\SQLEXPRESS;Initial Catalog=AddressBook;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlCommandBuilder commandBuilder; // declare a new sql command builder object
        SqlConnection conn;
        string selectionStatement = "Select * from BizContacts";

        public BizContacts()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BizContacts_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; // First item in combobox is selected when the form loads
            dataGridView1.DataSource = bindingSource1;

            // This calls GetData and successfully fills your grid using the connection string above
            GetData("Select * from Bizcontacts");

            /* * NOTE: Commented out the Entity Framework code below because it conflicts 
             * with your GetData method and targets a different database (BizContacts vs AddressBook).
             *
            try
            {
                using (var myDbContext = new AppDbContext())
                {
                    var myData = myDbContext.Contacts.ToList();
                    bindingSource1.DataSource = myData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
            */
        }

        // FIX 1: Changed parameter 'v' to 'selectCommand' to clear the context error
        // FIX 2: Added the missing 'catch' block to resolve "Expected catch or finally"
        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.Columns[0].ReadOnly = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*private void btnAdd_Click(object sender, EventArgs e)
        {

        }*/
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string insert = @"insert into BizContacts(Date_Added, Company, Website, Title, First_Name, Last_Name, Address,
                                City,State,Postal_Code,Mobile,Notes)
                                values(@Date_Added, @Company, @Website, @Title, @First_Name, @Last_Name, @Address,
                                @City, @State, @Postal_Code, @Mobile, @Notes)";

            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();//open the connection
                    SqlCommand command = new SqlCommand(insert, conn);//create the new sql command object
                    command.Parameters.AddWithValue(@"Date_Added", dateTimePicker1.Value.Date);//using sllow disposing of low level resources
                    command.Parameters.AddWithValue(@"Company", CompanyName.Text);
                    command.Parameters.AddWithValue(@"Website", Website.Text);
                    command.Parameters.AddWithValue(@"Title", txtTitle.Text);
                    command.Parameters.AddWithValue(@"First_Name", txtFName.Text);
                    command.Parameters.AddWithValue(@"Last_Name", txtLName.Text);
                    command.Parameters.AddWithValue(@"Address", txtAddress.Text);
                    command.Parameters.AddWithValue(@"City", txtCity.Text);
                    command.Parameters.AddWithValue(@"State", txtState.Text);
                    command.Parameters.AddWithValue(@"Postal_code", txtPLZ.Text);
                    command.Parameters.AddWithValue(@"Mobile", MobileNumber.Text);
                    command.Parameters.AddWithValue(@"Notes", txtNotes.Text);

                    command.ExecuteNonQuery(); //put things into the table
                }

                GetData("selectionStatement");
                dataGridView1.Update();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            try
            {
                bindingSource1.EndEdit();
                dataAdapter.Update(table);
                MessageBox.Show("Update Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string value = row.Cells["ID"].Value.ToString();
            string fname = row.Cells["First_Name"].Value.ToString();
            string lname = row.Cells["Last_Name"].Value.ToString();
            DialogResult result = MessageBox.Show("Do you really want to delte " +  fname+ "" +lname+ "record"+value,"Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //string deleteState=@"Delete from BizContacts where if = '"+value+"'";
            string deleteState = @"Delete from BizContacts where ID = '" + value + "'";

            if (result == DialogResult.Yes)
            {
                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(deleteState, conn);
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }


    /*
    // This is your data model class that maps your database columns to C# properties
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    
    public class AppDbContext : DbContext
    {
        // FIX 3: Changed DbSet from <BizContacts> (the Form) to <Contact> (the Data Class)
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BizContacts;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
    */


}