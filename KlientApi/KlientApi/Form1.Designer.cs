namespace KlientApi
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
            this.OsobyCombo = new System.Windows.Forms.ComboBox();
            this.PokojeCombo = new System.Windows.Forms.ComboBox();
            this.PokojText = new System.Windows.Forms.TextBox();
            this.UsunOsobe = new System.Windows.Forms.Button();
            this.UsunPokoj = new System.Windows.Forms.Button();
            this.DodajEwidencje = new System.Windows.Forms.Button();
            this.EdytujPokoj = new System.Windows.Forms.Button();
            this.DataLoadButton = new System.Windows.Forms.Button();
            this.DodajOsobe = new System.Windows.Forms.Button();
            this.DodajPokoj = new System.Windows.Forms.Button();
            this.UsunEwidencje = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.OsobyTextBox = new System.Windows.Forms.TextBox();
            this.EdytujOsobe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OsobyCombo
            // 
            this.OsobyCombo.FormattingEnabled = true;
            this.OsobyCombo.Location = new System.Drawing.Point(12, 13);
            this.OsobyCombo.Name = "OsobyCombo";
            this.OsobyCombo.Size = new System.Drawing.Size(121, 21);
            this.OsobyCombo.TabIndex = 0;
            this.OsobyCombo.SelectedIndexChanged += new System.EventHandler(this.OsobyCombo_SelectedIndexChanged);
            // 
            // PokojeCombo
            // 
            this.PokojeCombo.FormattingEnabled = true;
            this.PokojeCombo.Location = new System.Drawing.Point(12, 67);
            this.PokojeCombo.Name = "PokojeCombo";
            this.PokojeCombo.Size = new System.Drawing.Size(121, 21);
            this.PokojeCombo.TabIndex = 1;
            this.PokojeCombo.SelectedIndexChanged += new System.EventHandler(this.PokojeCombo_SelectedIndexChanged);
            // 
            // PokojText
            // 
            this.PokojText.Location = new System.Drawing.Point(12, 95);
            this.PokojText.Name = "PokojText";
            this.PokojText.Size = new System.Drawing.Size(121, 20);
            this.PokojText.TabIndex = 2;
            // 
            // UsunOsobe
            // 
            this.UsunOsobe.Location = new System.Drawing.Point(139, 11);
            this.UsunOsobe.Name = "UsunOsobe";
            this.UsunOsobe.Size = new System.Drawing.Size(75, 23);
            this.UsunOsobe.TabIndex = 3;
            this.UsunOsobe.Text = "UsunOsobe";
            this.UsunOsobe.UseVisualStyleBackColor = true;
            this.UsunOsobe.Click += new System.EventHandler(this.UsunOsobe_Click);
            // 
            // UsunPokoj
            // 
            this.UsunPokoj.Location = new System.Drawing.Point(139, 67);
            this.UsunPokoj.Name = "UsunPokoj";
            this.UsunPokoj.Size = new System.Drawing.Size(75, 23);
            this.UsunPokoj.TabIndex = 4;
            this.UsunPokoj.Text = "UsunPokoj";
            this.UsunPokoj.UseVisualStyleBackColor = true;
            this.UsunPokoj.Click += new System.EventHandler(this.UsunPokoj_Click);
            // 
            // DodajEwidencje
            // 
            this.DodajEwidencje.Location = new System.Drawing.Point(12, 121);
            this.DodajEwidencje.Name = "DodajEwidencje";
            this.DodajEwidencje.Size = new System.Drawing.Size(283, 35);
            this.DodajEwidencje.TabIndex = 5;
            this.DodajEwidencje.Text = "DodajEwidencje";
            this.DodajEwidencje.UseVisualStyleBackColor = true;
            this.DodajEwidencje.Click += new System.EventHandler(this.DodajEwidencje_Click);
            // 
            // EdytujPokoj
            // 
            this.EdytujPokoj.Location = new System.Drawing.Point(139, 96);
            this.EdytujPokoj.Name = "EdytujPokoj";
            this.EdytujPokoj.Size = new System.Drawing.Size(75, 23);
            this.EdytujPokoj.TabIndex = 6;
            this.EdytujPokoj.Text = "Edytuj";
            this.EdytujPokoj.UseVisualStyleBackColor = true;
            this.EdytujPokoj.Click += new System.EventHandler(this.EdytujPokoj_Click);
            // 
            // DataLoadButton
            // 
            this.DataLoadButton.Location = new System.Drawing.Point(12, 203);
            this.DataLoadButton.Name = "DataLoadButton";
            this.DataLoadButton.Size = new System.Drawing.Size(283, 35);
            this.DataLoadButton.TabIndex = 7;
            this.DataLoadButton.Text = "Load Data";
            this.DataLoadButton.UseVisualStyleBackColor = true;
            this.DataLoadButton.Click += new System.EventHandler(this.DataLoadButton_Click);
            // 
            // DodajOsobe
            // 
            this.DodajOsobe.Location = new System.Drawing.Point(220, 11);
            this.DodajOsobe.Name = "DodajOsobe";
            this.DodajOsobe.Size = new System.Drawing.Size(75, 23);
            this.DodajOsobe.TabIndex = 8;
            this.DodajOsobe.Text = "DodajOsobe";
            this.DodajOsobe.UseVisualStyleBackColor = true;
            this.DodajOsobe.Click += new System.EventHandler(this.DodajOsobe_Click);
            // 
            // DodajPokoj
            // 
            this.DodajPokoj.Location = new System.Drawing.Point(220, 65);
            this.DodajPokoj.Name = "DodajPokoj";
            this.DodajPokoj.Size = new System.Drawing.Size(75, 23);
            this.DodajPokoj.TabIndex = 9;
            this.DodajPokoj.Text = "DodajPokoj";
            this.DodajPokoj.UseVisualStyleBackColor = true;
            this.DodajPokoj.Click += new System.EventHandler(this.DodajPokoj_Click);
            // 
            // UsunEwidencje
            // 
            this.UsunEwidencje.Location = new System.Drawing.Point(12, 162);
            this.UsunEwidencje.Name = "UsunEwidencje";
            this.UsunEwidencje.Size = new System.Drawing.Size(283, 35);
            this.UsunEwidencje.TabIndex = 10;
            this.UsunEwidencje.Text = "UsunEwidencje";
            this.UsunEwidencje.UseVisualStyleBackColor = true;
            this.UsunEwidencje.Click += new System.EventHandler(this.UsunEwidencje_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid.Location = new System.Drawing.Point(301, 13);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(344, 225);
            this.DataGrid.TabIndex = 13;
            // 
            // OsobyTextBox
            // 
            this.OsobyTextBox.Location = new System.Drawing.Point(12, 39);
            this.OsobyTextBox.Name = "OsobyTextBox";
            this.OsobyTextBox.Size = new System.Drawing.Size(121, 20);
            this.OsobyTextBox.TabIndex = 16;
            // 
            // EdytujOsobe
            // 
            this.EdytujOsobe.Location = new System.Drawing.Point(139, 37);
            this.EdytujOsobe.Name = "EdytujOsobe";
            this.EdytujOsobe.Size = new System.Drawing.Size(75, 23);
            this.EdytujOsobe.TabIndex = 17;
            this.EdytujOsobe.Text = "Edytuj";
            this.EdytujOsobe.UseVisualStyleBackColor = true;
            this.EdytujOsobe.Click += new System.EventHandler(this.EdytujOsobe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 248);
            this.Controls.Add(this.EdytujOsobe);
            this.Controls.Add(this.OsobyTextBox);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.UsunEwidencje);
            this.Controls.Add(this.DodajPokoj);
            this.Controls.Add(this.DodajOsobe);
            this.Controls.Add(this.DataLoadButton);
            this.Controls.Add(this.EdytujPokoj);
            this.Controls.Add(this.DodajEwidencje);
            this.Controls.Add(this.UsunPokoj);
            this.Controls.Add(this.UsunOsobe);
            this.Controls.Add(this.PokojText);
            this.Controls.Add(this.PokojeCombo);
            this.Controls.Add(this.OsobyCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OsobyCombo;
        private System.Windows.Forms.ComboBox PokojeCombo;
        private System.Windows.Forms.TextBox PokojText;
        private System.Windows.Forms.Button UsunOsobe;
        private System.Windows.Forms.Button UsunPokoj;
        private System.Windows.Forms.Button DodajEwidencje;
        private System.Windows.Forms.Button EdytujPokoj;
        private System.Windows.Forms.Button DataLoadButton;
        private System.Windows.Forms.Button DodajOsobe;
        private System.Windows.Forms.Button DodajPokoj;
        private System.Windows.Forms.Button UsunEwidencje;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.TextBox OsobyTextBox;
        private System.Windows.Forms.Button EdytujOsobe;
    }
}

