namespace AuthorizationUI
{
    partial class AuthorizationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tab = new System.Windows.Forms.TabControl();
            this.InsertTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SubdivisionsComboBoxInsertTab = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ActivityListInsertTab = new System.Windows.Forms.CheckedListBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubdivisionLeaderGroupBox = new System.Windows.Forms.GroupBox();
            this.LeaderLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LeaderFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.SubdivisionGroupBox = new System.Windows.Forms.GroupBox();
            this.SubdivizionPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SubdivisionNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ObjectPhoneTextBox = new System.Windows.Forms.TextBox();
            this.ObjectAddressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ObjectNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AgentPhoneTextBox = new System.Windows.Forms.TextBox();
            this.AgentAddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgentNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExpirationDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EliberationDateTime = new System.Windows.Forms.DateTimePicker();
            this.ASVFLabel = new System.Windows.Forms.Label();
            this.ASVFTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.SubdivisionsComboBoxISearchTab = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ObjectSearchBox = new System.Windows.Forms.TextBox();
            this.AgentSearchBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ASVFSearchBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ExpirationDateSearch = new System.Windows.Forms.DateTimePicker();
            this.EliberationDateSearch = new System.Windows.Forms.DateTimePicker();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Tab.SuspendLayout();
            this.InsertTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SubdivisionLeaderGroupBox.SuspendLayout();
            this.SubdivisionGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SearchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.InsertTab);
            this.Tab.Controls.Add(this.SearchTab);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1434, 761);
            this.Tab.TabIndex = 0;
            // 
            // InsertTab
            // 
            this.InsertTab.BackColor = System.Drawing.SystemColors.Control;
            this.InsertTab.Controls.Add(this.groupBox4);
            this.InsertTab.Controls.Add(this.label14);
            this.InsertTab.Controls.Add(this.ActivityListInsertTab);
            this.InsertTab.Controls.Add(this.ClearButton);
            this.InsertTab.Controls.Add(this.SubdivisionLeaderGroupBox);
            this.InsertTab.Controls.Add(this.SubdivisionGroupBox);
            this.InsertTab.Controls.Add(this.OkButton);
            this.InsertTab.Controls.Add(this.groupBox3);
            this.InsertTab.Controls.Add(this.groupBox2);
            this.InsertTab.Controls.Add(this.groupBox1);
            this.InsertTab.Controls.Add(this.label1);
            this.InsertTab.Location = new System.Drawing.Point(4, 22);
            this.InsertTab.Name = "InsertTab";
            this.InsertTab.Padding = new System.Windows.Forms.Padding(3);
            this.InsertTab.Size = new System.Drawing.Size(1426, 735);
            this.InsertTab.TabIndex = 0;
            this.InsertTab.Text = "Inserare Autorizatie";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.SubdivisionsComboBoxInsertTab);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(719, 452);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 239);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(38, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(140, 19);
            this.label23.TabIndex = 12;
            this.label23.Text = "Subdiviziune existenta";
            // 
            // SubdivisionsComboBoxInsertTab
            // 
            this.SubdivisionsComboBoxInsertTab.FormattingEnabled = true;
            this.SubdivisionsComboBoxInsertTab.Location = new System.Drawing.Point(42, 51);
            this.SubdivisionsComboBoxInsertTab.Name = "SubdivisionsComboBoxInsertTab";
            this.SubdivisionsComboBoxInsertTab.Size = new System.Drawing.Size(248, 27);
            this.SubdivisionsComboBoxInsertTab.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1086, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 19);
            this.label14.TabIndex = 11;
            this.label14.Text = "Profilul activitatii";
            // 
            // ActivityListInsertTab
            // 
            this.ActivityListInsertTab.BackColor = System.Drawing.SystemColors.Control;
            this.ActivityListInsertTab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityListInsertTab.FormattingEnabled = true;
            this.ActivityListInsertTab.Location = new System.Drawing.Point(1055, 105);
            this.ActivityListInsertTab.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ActivityListInsertTab.Name = "ActivityListInsertTab";
            this.ActivityListInsertTab.Size = new System.Drawing.Size(328, 340);
            this.ActivityListInsertTab.Sorted = true;
            this.ActivityListInsertTab.TabIndex = 15;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(1175, 663);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 28);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Sterge";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SubdivisionLeaderGroupBox
            // 
            this.SubdivisionLeaderGroupBox.Controls.Add(this.LeaderLastNameTextBox);
            this.SubdivisionLeaderGroupBox.Controls.Add(this.label11);
            this.SubdivisionLeaderGroupBox.Controls.Add(this.label13);
            this.SubdivisionLeaderGroupBox.Controls.Add(this.LeaderFirstNameTextbox);
            this.SubdivisionLeaderGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubdivisionLeaderGroupBox.Location = new System.Drawing.Point(35, 585);
            this.SubdivisionLeaderGroupBox.Name = "SubdivisionLeaderGroupBox";
            this.SubdivisionLeaderGroupBox.Size = new System.Drawing.Size(668, 106);
            this.SubdivisionLeaderGroupBox.TabIndex = 13;
            this.SubdivisionLeaderGroupBox.TabStop = false;
            this.SubdivisionLeaderGroupBox.Text = "Sef Subdiviziune";
            // 
            // LeaderLastNameTextBox
            // 
            this.LeaderLastNameTextBox.Location = new System.Drawing.Point(384, 60);
            this.LeaderLastNameTextBox.Name = "LeaderLastNameTextBox";
            this.LeaderLastNameTextBox.Size = new System.Drawing.Size(248, 26);
            this.LeaderLastNameTextBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(380, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Prenume";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Nume";
            // 
            // LeaderFirstNameTextbox
            // 
            this.LeaderFirstNameTextbox.Location = new System.Drawing.Point(45, 60);
            this.LeaderFirstNameTextbox.Name = "LeaderFirstNameTextbox";
            this.LeaderFirstNameTextbox.Size = new System.Drawing.Size(244, 26);
            this.LeaderFirstNameTextbox.TabIndex = 2;
            // 
            // SubdivisionGroupBox
            // 
            this.SubdivisionGroupBox.Controls.Add(this.SubdivizionPhoneTextBox);
            this.SubdivisionGroupBox.Controls.Add(this.label10);
            this.SubdivisionGroupBox.Controls.Add(this.label12);
            this.SubdivisionGroupBox.Controls.Add(this.SubdivisionNameTextBox);
            this.SubdivisionGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubdivisionGroupBox.Location = new System.Drawing.Point(35, 452);
            this.SubdivisionGroupBox.Name = "SubdivisionGroupBox";
            this.SubdivisionGroupBox.Size = new System.Drawing.Size(668, 115);
            this.SubdivisionGroupBox.TabIndex = 12;
            this.SubdivisionGroupBox.TabStop = false;
            this.SubdivisionGroupBox.Text = "Date Subdiviziune noua";
            // 
            // SubdivizionPhoneTextBox
            // 
            this.SubdivizionPhoneTextBox.Location = new System.Drawing.Point(384, 60);
            this.SubdivizionPhoneTextBox.Name = "SubdivizionPhoneTextBox";
            this.SubdivizionPhoneTextBox.Size = new System.Drawing.Size(248, 26);
            this.SubdivizionPhoneTextBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(380, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nr. de telefon:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Denumire:";
            // 
            // SubdivisionNameTextBox
            // 
            this.SubdivisionNameTextBox.Location = new System.Drawing.Point(45, 60);
            this.SubdivisionNameTextBox.Name = "SubdivisionNameTextBox";
            this.SubdivisionNameTextBox.Size = new System.Drawing.Size(244, 26);
            this.SubdivisionNameTextBox.TabIndex = 2;
            this.SubdivisionNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SubdivisionNameTextBox_Validating);
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(1287, 663);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(96, 28);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ObjectPhoneTextBox);
            this.groupBox3.Controls.Add(this.ObjectAddressTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ObjectNameTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(983, 120);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date Obiect Autorizat";
            // 
            // ObjectPhoneTextBox
            // 
            this.ObjectPhoneTextBox.Location = new System.Drawing.Point(726, 54);
            this.ObjectPhoneTextBox.Name = "ObjectPhoneTextBox";
            this.ObjectPhoneTextBox.Size = new System.Drawing.Size(248, 26);
            this.ObjectPhoneTextBox.TabIndex = 11;
            // 
            // ObjectAddressTextBox
            // 
            this.ObjectAddressTextBox.Location = new System.Drawing.Point(384, 54);
            this.ObjectAddressTextBox.Name = "ObjectAddressTextBox";
            this.ObjectAddressTextBox.Size = new System.Drawing.Size(248, 26);
            this.ObjectAddressTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(722, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nr. de telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Adresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Denumire:";
            // 
            // ObjectNameTextBox
            // 
            this.ObjectNameTextBox.Location = new System.Drawing.Point(45, 54);
            this.ObjectNameTextBox.Name = "ObjectNameTextBox";
            this.ObjectNameTextBox.Size = new System.Drawing.Size(244, 26);
            this.ObjectNameTextBox.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AgentPhoneTextBox);
            this.groupBox2.Controls.Add(this.AgentAddressTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AgentNameTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 110);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Agent Economic";
            // 
            // AgentPhoneTextBox
            // 
            this.AgentPhoneTextBox.Location = new System.Drawing.Point(726, 59);
            this.AgentPhoneTextBox.Name = "AgentPhoneTextBox";
            this.AgentPhoneTextBox.Size = new System.Drawing.Size(248, 26);
            this.AgentPhoneTextBox.TabIndex = 10;
            // 
            // AgentAddressTextBox
            // 
            this.AgentAddressTextBox.Location = new System.Drawing.Point(384, 59);
            this.AgentAddressTextBox.Name = "AgentAddressTextBox";
            this.AgentAddressTextBox.Size = new System.Drawing.Size(248, 26);
            this.AgentAddressTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(722, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nr. de telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adresa agentului";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Denumirea agentului";
            // 
            // AgentNameTextBox
            // 
            this.AgentNameTextBox.Location = new System.Drawing.Point(45, 59);
            this.AgentNameTextBox.Name = "AgentNameTextBox";
            this.AgentNameTextBox.Size = new System.Drawing.Size(248, 26);
            this.AgentNameTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExpirationDateTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EliberationDateTime);
            this.groupBox1.Controls.Add(this.ASVFLabel);
            this.groupBox1.Controls.Add(this.ASVFTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Autorizatie";
            // 
            // ExpirationDateTime
            // 
            this.ExpirationDateTime.Location = new System.Drawing.Point(726, 62);
            this.ExpirationDateTime.Name = "ExpirationDateTime";
            this.ExpirationDateTime.Size = new System.Drawing.Size(248, 26);
            this.ExpirationDateTime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(722, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valabil pina la";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data eliberarii";
            // 
            // EliberationDateTime
            // 
            this.EliberationDateTime.Location = new System.Drawing.Point(384, 62);
            this.EliberationDateTime.Name = "EliberationDateTime";
            this.EliberationDateTime.Size = new System.Drawing.Size(248, 26);
            this.EliberationDateTime.TabIndex = 4;
            // 
            // ASVFLabel
            // 
            this.ASVFLabel.AutoSize = true;
            this.ASVFLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASVFLabel.Location = new System.Drawing.Point(41, 37);
            this.ASVFLabel.Name = "ASVFLabel";
            this.ASVFLabel.Size = new System.Drawing.Size(83, 19);
            this.ASVFLabel.TabIndex = 3;
            this.ASVFLabel.Text = "Seria ASVF";
            // 
            // ASVFTextBox
            // 
            this.ASVFTextBox.Location = new System.Drawing.Point(45, 62);
            this.ASVFTextBox.Name = "ASVFTextBox";
            this.ASVFTextBox.Size = new System.Drawing.Size(248, 26);
            this.ASVFTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTORIZATIE SANITAR VETERINARA DE FUNCTIONARE";
            // 
            // SearchTab
            // 
            this.SearchTab.AutoScroll = true;
            this.SearchTab.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTab.Controls.Add(this.SaveButton);
            this.SearchTab.Controls.Add(this.label22);
            this.SearchTab.Controls.Add(this.SubdivisionsComboBoxISearchTab);
            this.SearchTab.Controls.Add(this.label21);
            this.SearchTab.Controls.Add(this.ObjectSearchBox);
            this.SearchTab.Controls.Add(this.AgentSearchBox);
            this.SearchTab.Controls.Add(this.label20);
            this.SearchTab.Controls.Add(this.label19);
            this.SearchTab.Controls.Add(this.label18);
            this.SearchTab.Controls.Add(this.ASVFSearchBox);
            this.SearchTab.Controls.Add(this.label17);
            this.SearchTab.Controls.Add(this.label16);
            this.SearchTab.Controls.Add(this.label15);
            this.SearchTab.Controls.Add(this.ExpirationDateSearch);
            this.SearchTab.Controls.Add(this.EliberationDateSearch);
            this.SearchTab.Controls.Add(this.SearchButton);
            this.SearchTab.Controls.Add(this.dataGridView);
            this.SearchTab.Location = new System.Drawing.Point(4, 22);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(1426, 735);
            this.SearchTab.TabIndex = 1;
            this.SearchTab.Text = "Cautare Autorizatie";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(173, 496);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Salveaza";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 411);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 19);
            this.label22.TabIndex = 15;
            this.label22.Text = "Subdiviziune";
            // 
            // SubdivisionsComboBoxISearchTab
            // 
            this.SubdivisionsComboBoxISearchTab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubdivisionsComboBoxISearchTab.FormattingEnabled = true;
            this.SubdivisionsComboBoxISearchTab.Location = new System.Drawing.Point(6, 433);
            this.SubdivisionsComboBoxISearchTab.Name = "SubdivisionsComboBoxISearchTab";
            this.SubdivisionsComboBoxISearchTab.Size = new System.Drawing.Size(242, 27);
            this.SubdivisionsComboBoxISearchTab.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(395, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(669, 26);
            this.label21.TabIndex = 12;
            this.label21.Text = "AUTORIZATIE SANITAR VETERINARA DE FUNCTIONARE";
            // 
            // ObjectSearchBox
            // 
            this.ObjectSearchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectSearchBox.Location = new System.Drawing.Point(6, 305);
            this.ObjectSearchBox.Name = "ObjectSearchBox";
            this.ObjectSearchBox.Size = new System.Drawing.Size(242, 26);
            this.ObjectSearchBox.TabIndex = 11;
            // 
            // AgentSearchBox
            // 
            this.AgentSearchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentSearchBox.Location = new System.Drawing.Point(6, 372);
            this.AgentSearchBox.Name = "AgentSearchBox";
            this.AgentSearchBox.Size = new System.Drawing.Size(242, 26);
            this.AgentSearchBox.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 216);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 19);
            this.label20.TabIndex = 9;
            this.label20.Text = "Seria ASVF";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 19);
            this.label19.TabIndex = 8;
            this.label19.Text = "Nume agent ecomomic";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 283);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 19);
            this.label18.TabIndex = 7;
            this.label18.Text = "Nume obiect autorzat";
            // 
            // ASVFSearchBox
            // 
            this.ASVFSearchBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASVFSearchBox.Location = new System.Drawing.Point(6, 238);
            this.ASVFSearchBox.Name = "ASVFSearchBox";
            this.ASVFSearchBox.Size = new System.Drawing.Size(242, 26);
            this.ASVFSearchBox.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 19);
            this.label17.TabIndex = 5;
            this.label17.Text = "De la";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 19);
            this.label16.TabIndex = 4;
            this.label16.Text = "Pina la";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Alegeti datele pentru cautare";
            // 
            // ExpirationDateSearch
            // 
            this.ExpirationDateSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateSearch.Location = new System.Drawing.Point(8, 169);
            this.ExpirationDateSearch.Name = "ExpirationDateSearch";
            this.ExpirationDateSearch.Size = new System.Drawing.Size(240, 26);
            this.ExpirationDateSearch.TabIndex = 2;
            // 
            // EliberationDateSearch
            // 
            this.EliberationDateSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliberationDateSearch.Location = new System.Drawing.Point(8, 104);
            this.EliberationDateSearch.Name = "EliberationDateSearch";
            this.EliberationDateSearch.Size = new System.Drawing.Size(240, 26);
            this.EliberationDateSearch.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(81, 496);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Afiseaza";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(272, 48);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1131, 651);
            this.dataGridView.TabIndex = 0;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1434, 761);
            this.Controls.Add(this.Tab);
            this.Name = "AuthorizationForm";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.Tab.ResumeLayout(false);
            this.InsertTab.ResumeLayout(false);
            this.InsertTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.SubdivisionLeaderGroupBox.ResumeLayout(false);
            this.SubdivisionLeaderGroupBox.PerformLayout();
            this.SubdivisionGroupBox.ResumeLayout(false);
            this.SubdivisionGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SearchTab.ResumeLayout(false);
            this.SearchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage InsertTab;
        private System.Windows.Forms.TabPage SearchTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ASVFLabel;
        private System.Windows.Forms.TextBox ASVFTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EliberationDateTime;
        private System.Windows.Forms.DateTimePicker ExpirationDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AgentNameTextBox;
        private System.Windows.Forms.TextBox AgentPhoneTextBox;
        private System.Windows.Forms.TextBox AgentAddressTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ObjectAddressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ObjectNameTextBox;
        private System.Windows.Forms.TextBox ObjectPhoneTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox SubdivisionGroupBox;
        private System.Windows.Forms.TextBox SubdivizionPhoneTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SubdivisionNameTextBox;
        private System.Windows.Forms.GroupBox SubdivisionLeaderGroupBox;
        private System.Windows.Forms.TextBox LeaderLastNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox LeaderFirstNameTextbox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckedListBox ActivityListInsertTab;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DateTimePicker ExpirationDateSearch;
        private System.Windows.Forms.DateTimePicker EliberationDateSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ObjectSearchBox;
        private System.Windows.Forms.TextBox AgentSearchBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ASVFSearchBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox SubdivisionsComboBoxISearchTab;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox SubdivisionsComboBoxInsertTab;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

