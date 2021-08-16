namespace ekaprojekti
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EtunimiLB = new System.Windows.Forms.Label();
            this.muutabt = new System.Windows.Forms.Button();
            this.muutabt1 = new System.Windows.Forms.Button();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.ViestiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EtunimiLB
            // 
            this.EtunimiLB.AutoSize = true;
            this.EtunimiLB.Location = new System.Drawing.Point(261, 151);
            this.EtunimiLB.Name = "EtunimiLB";
            this.EtunimiLB.Size = new System.Drawing.Size(183, 29);
            this.EtunimiLB.TabIndex = 0;
            this.EtunimiLB.Text = "Anna etunimesi:";
            this.EtunimiLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // muutabt
            // 
            this.muutabt.BackColor = System.Drawing.Color.DarkOrange;
            this.muutabt.Location = new System.Drawing.Point(444, 198);
            this.muutabt.Name = "muutabt";
            this.muutabt.Size = new System.Drawing.Size(173, 82);
            this.muutabt.TabIndex = 1;
            this.muutabt.Text = "muuta teksti";
            this.muutabt.UseVisualStyleBackColor = false;
            this.muutabt.Click += new System.EventHandler(this.button1_Click);
            // 
            // muutabt1
            // 
            this.muutabt1.BackColor = System.Drawing.SystemColors.Highlight;
            this.muutabt1.Location = new System.Drawing.Point(737, 198);
            this.muutabt1.Name = "muutabt1";
            this.muutabt1.Size = new System.Drawing.Size(163, 82);
            this.muutabt1.TabIndex = 2;
            this.muutabt1.Text = "peruuta";
            this.muutabt1.UseVisualStyleBackColor = false;
            this.muutabt1.Click += new System.EventHandler(this.muutabt1_Click);
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(444, 148);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(456, 35);
            this.TekstiTB.TabIndex = 3;
            // 
            // ViestiLB
            // 
            this.ViestiLB.AutoSize = true;
            this.ViestiLB.Location = new System.Drawing.Point(275, 324);
            this.ViestiLB.Name = "ViestiLB";
            this.ViestiLB.Size = new System.Drawing.Size(72, 29);
            this.ViestiLB.TabIndex = 4;
            this.ViestiLB.Text = "Viesti";
            this.ViestiLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 847);
            this.Controls.Add(this.ViestiLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.muutabt1);
            this.Controls.Add(this.muutabt);
            this.Controls.Add(this.EtunimiLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtunimiLB;
        private System.Windows.Forms.Button muutabt;
        private System.Windows.Forms.Button muutabt1;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Label ViestiLB;
    }
}

