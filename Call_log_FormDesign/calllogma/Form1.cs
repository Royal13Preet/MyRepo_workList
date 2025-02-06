namespace calllogma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox11.Text.Length > 0)
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox11.Focus();
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                if(textBox2.Text.Length > 0)
                {
                    textBox9.Focus();
                }
                else
                {
                    textBox2.Focus();
                }
            }
        }
    }
}
