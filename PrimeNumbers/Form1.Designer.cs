namespace PrimeNumbers
{
    partial class PrimeNumbers
    {
        
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimeNumbers));
            this.numere = new System.Windows.Forms.TextBox();
            this.Buton = new System.Windows.Forms.Button();
            this.invalid = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.semn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // numere
            // 
            this.numere.BackColor = System.Drawing.Color.SlateGray;
            this.numere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numere.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numere.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.numere.Location = new System.Drawing.Point(133, 52);
            this.numere.Multiline = true;
            this.numere.Name = "numere";
            this.numere.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.numere.Size = new System.Drawing.Size(704, 72);
            this.numere.TabIndex = 0;
            this.numere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numere.TextChanged += new System.EventHandler(this.numere_TextChanged);
            // 
            // Buton
            // 
            this.Buton.BackColor = System.Drawing.Color.Transparent;
            this.Buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Buton.FlatAppearance.BorderSize = 0;
            this.Buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buton.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Buton.ForeColor = System.Drawing.Color.Violet;
            this.Buton.Location = new System.Drawing.Point(299, 398);
            this.Buton.Name = "Buton";
            this.Buton.Size = new System.Drawing.Size(400, 76);
            this.Buton.TabIndex = 2;
            this.Buton.Text = "OK";
            this.Buton.UseVisualStyleBackColor = true;
            this.Buton.Click += new System.EventHandler(this.Buton_Click);
            // 
            // invalid
            // 
            this.invalid.BackColor = System.Drawing.Color.Transparent;
            this.invalid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invalid.ForeColor = System.Drawing.Color.Purple;
            this.invalid.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.invalid.Location = new System.Drawing.Point(324, 144);
            this.invalid.Name = "invalid";
            this.invalid.Size = new System.Drawing.Size(484, 48);
            this.invalid.TabIndex = 3;
            this.invalid.Text = "Invalid, te rog sa introduci un numar natural";
            this.invalid.Visible = false;
            this.invalid.Click += new System.EventHandler(this.invalid_Click);
        
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(133, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 161);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // semn
            // 
            this.semn.BackColor = System.Drawing.Color.Transparent;
            this.semn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("semn.BackgroundImage")));
            this.semn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.semn.Location = new System.Drawing.Point(290, 144);
            this.semn.Name = "semn";
            this.semn.Size = new System.Drawing.Size(28, 25);
            this.semn.TabIndex = 5;
            this.semn.TabStop = false;
            this.semn.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-588, -197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2161, 671);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PrimeNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(981, 585);
            this.Controls.Add(this.semn);
            this.Controls.Add(this.invalid);
            this.Controls.Add(this.Buton);
            this.Controls.Add(this.numere);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "PrimeNumbers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        
        private TextBox numere;
        private Button Buton;
        private Label invalid;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox semn;
        private PictureBox pictureBox2;
    }
}