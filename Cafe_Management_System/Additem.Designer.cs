namespace Cafe_Management_System
{
    partial class Additem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Additem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itembox = new Guna.UI2.WinForms.Guna2TextBox();
            this.categorybox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(224, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catagory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(224, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item name";
            // 
            // itembox
            // 
            this.itembox.BackColor = System.Drawing.SystemColors.Window;
            this.itembox.BorderColor = System.Drawing.SystemColors.WindowText;
            this.itembox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itembox.DefaultText = "";
            this.itembox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itembox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itembox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itembox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itembox.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.itembox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itembox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itembox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.itembox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itembox.Location = new System.Drawing.Point(228, 213);
            this.itembox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itembox.Name = "itembox";
            this.itembox.PlaceholderForeColor = System.Drawing.Color.White;
            this.itembox.PlaceholderText = "";
            this.itembox.SelectedText = "";
            this.itembox.Size = new System.Drawing.Size(241, 38);
            this.itembox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.itembox.TabIndex = 3;
            // 
            // categorybox
            // 
            this.categorybox.BackColor = System.Drawing.SystemColors.Window;
            this.categorybox.BorderColor = System.Drawing.Color.White;
            this.categorybox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categorybox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorybox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorybox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorybox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categorybox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.categorybox.ItemHeight = 30;
            this.categorybox.Items.AddRange(new object[] {
            "Coffee",
            "Ice-cream",
            "Burger",
            "indian",
            "chines",
            "desi "});
            this.categorybox.Location = new System.Drawing.Point(228, 114);
            this.categorybox.Name = "categorybox";
            this.categorybox.Size = new System.Drawing.Size(241, 36);
            this.categorybox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.categorybox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(228, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // pricebox
            // 
            this.pricebox.BackColor = System.Drawing.SystemColors.Window;
            this.pricebox.BorderColor = System.Drawing.SystemColors.Window;
            this.pricebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pricebox.DefaultText = "";
            this.pricebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pricebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pricebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pricebox.FillColor = System.Drawing.SystemColors.Window;
            this.pricebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pricebox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pricebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pricebox.Location = new System.Drawing.Point(228, 317);
            this.pricebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pricebox.Name = "pricebox";
            this.pricebox.PlaceholderText = "";
            this.pricebox.SelectedText = "";
            this.pricebox.Size = new System.Drawing.Size(241, 38);
            this.pricebox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.pricebox.TabIndex = 6;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.DarkGreen;
            this.addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.addbtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(259, 399);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(147, 45);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Add item";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Additem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 522);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categorybox);
            this.Controls.Add(this.itembox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Additem";
            this.Text = "Additem";
            this.Load += new System.EventHandler(this.Additem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox itembox;
        private Guna.UI2.WinForms.Guna2ComboBox categorybox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox pricebox;
        private Guna.UI2.WinForms.Guna2Button addbtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}