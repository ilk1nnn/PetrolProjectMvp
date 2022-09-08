namespace PetrolProjectMvp
{
    partial class MainView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oilcombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceandtypelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.litr = new System.Windows.Forms.MaskedTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.totalpayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gas-Station";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Petrol:";
            // 
            // oilcombobox
            // 
            this.oilcombobox.AutoRoundedCorners = true;
            this.oilcombobox.BackColor = System.Drawing.Color.Transparent;
            this.oilcombobox.BorderRadius = 17;
            this.oilcombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.oilcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oilcombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oilcombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oilcombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.oilcombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.oilcombobox.ItemHeight = 30;
            this.oilcombobox.Items.AddRange(new object[] {
            "AI-92",
            "AI-95",
            "Diesel"});
            this.oilcombobox.Location = new System.Drawing.Point(233, 111);
            this.oilcombobox.Name = "oilcombobox";
            this.oilcombobox.Size = new System.Drawing.Size(180, 36);
            this.oilcombobox.TabIndex = 2;
            this.oilcombobox.SelectedIndexChanged += new System.EventHandler(this.oilcombobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 67);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price for";
            // 
            // priceandtypelbl
            // 
            this.priceandtypelbl.AutoSize = true;
            this.priceandtypelbl.BackColor = System.Drawing.Color.Transparent;
            this.priceandtypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceandtypelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceandtypelbl.Location = new System.Drawing.Point(276, 196);
            this.priceandtypelbl.Name = "priceandtypelbl";
            this.priceandtypelbl.Size = new System.Drawing.Size(0, 67);
            this.priceandtypelbl.TabIndex = 4;
            this.priceandtypelbl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 67);
            this.label4.TabIndex = 5;
            this.label4.Text = "Litres:";
            // 
            // litr
            // 
            this.litr.Location = new System.Drawing.Point(215, 306);
            this.litr.Name = "litr";
            this.litr.Size = new System.Drawing.Size(100, 31);
            this.litr.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 32;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(354, 286);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(143, 67);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Pay";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // totalpayment
            // 
            this.totalpayment.AutoSize = true;
            this.totalpayment.BackColor = System.Drawing.Color.Transparent;
            this.totalpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalpayment.Location = new System.Drawing.Point(13, 434);
            this.totalpayment.Name = "totalpayment";
            this.totalpayment.Size = new System.Drawing.Size(316, 61);
            this.totalpayment.TabIndex = 8;
            this.totalpayment.Text = "Gas-Station";
            this.totalpayment.Visible = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetrolProjectMvp.Properties.Resources.darkbluegradient;
            this.ClientSize = new System.Drawing.Size(913, 1114);
            this.Controls.Add(this.totalpayment);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.litr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceandtypelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oilcombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox oilcombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceandtypelbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox litr;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label totalpayment;
    }
}

