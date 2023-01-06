namespace C650_Fuel_Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConversionLbl = new System.Windows.Forms.Label();
            this.CurrentFuelLbl = new System.Windows.Forms.Label();
            this.KGLbl = new System.Windows.Forms.Label();
            this.NeededFuelLbl = new System.Windows.Forms.Label();
            this.CurrentFuelLBSTxt = new System.Windows.Forms.TextBox();
            this.BlockFuelTxt = new System.Windows.Forms.TextBox();
            this.KGLiterTxt = new System.Windows.Forms.TextBox();
            this.NeededFuelTxt = new System.Windows.Forms.TextBox();
            this.CurrentFuelKGTxt = new System.Windows.Forms.TextBox();
            this.kg_label = new System.Windows.Forms.Label();
            this.lbs_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GalLbl = new System.Windows.Forms.Label();
            this.LbsGalTxt = new System.Windows.Forms.TextBox();
            this.BlockFuelLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConversionLbl
            // 
            this.ConversionLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConversionLbl.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Underline);
            this.ConversionLbl.Location = new System.Drawing.Point(0, 137);
            this.ConversionLbl.Name = "ConversionLbl";
            this.ConversionLbl.Size = new System.Drawing.Size(404, 24);
            this.ConversionLbl.TabIndex = 0;
            this.ConversionLbl.Text = "Conversion";
            this.ConversionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentFuelLbl
            // 
            this.CurrentFuelLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentFuelLbl.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Underline);
            this.CurrentFuelLbl.Location = new System.Drawing.Point(0, 0);
            this.CurrentFuelLbl.Name = "CurrentFuelLbl";
            this.CurrentFuelLbl.Size = new System.Drawing.Size(404, 35);
            this.CurrentFuelLbl.TabIndex = 0;
            this.CurrentFuelLbl.Text = "Current Fuel";
            this.CurrentFuelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KGLbl
            // 
            this.KGLbl.Font = new System.Drawing.Font("Lucida Handwriting", 12F);
            this.KGLbl.Location = new System.Drawing.Point(148, 19);
            this.KGLbl.Name = "KGLbl";
            this.KGLbl.Size = new System.Drawing.Size(58, 24);
            this.KGLbl.TabIndex = 0;
            this.KGLbl.Text = "KG/L";
            this.KGLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NeededFuelLbl
            // 
            this.NeededFuelLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NeededFuelLbl.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Underline);
            this.NeededFuelLbl.Location = new System.Drawing.Point(0, 214);
            this.NeededFuelLbl.Name = "NeededFuelLbl";
            this.NeededFuelLbl.Size = new System.Drawing.Size(404, 34);
            this.NeededFuelLbl.TabIndex = 0;
            this.NeededFuelLbl.Text = "Needed Fuel (Liters)";
            this.NeededFuelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentFuelLBSTxt
            // 
            this.CurrentFuelLBSTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CurrentFuelLBSTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentFuelLBSTxt.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.CurrentFuelLBSTxt.Location = new System.Drawing.Point(29, 7);
            this.CurrentFuelLBSTxt.MaxLength = 5;
            this.CurrentFuelLBSTxt.Name = "CurrentFuelLBSTxt";
            this.CurrentFuelLBSTxt.Size = new System.Drawing.Size(103, 33);
            this.CurrentFuelLBSTxt.TabIndex = 1;
            this.CurrentFuelLBSTxt.Text = "|";
            this.CurrentFuelLBSTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentFuelLBSTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleTextChange);
            // 
            // BlockFuelTxt
            // 
            this.BlockFuelTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BlockFuelTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlockFuelTxt.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.BlockFuelTxt.Location = new System.Drawing.Point(29, 0);
            this.BlockFuelTxt.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.BlockFuelTxt.MaxLength = 5;
            this.BlockFuelTxt.Name = "BlockFuelTxt";
            this.BlockFuelTxt.Size = new System.Drawing.Size(325, 33);
            this.BlockFuelTxt.TabIndex = 3;
            this.BlockFuelTxt.Text = "|";
            this.BlockFuelTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BlockFuelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleTextChange);
            // 
            // KGLiterTxt
            // 
            this.KGLiterTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.KGLiterTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KGLiterTxt.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.KGLiterTxt.Location = new System.Drawing.Point(29, 10);
            this.KGLiterTxt.MaxLength = 6;
            this.KGLiterTxt.Name = "KGLiterTxt";
            this.KGLiterTxt.Size = new System.Drawing.Size(103, 33);
            this.KGLiterTxt.TabIndex = 4;
            this.KGLiterTxt.Text = "|";
            this.KGLiterTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KGLiterTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleTextChange);
            // 
            // NeededFuelTxt
            // 
            this.NeededFuelTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NeededFuelTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NeededFuelTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NeededFuelTxt.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.NeededFuelTxt.Location = new System.Drawing.Point(0, 248);
            this.NeededFuelTxt.Name = "NeededFuelTxt";
            this.NeededFuelTxt.ReadOnly = true;
            this.NeededFuelTxt.Size = new System.Drawing.Size(404, 33);
            this.NeededFuelTxt.TabIndex = 6;
            this.NeededFuelTxt.Text = "|";
            this.NeededFuelTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentFuelKGTxt
            // 
            this.CurrentFuelKGTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CurrentFuelKGTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentFuelKGTxt.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.CurrentFuelKGTxt.Location = new System.Drawing.Point(212, 7);
            this.CurrentFuelKGTxt.MaxLength = 5;
            this.CurrentFuelKGTxt.Name = "CurrentFuelKGTxt";
            this.CurrentFuelKGTxt.Size = new System.Drawing.Size(103, 33);
            this.CurrentFuelKGTxt.TabIndex = 2;
            this.CurrentFuelKGTxt.Text = "|";
            this.CurrentFuelKGTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrentFuelKGTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleTextChange);
            // 
            // kg_label
            // 
            this.kg_label.AutoSize = true;
            this.kg_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F);
            this.kg_label.Location = new System.Drawing.Point(321, 19);
            this.kg_label.Name = "kg_label";
            this.kg_label.Size = new System.Drawing.Size(33, 21);
            this.kg_label.TabIndex = 0;
            this.kg_label.Text = "KG";
            // 
            // lbs_label
            // 
            this.lbs_label.AutoSize = true;
            this.lbs_label.Font = new System.Drawing.Font("Lucida Handwriting", 12F);
            this.lbs_label.Location = new System.Drawing.Point(148, 19);
            this.lbs_label.Name = "lbs_label";
            this.lbs_label.Size = new System.Drawing.Size(41, 21);
            this.lbs_label.TabIndex = 0;
            this.lbs_label.Text = "LBS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbs_label);
            this.panel1.Controls.Add(this.kg_label);
            this.panel1.Controls.Add(this.CurrentFuelKGTxt);
            this.panel1.Controls.Add(this.CurrentFuelLBSTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GalLbl);
            this.panel2.Controls.Add(this.LbsGalTxt);
            this.panel2.Controls.Add(this.KGLbl);
            this.panel2.Controls.Add(this.KGLiterTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 53);
            this.panel2.TabIndex = 0;
            // 
            // GalLbl
            // 
            this.GalLbl.Font = new System.Drawing.Font("Lucida Handwriting", 12F);
            this.GalLbl.Location = new System.Drawing.Point(321, 19);
            this.GalLbl.Name = "GalLbl";
            this.GalLbl.Size = new System.Drawing.Size(80, 24);
            this.GalLbl.TabIndex = 0;
            this.GalLbl.Text = "LBS/Gal";
            this.GalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbsGalTxt
            // 
            this.LbsGalTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LbsGalTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbsGalTxt.Font = new System.Drawing.Font("Lucida Handwriting", 14F);
            this.LbsGalTxt.Location = new System.Drawing.Point(212, 10);
            this.LbsGalTxt.MaxLength = 6;
            this.LbsGalTxt.Name = "LbsGalTxt";
            this.LbsGalTxt.Size = new System.Drawing.Size(103, 33);
            this.LbsGalTxt.TabIndex = 5;
            this.LbsGalTxt.Text = "|";
            this.LbsGalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LbsGalTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleTextChange);
            // 
            // BlockFuelLbl
            // 
            this.BlockFuelLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlockFuelLbl.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Underline);
            this.BlockFuelLbl.Location = new System.Drawing.Point(0, 78);
            this.BlockFuelLbl.Name = "BlockFuelLbl";
            this.BlockFuelLbl.Size = new System.Drawing.Size(404, 24);
            this.BlockFuelLbl.TabIndex = 0;
            this.BlockFuelLbl.Text = "Block Fuel";
            this.BlockFuelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BlockFuelTxt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 35);
            this.panel3.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ConversionLbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NeededFuelLbl);
            this.Controls.Add(this.NeededFuelTxt);
            this.Controls.Add(this.BlockFuelLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CurrentFuelLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 340);
            this.MinimumSize = new System.Drawing.Size(420, 320);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CL650 Fuel Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConversionLbl;
        private System.Windows.Forms.Label CurrentFuelLbl;
        private System.Windows.Forms.Label KGLbl;
        private System.Windows.Forms.Label NeededFuelLbl;
        private System.Windows.Forms.TextBox CurrentFuelLBSTxt;
        private System.Windows.Forms.TextBox BlockFuelTxt;
        private System.Windows.Forms.TextBox KGLiterTxt;
        private System.Windows.Forms.TextBox NeededFuelTxt;
        private System.Windows.Forms.TextBox CurrentFuelKGTxt;
        private System.Windows.Forms.Label kg_label;
        private System.Windows.Forms.Label lbs_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BlockFuelLbl;
        private System.Windows.Forms.Label GalLbl;
        private System.Windows.Forms.TextBox LbsGalTxt;
        private System.Windows.Forms.Panel panel3;
    }
}

