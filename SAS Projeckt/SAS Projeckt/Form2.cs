using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAS_Projeckt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            Form form1 = new Form();
            Form3 form3 = new Form3();
            form3.Show();

            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //  dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            //Hier ist bug wenn der benutzer nichts gibt.
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Bitte, erste Zeile auswählen!");


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Genre = textBox2.Text;
            string Producer = textBox3.Text;
            string Actor = textBox4.Text;
            string ID = textBox5.Text;
            string Public = textBox6.Text;
            string Date = textBox7.Text;


            if (Name.Length > 0 && Genre.Length > 0 && Producer.Length > 0 && Actor.Length > 0 && ID.Length > 0 && Public.Length > 0 && Date.Length > 0)
            {
                dataGridView1.Rows.Add(Name, Genre, Producer, Actor, ID, Public, Date);
            }
            else
            {
                MessageBox.Show("Sie sollen alle Kätschen ausfüllen!");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Genre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Producer = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string Actor = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string ID = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string Public = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string Date = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            textBox1.Text = Name;
            textBox2.Text = Genre;
            textBox3.Text = Producer;
            textBox4.Text = Actor;
            textBox5.Text = ID;
            textBox6.Text = Public;
            textBox7.Text = Date;


        }

        private void d(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Genre = textBox2.Text;
            string Producer = textBox3.Text;
            string Actor = textBox4.Text;
            string ID = textBox5.Text;
            string Public = textBox6.Text;
            string Date = textBox7.Text;
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Es gibt kein Row, Sie sollen zuerst ein neues Row erstellen");
                return;
            }
            if (Name.Length == 0 || Genre.Length == 0 || Producer.Length == 0
                || Actor.Length == 0 || ID.Length == 0 || Public.Length == 0 || Date.Length == 0)
            {
                MessageBox.Show("Bitte, geben Sie alle kätschen eim Value!");
                return;
            }
            dataGridView1.CurrentRow.Cells[0].Value = Name;
            dataGridView1.CurrentRow.Cells[1].Value = Genre;
            dataGridView1.CurrentRow.Cells[2].Value = Producer;
            dataGridView1.CurrentRow.Cells[3].Value = Actor;
            dataGridView1.CurrentRow.Cells[4].Value = ID;
            dataGridView1.CurrentRow.Cells[5].Value = Public;
            dataGridView1.CurrentRow.Cells[6].Value = Date;
            MessageBox.Show("Sie haben das Row geändert");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            this.ControlBox = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie das Aplikation schließen?", "Inform", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result != DialogResult.Yes)
            {
              
                e.Cancel = true;
                return;
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}