using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxproje
{
    public partial class Form1 : Form
    {
        char[][] characters; //global olarak tanumlamamızın sebebi hem form1load dan hem buttondan erişebilmek içindir.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rome");
            listBox1.Items.Add("Firenze");
            listBox1.Items.Add("Milan");
            listBox1.Items.Add("Barcelona");
            listBox1.Items.Add("Paris");
            listBox1.Items.Add("Brussels");
            listBox1.Items.Add("Bruges");
            listBox1.Items.Add("Amsterdam");

            int total, number;
            total = listBox1.Items.Count;

            characters = new char[total][];
            String row;

            for(int i=0; i<=total-1; i++) //satır
            {
                row = listBox1.Items[i].ToString();
                number = row.Length;
                characters[i] = new char[number];
                for(int j=0; j<=number-1; j++) //sütun
                {
                    characters[i][j] = row[j];
                }

            }





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row, column;
            row = Convert.ToInt32(textBox1.Text);
            column = Convert.ToInt32(textBox2.Text);

            this.Text = characters[row][column].ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
