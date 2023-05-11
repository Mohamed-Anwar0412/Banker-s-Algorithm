namespace Banker_s_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numProc = int.Parse(textBox1.Text);
            int numRes = int.Parse(textBox2.Text);

            Data dataForm = new Data(numProc, numRes);
            this.Hide();
            dataForm.ShowDialog();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }
    }
}