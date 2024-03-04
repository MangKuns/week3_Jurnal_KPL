namespace Jurnal_MOD__3__1302220013_Rizky_Kusuma_Nugraha
{
    public partial class Form1 : Form
    {
        static int temp = 0;
        static string output = "";
        static int hasil = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tombol1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol1.Text;
            output = output + tombol1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tombolPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombolPlus.Text;
            temp = int.Parse(output);
            hasil = hasil + temp;
            temp = 0;
            output = "";
        }

        private void tombolSD_Click(object sender, EventArgs e)
        {
            temp = int.Parse(output);
            hasil = hasil + temp;
            string keluar = Convert.ToString(hasil);
            textBox1.Text = keluar;
            temp = 0;
            output = "0";
        }

        private void tombol2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol2.Text;
            output = output + tombol2.Text;
        }

        private void tombol3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol3.Text;
            output = output + tombol3.Text;
        }

        private void tombol4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol4.Text;
            output = output + tombol4.Text;
        }

        private void tombol5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol5.Text;
            output = output + tombol5.Text;
        }

        private void tombol6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol6.Text;
            output = output + tombol6.Text;
        }

        private void tombol7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol7.Text;
            output = output + tombol7.Text;
        }

        private void tombol8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol8.Text;
            output = output + tombol8.Text;
        }

        private void tombol9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol9.Text;
            output = output + tombol9.Text;
        }

        private void tombol0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tombol0.Text;
            output = output + tombol0.Text;
        }
    }
}
