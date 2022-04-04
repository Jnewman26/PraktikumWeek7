using System;
using System.Windows.Forms;

namespace PraktikumWeek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            string simpanKalimat = textBoxInput.Text.ToUpper();
            char[] charArr = simpanKalimat.ToCharArray();
            char sebelum = Convert.ToChar(textBoxMasukan.Text.ToUpper());
            char sesudah = Convert.ToChar(textBoxMenjadi.Text.ToUpper());

            int temp_sebelum = Convert.ToInt32(sebelum);
            int temp_sesudah = Convert.ToInt32(sesudah);
            int selisih = Math.Abs(temp_sesudah - temp_sebelum);

            string output = "";

            foreach (char c in charArr)
            {
                int temp = Convert.ToInt32(c) + selisih;
                if (temp == 115)
                {
                    temp = 65;
                }
                else if (temp > 90)
                {
                    temp = temp - 26;
                }
                output = output + Convert.ToChar(temp).ToString();
            }
            labelOutput.Text = output.ToString();
        }
    }
}
