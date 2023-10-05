using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    
    public partial class Договора : Form
    {
        private SqlConnection nrthwndConnection = null;

        private string request;
        private SqlDataAdapter dataAdapter;
        DataSet dataSet;

        public Договора()
        {
            InitializeComponent();
            nrthwndConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["zachet"].ConnectionString);
            dataGridView1.ReadOnly = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  
            request = "SELECT * FROM RESULT WHERE NMB = " + textBox1.Text;
            dataAdapter = new SqlDataAdapter(request, nrthwndConnection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void Договора_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zachetDataSet1.RESULT". При необходимости она может быть перемещена или удалена.
            //this.rESULTTableAdapter.Fill(this.zachetDataSet1.RESULT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zachetDataSet1.RESULT". При необходимости она может быть перемещена или удалена

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            //adapter.Update(ds);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dataSet.Tables[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM RESULT WHERE NMB = @ID";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, nrthwndConnection);

            deleteCommand.Parameters.Add("@ID", SqlDbType.Int);

            dataAdapter.DeleteCommand = deleteCommand;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int idToDelete = (int)selectedRow.Cells[0].Value;

                dataAdapter.DeleteCommand.Parameters["@ID"].Value = idToDelete;

                dataGridView1.Rows.Remove(selectedRow);
                dataAdapter.Update(dataSet.Tables[0]); 
            }
        }
    }
}

