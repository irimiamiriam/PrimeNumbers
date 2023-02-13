using System;
using System.Globalization;
using System.Windows.Forms.VisualStyles;

namespace PrimeNumbers
{
    public partial class PrimeNumbers : Form
    {
        int res;
        public PrimeNumbers()
        {
            InitializeComponent();
            numere.BackColor = this.BackColor;

        }

        private void numere_TextChanged(object sender, EventArgs e)
        {

            invalid.Visible = false;
            semn.Visible = false;
            bool IsNumber = Int32.TryParse(numere.Text, out res);
            if (!IsNumber && !string.IsNullOrWhiteSpace(numere.Text))
            {
                invalid.Visible = true;
                semn.Visible = true;
                this.BackColor = Color.Yellow; numere.BackColor = this.BackColor;

            }
            else this.BackColor = Color.SlateGray; numere.BackColor = this.BackColor;

        }


        async void Buton_Click(object sender, EventArgs e)
        {

            bool IsNumber = Int32.TryParse(numere.Text, out res);
            int d = 1;
            if (IsNumber)
            {

                for (int j = 1; j <= res / 2; j++)
                {
                    if (res % j == 0) { d++; }
                }
                if (d == 2)
                {
                    this.BackColor = Color.Green; numere.BackColor = this.BackColor;


                }
                else { this.BackColor = Color.Crimson; numere.BackColor = this.BackColor; }
                await Task.Delay(2000); this.BackColor = Color.SlateGray;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Nu s-a introdus un numar natural!");
                if (dr == DialogResult.OK) { numere.Text = ""; }

            }
            numere.BackColor = this.BackColor;
        }

        private void PrimeNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { Buton.PerformClick(); }
        }
    }
}