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
    public partial class Form1 : Form
    {
        string nameTextbox;
        string passwortTextbox;



        public Form1()
        {
            InitializeComponent();
        }



     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

      

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameTextbox = textBox1.Text;
            passwortTextbox = textBox2.Text;
            if (nameTextbox.ToLower() == "roni" && passwortTextbox == "123")
            {
                //Man könnte hier auch switch case nutzen, wenn noch mehr Benutzen hinzufügen möchte. 
                
                Form2 eingang = new Form2();
                
                eingang.Show();


                this.Hide();

            }else if (nameTextbox.ToLower() == "numan" && passwortTextbox == "1234")
            {
                //Man könnte hier auch switch case nutzen, wenn noch mehr Benutzen hinzufügen möchte. 
                
                Form2 eingang = new Form2();
                
                eingang.Show();


                this.Hide();

            }else if (nameTextbox.ToLower() == "danny" && passwortTextbox == "1235")
            {
                //Man könnte hier auch switch case nutzen, wenn noch mehr Benutzen hinzufügen möchte. 
                
                Form2 eingang = new Form2();
                
                eingang.Show();


                this.Hide();

            }else if (nameTextbox.ToLower() == "jim" && passwortTextbox == "1238")
            {
                //Man könnte hier auch switch case nutzen, wenn noch mehr Benutzen hinzufügen möchte. 
                
                Form2 eingang = new Form2();
                
                eingang.Show();


                this.Hide();

            }else if (nameTextbox.ToLower() == "daniel" && passwortTextbox == "1223")
            {
                //Man könnte hier auch switch case nutzen, wenn noch mehr Benutzen hinzufügen möchte. 
                
                Form2 eingang = new Form2();
                
                eingang.Show();


                this.Hide();

            }
           

            else
            {
                MessageBox.Show("You wrote something Wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Alinuman42/Sas-Project");
        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult result =   MessageBox.Show("Do you want to close Application?","Inform",MessageBoxButtons.YesNo,MessageBoxIcon.Question);   


            if(result == DialogResult.Yes)
            {
                
                Application.Exit();

            }

            else
            {
               
            }

        }

        private void button_visible_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button_notvisible.BringToFront();
                textBox2.PasswordChar = '*';
            }



        }

        private void button_notvisible_Click(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar == '*')
            {
                button_visible.BringToFront();  
                textBox2.PasswordChar = '\0';

            }
        }
    }
}
