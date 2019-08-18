namespace LikeConditionsWithEntityFrameworkCore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompanyNameConditionsComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyNameFindTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameFindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContactTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CompanyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTlteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CurrentCustomerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ContactTypeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CompanyNameFindButton);
            this.groupBox1.Controls.Add(this.CompanyNameFindTextBox);
            this.groupBox1.Controls.Add(this.CompanyNameConditionsComboBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company name filter";
            // 
            // CompanyNameConditionsComboBox
            // 
            this.CompanyNameConditionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyNameConditionsComboBox.FormattingEnabled = true;
            this.CompanyNameConditionsComboBox.Location = new System.Drawing.Point(59, 22);
            this.CompanyNameConditionsComboBox.Name = "CompanyNameConditionsComboBox";
            this.CompanyNameConditionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.CompanyNameConditionsComboBox.TabIndex = 0;
            // 
            // CompanyNameFindTextBox
            // 
            this.CompanyNameFindTextBox.Location = new System.Drawing.Point(186, 23);
            this.CompanyNameFindTextBox.Name = "CompanyNameFindTextBox";
            this.CompanyNameFindTextBox.Size = new System.Drawing.Size(130, 20);
            this.CompanyNameFindTextBox.TabIndex = 1;
            this.CompanyNameFindTextBox.Text = "Fr";
            // 
            // CompanyNameFindButton
            // 
            this.CompanyNameFindButton.Location = new System.Drawing.Point(680, 21);
            this.CompanyNameFindButton.Name = "CompanyNameFindButton";
            this.CompanyNameFindButton.Size = new System.Drawing.Size(75, 23);
            this.CompanyNameFindButton.TabIndex = 2;
            this.CompanyNameFindButton.Text = "Filter";
            this.CompanyNameFindButton.UseVisualStyleBackColor = true;
            this.CompanyNameFindButton.Click += new System.EventHandler(this.CompanyNameFindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact type";
            // 
            // ContactTypeComboBox
            // 
            this.ContactTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContactTypeComboBox.FormattingEnabled = true;
            this.ContactTypeComboBox.Location = new System.Drawing.Point(433, 24);
            this.ContactTypeComboBox.Name = "ContactTypeComboBox";
            this.ContactTypeComboBox.Size = new System.Drawing.Size(160, 21);
            this.ContactTypeComboBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyNameColumn,
            this.ContactTlteColumn,
            this.ContactNameColumn,
            this.CountryNameColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 226);
            this.dataGridView1.TabIndex = 1;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.DataPropertyName = "CompanyName";
            this.CompanyNameColumn.HeaderText = "Company";
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            // 
            // ContactTlteColumn
            // 
            this.ContactTlteColumn.DataPropertyName = "ContactTitle";
            this.ContactTlteColumn.HeaderText = "Title";
            this.ContactTlteColumn.Name = "ContactTlteColumn";
            // 
            // ContactNameColumn
            // 
            this.ContactNameColumn.DataPropertyName = "ContactName";
            this.ContactNameColumn.HeaderText = "Contact";
            this.ContactNameColumn.Name = "ContactNameColumn";
            // 
            // CountryNameColumn
            // 
            this.CountryNameColumn.DataPropertyName = "CountyName";
            this.CountryNameColumn.HeaderText = "Country";
            this.CountryNameColumn.Name = "CountryNameColumn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CurrentCustomerButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 42);
            this.panel2.TabIndex = 2;
            // 
            // CurrentCustomerButton
            // 
            this.CurrentCustomerButton.Enabled = false;
            this.CurrentCustomerButton.Location = new System.Drawing.Point(14, 7);
            this.CurrentCustomerButton.Name = "CurrentCustomerButton";
            this.CurrentCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.CurrentCustomerButton.TabIndex = 0;
            this.CurrentCustomerButton.Text = "Current";
            this.CurrentCustomerButton.UseVisualStyleBackColor = true;
            this.CurrentCustomerButton.Click += new System.EventHandler(this.CurrentCustomerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entity Framework Core Filtering with Like";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CompanyNameConditionsComboBox;
        private System.Windows.Forms.Button CompanyNameFindButton;
        private System.Windows.Forms.TextBox CompanyNameFindTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ContactTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTlteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryNameColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CurrentCustomerButton;
    }
}

