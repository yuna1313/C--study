namespace AnimalShelter
{
    partial class Form1
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
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CusDetailPanel = new System.Windows.Forms.Panel();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusNewPanel = new System.Windows.Forms.Panel();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.CusNewFirstName = new System.Windows.Forms.TextBox();
            this.CusNewLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CusListPanel = new System.Windows.Forms.Panel();
            this.CusList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CusDetailPanel.SuspendLayout();
            this.CusNewPanel.SuspendLayout();
            this.CusListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(186, 477);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(188, 43);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CusDetailPanel
            // 
            this.CusDetailPanel.Controls.Add(this.CusIsQualified);
            this.CusDetailPanel.Controls.Add(this.label2);
            this.CusDetailPanel.Controls.Add(this.CusDescription);
            this.CusDetailPanel.Controls.Add(this.label9);
            this.CusDetailPanel.Controls.Add(this.CusAddress);
            this.CusDetailPanel.Controls.Add(this.label7);
            this.CusDetailPanel.Controls.Add(this.CusAge);
            this.CusDetailPanel.Controls.Add(this.label5);
            this.CusDetailPanel.Controls.Add(this.CusFullName);
            this.CusDetailPanel.Controls.Add(this.label3);
            this.CusDetailPanel.Location = new System.Drawing.Point(533, 0);
            this.CusDetailPanel.Name = "CusDetailPanel";
            this.CusDetailPanel.Size = new System.Drawing.Size(447, 565);
            this.CusDetailPanel.TabIndex = 1;
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.Location = new System.Drawing.Point(137, 166);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(60, 25);
            this.CusIsQualified.TabIndex = 13;
            this.CusIsQualified.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "입양가능:";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(137, 274);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(60, 25);
            this.CusDescription.TabIndex = 11;
            this.CusDescription.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "설명:";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(137, 218);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(60, 25);
            this.CusAddress.TabIndex = 9;
            this.CusAddress.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "주소:";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(137, 115);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(60, 25);
            this.CusAge.TabIndex = 7;
            this.CusAge.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "나이:";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.Location = new System.Drawing.Point(137, 61);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(60, 25);
            this.CusFullName.TabIndex = 5;
            this.CusFullName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름:";
            // 
            // CusNewPanel
            // 
            this.CusNewPanel.Controls.Add(this.CusNewDescription);
            this.CusNewPanel.Controls.Add(this.CusNewAddress);
            this.CusNewPanel.Controls.Add(this.CreateCustomer);
            this.CusNewPanel.Controls.Add(this.CusNewBirthday);
            this.CusNewPanel.Controls.Add(this.CusNewFirstName);
            this.CusNewPanel.Controls.Add(this.CusNewLastName);
            this.CusNewPanel.Controls.Add(this.label1);
            this.CusNewPanel.Controls.Add(this.label4);
            this.CusNewPanel.Controls.Add(this.label10);
            this.CusNewPanel.Controls.Add(this.label6);
            this.CusNewPanel.Controls.Add(this.label8);
            this.CusNewPanel.Location = new System.Drawing.Point(495, 128);
            this.CusNewPanel.Name = "CusNewPanel";
            this.CusNewPanel.Size = new System.Drawing.Size(447, 565);
            this.CusNewPanel.TabIndex = 2;
            this.CusNewPanel.Visible = false;
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(88, 184);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(286, 287);
            this.CusNewDescription.TabIndex = 23;
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(88, 147);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(286, 31);
            this.CusNewAddress.TabIndex = 22;
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(88, 110);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(150, 31);
            this.CusNewBirthday.TabIndex = 21;
            // 
            // CusNewFirstName
            // 
            this.CusNewFirstName.Location = new System.Drawing.Point(88, 73);
            this.CusNewFirstName.Name = "CusNewFirstName";
            this.CusNewFirstName.Size = new System.Drawing.Size(150, 31);
            this.CusNewFirstName.TabIndex = 20;
            // 
            // CusNewLastName
            // 
            this.CusNewLastName.Location = new System.Drawing.Point(88, 35);
            this.CusNewLastName.Name = "CusNewLastName";
            this.CusNewLastName.Size = new System.Drawing.Size(150, 31);
            this.CusNewLastName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "생일:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "설명:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "성:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "주소:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "이름:";
            // 
            // CusListPanel
            // 
            this.CusListPanel.Controls.Add(this.CusList);
            this.CusListPanel.Location = new System.Drawing.Point(1, 45);
            this.CusListPanel.Name = "CusListPanel";
            this.CusListPanel.Size = new System.Drawing.Size(470, 520);
            this.CusListPanel.TabIndex = 3;
            // 
            // CusList
            // 
            this.CusList.AllowUserToAddRows = false;
            this.CusList.AllowUserToDeleteRows = false;
            this.CusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.CusList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CusList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CusList.Location = new System.Drawing.Point(0, 0);
            this.CusList.MultiSelect = false;
            this.CusList.Name = "CusList";
            this.CusList.RowHeadersWidth = 62;
            this.CusList.RowTemplate.Height = 33;
            this.CusList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CusList.Size = new System.Drawing.Size(470, 520);
            this.CusList.TabIndex = 0;
            this.CusList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CusList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "나이";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "입양가능";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 29);
            this.toolStripMenuItem1.Text = "새 입양자";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 565);
            this.Controls.Add(this.CusListPanel);
            this.Controls.Add(this.CusNewPanel);
            this.Controls.Add(this.CusDetailPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CusDetailPanel.ResumeLayout(false);
            this.CusDetailPanel.PerformLayout();
            this.CusNewPanel.ResumeLayout(false);
            this.CusNewPanel.PerformLayout();
            this.CusListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateCustomer;
        private Panel CusDetailPanel;
        private Label CusDescription;
        private Label label9;
        private Label CusAddress;
        private Label label7;
        private Label CusAge;
        private Label label5;
        private Label CusFullName;
        private Label label3;
        private Label CusIsQualified;
        private Label label2;
        private Panel CusNewPanel;
        private Label label1;
        private Label label4;
        private Label label10;
        private Label label6;
        private Label label8;
        private TextBox CusNewDescription;
        private TextBox CusNewAddress;
        private TextBox CusNewBirthday;
        private TextBox CusNewFirstName;
        private TextBox CusNewLastName;
        private Panel CusListPanel;
        private DataGridView CusList;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}