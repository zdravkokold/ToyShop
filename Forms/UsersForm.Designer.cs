namespace ToyShop.Forms
{
    partial class UsersForm
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
            usersGridView = new DataGridView();
            editButton = new Button();
            deleteButton = new Button();
            nameTextBox = new TextBox();
            addressTextBox = new TextBox();
            emailTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            saveButton = new Button();
            formPanel = new Panel();
            fullNameTextBox = new TextBox();
            label5 = new Label();
            phoneTextBox = new TextBox();
            label6 = new Label();
            filterTextBox = new TextBox();
            filterButton = new Button();
            label4 = new Label();
            salesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)usersGridView).BeginInit();
            formPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usersGridView
            // 
            usersGridView.BackgroundColor = SystemColors.ActiveCaption;
            usersGridView.BorderStyle = BorderStyle.None;
            usersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersGridView.Cursor = Cursors.Hand;
            usersGridView.Location = new Point(12, 88);
            usersGridView.Name = "usersGridView";
            usersGridView.ReadOnly = true;
            usersGridView.RowHeadersWidth = 62;
            usersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersGridView.Size = new Size(854, 212);
            usersGridView.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Location = new Point(299, 367);
            editButton.Name = "editButton";
            editButton.Size = new Size(135, 56);
            editButton.TabIndex = 1;
            editButton.Text = "Редактирай";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(445, 367);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(135, 56);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Изтрий";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(31, 145);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(212, 31);
            nameTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(280, 52);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(234, 31);
            addressTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(555, 52);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(239, 31);
            emailTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 110);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 9;
            label1.Text = "Потребителско име";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 17);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 10;
            label2.Text = "Адрес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 17);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 11;
            label3.Text = "Имейл";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(348, 180);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(135, 56);
            saveButton.TabIndex = 12;
            saveButton.Text = "Запази";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // formPanel
            // 
            formPanel.Controls.Add(fullNameTextBox);
            formPanel.Controls.Add(label5);
            formPanel.Controls.Add(phoneTextBox);
            formPanel.Controls.Add(label6);
            formPanel.Controls.Add(nameTextBox);
            formPanel.Controls.Add(saveButton);
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(label3);
            formPanel.Controls.Add(addressTextBox);
            formPanel.Controls.Add(emailTextBox);
            formPanel.Controls.Add(label2);
            formPanel.Location = new Point(23, 442);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(834, 242);
            formPanel.TabIndex = 13;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(31, 52);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(212, 31);
            fullNameTextBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 17);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 15;
            label5.Text = "Име и фамилия";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(555, 145);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(234, 31);
            phoneTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 110);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 16;
            label6.Text = "Телефон";
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(122, 27);
            filterTextBox.Multiline = true;
            filterTextBox.Name = "filterTextBox";
            filterTextBox.Size = new Size(552, 39);
            filterTextBox.TabIndex = 13;
            // 
            // filterButton
            // 
            filterButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterButton.Location = new Point(680, 27);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(44, 42);
            filterButton.TabIndex = 13;
            filterButton.Text = "🔍";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 30);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 13;
            label4.Text = "Търсене:";
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesLabel.ForeColor = Color.Green;
            salesLabel.Location = new Point(289, 325);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new Size(263, 28);
            salesLabel.TabIndex = 15;
            salesLabel.Text = "Общо продажби: 0.00 лв.";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(878, 694);
            Controls.Add(salesLabel);
            Controls.Add(label4);
            Controls.Add(filterButton);
            Controls.Add(filterTextBox);
            Controls.Add(formPanel);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(usersGridView);
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Потребители";
            ((System.ComponentModel.ISupportInitialize)usersGridView).EndInit();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usersGridView;
        private Button editButton;
        private Button deleteButton;
        private TextBox nameTextBox;
        private TextBox addressTextBox;
        private TextBox emailTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveButton;
        private Panel formPanel;
        private TextBox filterTextBox;
        private Button filterButton;
        private Label label4;
        private TextBox fullNameTextBox;
        private Label label5;
        private TextBox phoneTextBox;
        private Label label6;
        private Label salesLabel;
    }
}