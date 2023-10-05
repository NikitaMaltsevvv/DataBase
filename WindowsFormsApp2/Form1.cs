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
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sqlConnection= new SqlConnection(ConfigurationManager.ConnectionStrings["zachet"].ConnectionString);

            sqlConnection.Open();

            if(sqlConnection.State == ConnectionState.Open) { MessageBox.Show("Подключение установлено!"); }

        }

        private void договораАбонентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Договора договор = new Договора();
            договор.ShowDialog();
        }

        private void тарифToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Тарифы тариф = new Тарифы();
            тариф.ShowDialog();
        }

        private void филлиалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Филлиалы филлиал = new Филлиалы();
            филлиал.ShowDialog();
        }

        private void справочникДомовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СправочникДомов справдом = new СправочникДомов();
            справдом.ShowDialog();
        }

        private void разовыеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            РазовыеУслуги разусл = new РазовыеУслуги();
            разусл.ShowDialog();
        }

        private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Платежи платеж = new Платежи();
            платеж.ShowDialog();
        }

        private void сальдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сальдо сальда = new Сальдо();
            сальда.ShowDialog();
        }

        private void улицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СправочникУлиц справулиц = new СправочникУлиц();
            справулиц.ShowDialog();
        }

        private void видыУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СправочникУслуг справусл = new СправочникУслуг();
            справусл.ShowDialog();
        }

        private void кодыЕдиницИзмеренияУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            СправочникЕдиниц справед = new СправочникЕдиниц();
            справед.ShowDialog();
        }
    }
}
