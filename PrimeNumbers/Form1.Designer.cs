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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimeNumbers));
            this.numere = new System.Windows.Forms.TextBox();
            this.Buton = new System.Windows.Forms.Button();
            this.invalid = new System.Windows.Forms.Label();
            this.ButonBackground = new System.Windows.Forms.PictureBox();
            this.semn = new System.Windows.Forms.PictureBox();
            this.IntroducetiNr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ButonBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntroducetiNr)).BeginInit();
            this.SuspendLayout();
            // 
            // numere
            // 
            this.numere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numere.BackColor = System.Drawing.Color.SlateGray;
            this.numere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numere.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numere.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.numere.Location = new System.Drawing.Point(135, 59);
            this.numere.Name = "numere";
            this.numere.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.numere.Size = new System.Drawing.Size(704, 78);
            this.numere.TabIndex = 0;
            this.numere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numere.TextChanged += new System.EventHandler(this.numere_TextChanged);
            // 
            // Buton
            // 
            this.Buton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Buton.BackColor = System.Drawing.Color.Transparent;
            this.Buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Buton.FlatAppearance.BorderSize = 0;
            this.Buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buton.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Buton.ForeColor = System.Drawing.Color.Violet;
            this.Buton.Location = new System.Drawing.Point(268, 455);
            this.Buton.Name = "Buton";
            this.Buton.Size = new System.Drawing.Size(436, 80);
            this.Buton.TabIndex = 2;
            this.Buton.Text = "OK";
            this.Buton.UseVisualStyleBackColor = true;
            this.Buton.Click += new System.EventHandler(this.Buton_Click);
            // 
            // invalid
            // 
            this.invalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalid.BackColor = System.Drawing.Color.Transparent;
            this.invalid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invalid.ForeColor = System.Drawing.Color.Purple;
            this.invalid.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.invalid.Location = new System.Drawing.Point(324, 173);
            this.invalid.Name = "invalid";
            this.invalid.Size = new System.Drawing.Size(484, 48);
            this.invalid.TabIndex = 3;
            this.invalid.Text = "Invalid, te rog sa introduci un numar natural";
            this.invalid.Visible = false;
            // 
            // ButonBackground
            // 
            this.ButonBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButonBackground.BackColor = System.Drawing.Color.Transparent;
            this.ButonBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButonBackground.BackgroundImage")));
            this.ButonBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButonBackground.Location = new System.Drawing.Point(121, 423);
            this.ButonBackground.Name = "ButonBackground";
            this.ButonBackground.Size = new System.Drawing.Size(756, 161);
            this.ButonBackground.TabIndex = 4;
            this.ButonBackground.TabStop = false;
            // 
            // semn
            // 
            this.semn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.semn.BackColor = System.Drawing.Color.Transparent;
            this.semn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("semn.BackgroundImage")));
            this.semn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.semn.Location = new System.Drawing.Point(290, 173);
            this.semn.Name = "semn";
            this.semn.Size = new System.Drawing.Size(28, 25);
            this.semn.TabIndex = 5;
            this.semn.TabStop = false;
            this.semn.Visible = false;
            // 
            // IntroducetiNr
            // 
            this.IntroducetiNr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IntroducetiNr.BackColor = System.Drawing.Color.Transparent;
            this.IntroducetiNr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IntroducetiNr.BackgroundImage")));
            this.IntroducetiNr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IntroducetiNr.Location = new System.Drawing.Point(39, 12);
            this.IntroducetiNr.Name = "IntroducetiNr";
            this.IntroducetiNr.Size = new System.Drawing.Size(903, 155);
            this.IntroducetiNr.TabIndex = 7;
            this.IntroducetiNr.TabStop = false;
            // 
            // PrimeNumbers
            // 
            this.AcceptButton = this.Buton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(981, 585);
            this.Controls.Add(this.semn);
            this.Controls.Add(this.invalid);
            this.Controls.Add(this.Buton);
            this.Controls.Add(this.numere);
            this.Controls.Add(this.ButonBackground);
            this.Controls.Add(this.IntroducetiNr);
            this.Name = "PrimeNumbers";
            this.Text = "PrimeNumbers";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrimeNumbers_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ButonBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntroducetiNr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        
        private TextBox numere;
        private Button Buton;
        private Label invalid;

        private PictureBox ButonBackground;
        private PictureBox semn;
        private PictureBox IntroducetiNr;
    }
}