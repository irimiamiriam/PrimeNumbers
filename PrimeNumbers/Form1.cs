using System;
using System.Globalization;
using System.Windows.Forms.VisualStyles;

namespace PrimeNumbers
{   
    public partial class PrimeNumbers : Form
    {   
        bool pos = true;
        public PrimeNumbers()
        {
            InitializeComponent();
            numere.BackColor = this.BackColor;

        }

        private void numere_TextChanged(object sender, EventArgs e)
        {
            
            invalid.Visible = false;
            semn.Visible= false; 
            pos = true; 
            string text = numere.Text;
            for (int i = 0; i < text.Length; i++) { 
                if (!char.IsNumber(text[i]))
                {
                    pos = false;
                    invalid.Visible = true;
                    semn.Visible = true;
                    
                } }

          
            
        }

        async void Buton_Click(object sender, EventArgs e)
        {
            
            
            if (pos)
            {
                Button clickedButon = (Button)sender;
                int d = 1;
                long i = Convert.ToInt32(numere.Text);
                
               
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0) { d++; }
                }
                if (d == 2)
                {
                    this.BackColor = System.Drawing.Color.Green; numere.BackColor = this.BackColor;
                   

                }
                else { this.BackColor = System.Drawing.Color.Crimson; numere.BackColor = this.BackColor;   }
                await Task.Delay(2000); this.BackColor = System.Drawing.Color.SlateGray;
                
            }numere.BackColor = this.BackColor;
        }

        
    }
        

        
}