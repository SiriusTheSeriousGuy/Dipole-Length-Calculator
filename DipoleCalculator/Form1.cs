using System.Globalization;
namespace DipoleCalculator
{
    public partial class Form1 : Form
    {
        private string radioOpt = "MHZ";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                dipoleLegLength.Clear();
                wavelength.Clear();
                //MessageBox.Show(czestotliwosc.Text);
                double freq = Convert.ToDouble(numericUpDown1.Text);
                double odp = Math.Round(((150 * 0.95) / freq), 3);
                if (radioOpt == "MHZ")
                {
                    textBox1.AppendText(Convert.ToString(odp));
                    dipoleLegLength.AppendText(Convert.ToString(odp / 2) + " m");
                    double waveL = 299792458 / (freq * 1000000);
                    double wave = Math.Round(waveL, 2);
                    wavelength.AppendText(Convert.ToString(Math.Round(wave)) + " m");
                }
                else if (radioOpt == "GHZ")
                {
                    odp = Math.Round(odp / 10, 4);
                    textBox1.AppendText(Convert.ToString(odp) + " cm");
                    dipoleLegLength.AppendText(Convert.ToString(odp / 2) + " cm");
                    double waveL = 299792458 / (freq * 1000000000);
                    waveL = Math.Round(waveL, 2);
                    wavelength.AppendText(Convert.ToString(waveL) + " m");
                }
                else if (radioOpt == "KHZ")
                {
                    textBox1.AppendText(Convert.ToString(odp * 1000) + " m");
                    dipoleLegLength.AppendText(Convert.ToString((odp / 2) * 1000) + " m");
                    double waveL = 299792458 / (freq * 1000);
                    waveL = Math.Round(waveL, 2);
                    wavelength.AppendText(Convert.ToString(Math.Round(waveL)) + " m");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(ghzRadio.Checked){
                radioOpt = "GHZ";
            }
        }

        private void mhzRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (mhzRadio.Checked)
            {
                radioOpt = "MHZ";
            }
        }

        private void khzRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (khzRadio.Checked)
            {
                radioOpt = "KHZ";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}