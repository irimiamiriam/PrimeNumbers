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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void PrimeNumbers_Load(object sender, EventArgs e)
        {

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
                string tip;
               
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0) { d++; }
                }
                if (d == 2)
                {
                    this.BackColor = System.Drawing.Color.Green; numere.BackColor = this.BackColor;
                    tip = " -prim";

                }
                else { this.BackColor = System.Drawing.Color.Crimson; numere.BackColor = this.BackColor; tip = " -neprim";  }
                await Task.Delay(2000); this.BackColor = System.Drawing.Color.SlateGray;
                Clipboard.SetText(numere.Text);
                history.Text = history.Text+ Clipboard.GetText()+tip + "\r\n" ;
            }numere.BackColor = this.BackColor;
        }

        private void invalid_Click(object sender, EventArgs e)
        {

        }

   

        private void history_Click(object sender, EventArgs e)
        {

        }
    }
        

        
}