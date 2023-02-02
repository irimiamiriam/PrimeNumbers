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
            if (!IsNumber && !string.IsNullOrEmpty(numere.Text))
            {
                invalid.Visible = true;
                semn.Visible = true; ;
            }

        }

        
        async void Buton_Click(object sender, EventArgs e)
        {
            
            bool IsNumber = Int32.TryParse(numere.Text, out res);
            int d = 1 ;
            if (IsNumber)
            {

                for (int j = 1; j <= res/ 2; j++)
                {
                    if (res % j == 0) { d++; }
                }
                if (d==2)
                {
                    this.BackColor = System.Drawing.Color.Green; numere.BackColor = this.BackColor;


                }
                else { this.BackColor = System.Drawing.Color.Crimson; numere.BackColor = this.BackColor; }
                await Task.Delay(2000); this.BackColor = System.Drawing.Color.SlateGray;
            }numere.BackColor = this.BackColor;
            }

        private void PrimeNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)Keys.Enter ) { Buton.PerformClick(); }
        }
    }

        
    
        

        
}