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
    public partial class Form3 : Form
    {
        public Form3()
        {

            

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string myText = textBox1.Text;

            if (myText=="")
            {
                webBrowser1.Navigate("https://www.bing.com");
                webBrowser1.ScriptErrorsSuppressed = true;

            }

            else
            {
                webBrowser1.Navigate(myText);
                webBrowser1.ScriptErrorsSuppressed = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
