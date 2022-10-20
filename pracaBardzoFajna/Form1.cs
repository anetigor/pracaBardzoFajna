namespace pracaBardzoFajna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            textBox1.Enabled = false;
            checkBox1.Checked = true;
           
            

        }
        public int los = 0;
        public int myliczba = 0;
        public int nrpr = 0;
        public int high = 0;
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            if (radioButton1.Checked)
            {
                 los = rand.Next(0, 1000);
            }else if (radioButton2.Checked)
            {
                los =rand.Next(0, 100);
            }
            else if (radioButton3.Checked)
            {
                los = rand.Next(0, 10);
            }
            nrpr = 1;
            label1.Text = "nr próby: " + nrpr;
            button1.Enabled = false;
            panel1.BackColor = Control.DefaultBackColor;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            button2.Enabled = true;
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

                try
            {

                myliczba = Convert.ToInt32(textBox1.Text);
            }
            catch(Exception myliczba)
            {
                MessageBox.Show("B³¹d: " + myliczba.Message);
                textBox1.Clear();

            }
            int high = 0;

            if (checkBox1.Enabled == true)
            {
                if (myliczba < los)
                {
                    label2.Text = "Wiêksza";
                    nrpr++;
                    label1.Text = "nr próby: " + nrpr;
                }
                else if (myliczba > los)
                {
                    label2.Text = "mniejsza";
                    nrpr++;
                    label1.Text = "nr próby: " + nrpr;
                }
                else if (myliczba == los)
                {
                    label4.Text = "ZWYCIÊSTWOOOO";
                    if (high < nrpr)
                    {
                        high = nrpr;
                    }
                    label3.Text = "Najmniejsza liczba prób: " + high;
                }else if(myliczba != los)
                {
                    label4.Text = "Sróbuj ponownie";
                }
            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            los = 0;
            nrpr = 0;
            label2.Text = "brak";
            textBox1.Text = "";
            label1.Text = "nr próby:";
            button1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}