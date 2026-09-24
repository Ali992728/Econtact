namespace Econtact
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            pictureBoxLogo = new PictureBox();
            lblContactID = new Label();
            txtboxContactID = new TextBox();
            txtboxFirstName = new TextBox();
            lblFirstName = new Label();
            txtboxLastName = new TextBox();
            lblLastName = new Label();
            txtboxContactNumber = new TextBox();
            lblContactNo = new Label();
            txtboxAddress = new TextBox();
            lblAddress = new Label();
            lblGender = new Label();
            comboxGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvContactList = new DataGridView();
            lblSearch = new Label();
            txtboxSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(814, 24);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(511, 228);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.BackColor = Color.Transparent;
            lblContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactID.Location = new Point(125, 344);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(210, 54);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "Contact ID";
            // 
            // txtboxContactID
            // 
            txtboxContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxContactID.Location = new Point(386, 344);
            txtboxContactID.Name = "txtboxContactID";
            txtboxContactID.ReadOnly = true;
            txtboxContactID.Size = new Size(585, 61);
            txtboxContactID.TabIndex = 2;
            txtboxContactID.TextChanged += txtboxContactID_TextChanged;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxFirstName.Location = new Point(386, 470);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(585, 61);
            txtboxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(125, 470);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(214, 54);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            // 
            // txtboxLastName
            // 
            txtboxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxLastName.Location = new Point(386, 612);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(585, 61);
            txtboxLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(125, 612);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(209, 54);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtboxContactNumber
            // 
            txtboxContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxContactNumber.Location = new Point(386, 767);
            txtboxContactNumber.Name = "txtboxContactNumber";
            txtboxContactNumber.Size = new Size(585, 61);
            txtboxContactNumber.TabIndex = 8;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNo.Location = new Point(125, 767);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(233, 54);
            lblContactNo.TabIndex = 7;
            lblContactNo.Text = "Contact No.";
            // 
            // txtboxAddress
            // 
            txtboxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxAddress.Location = new Point(386, 914);
            txtboxAddress.Multiline = true;
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(585, 159);
            txtboxAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(125, 914);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(166, 54);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(125, 1168);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(153, 54);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender";
            lblGender.Click += label1_Click;
            // 
            // comboxGender
            // 
            comboxGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboxGender.FormattingEnabled = true;
            comboxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboxGender.Location = new Point(386, 1160);
            comboxGender.Name = "comboxGender";
            comboxGender.Size = new Size(585, 62);
            comboxGender.TabIndex = 12;
            comboxGender.SelectedIndexChanged += comboxGender_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(424, 1323);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(263, 75);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSeaGreen;
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(779, 1323);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(263, 75);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1139, 1323);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(263, 75);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkOrange;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(1512, 1323);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(263, 75);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvContactList
            // 
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Location = new Point(1189, 470);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.RowHeadersWidth = 102;
            dgvContactList.Size = new Size(791, 752);
            dgvContactList.TabIndex = 17;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(1152, 368);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(140, 54);
            lblSearch.TabIndex = 18;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(1309, 361);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(671, 61);
            txtboxSearch.TabIndex = 19;
            txtboxSearch.TextChanged += txtboxSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2016, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2155, 1464);
            Controls.Add(pictureBox1);
            Controls.Add(txtboxSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvContactList);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(comboxGender);
            Controls.Add(lblGender);
            Controls.Add(txtboxAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtboxContactNumber);
            Controls.Add(lblContactNo);
            Controls.Add(txtboxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtboxFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtboxContactID);
            Controls.Add(lblContactID);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Econtact";
            Text = "Econtact";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label lblContactID;
        private TextBox txtboxContactID;
        private TextBox txtboxFirstName;
        private Label lblFirstName;
        private TextBox txtboxLastName;
        private Label lblLastName;
        private TextBox txtboxContactNumber;
        private Label lblContactNo;
        private TextBox txtboxAddress;
        private Label lblAddress;
        private Label lblGender;
        private ComboBox comboxGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvContactList;
        private Label lblSearch;
        private TextBox txtboxSearch;
        private PictureBox pictureBox1;
    }
}
