using ToyShop.Entities;

namespace ToyShop.Forms
{
    public partial class UsersForm : Form
    {
        private readonly ShopService shopService;
        private User selectedUser;

        public UsersForm(ShopService shopService)
        {
            InitializeComponent();
            this.shopService = shopService;
            CalculateSales();
            LoadUsers();
            formPanel.Visible = false;
        }

        private void LoadUsers()
        {
            usersGridView.DataSource = shopService.GetUsers();

            usersGridView.Columns["Id"].Visible = false;
            HideColumns("Id", "NormalizedUserName", "NormalizedEmail", "EmailConfirmed",
                        "SecurityStamp", "ConcurrencyStamp", "PhoneNumberConfirmed", "PasswordHash",
                        "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount");

            usersGridView.Columns["UserName"].HeaderText = "Потребителско име";
            usersGridView.Columns["Email"].HeaderText = "Имейл";
            usersGridView.Columns["PhoneNumber"].HeaderText = "Телефон";
        }

        private void CalculateSales()
        { 
            decimal sales = shopService.GetTotalSales();
            salesLabel.Text = $"Общо продажби: {sales:F2} лв.";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Моля, изберете потребител за редактиране.");
                return;
            }

            string? userId = usersGridView.SelectedRows[0].Cells["Id"].Value.ToString();
            selectedUser = shopService.GetUserById(userId);

            nameTextBox.Text = selectedUser.UserName;
            emailTextBox.Text = selectedUser.Email;
            fullNameTextBox.Text = selectedUser.FullName;
            phoneTextBox.Text = selectedUser.PhoneNumber;
            addressTextBox.Text = selectedUser.Address;

            formPanel.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Моля, изберете потребител за изтриване.");
                return;
            }

            string? userId = usersGridView.SelectedRows[0].Cells["Id"].Value.ToString();
            var result = MessageBox.Show("Сигурни ли сте, че искате да изтриете този потребител?", "Потвърждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                shopService.DeleteUser(userId);
                LoadUsers();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(fullNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                MessageBox.Show("Моля, попълнете всички полета.");
                return;
            }

            if (selectedUser != null)
            {
                selectedUser.UserName = nameTextBox.Text;
                selectedUser.FullName = fullNameTextBox.Text;
                selectedUser.PhoneNumber = phoneTextBox.Text;
                selectedUser.Email = emailTextBox.Text;
                selectedUser.Address = addressTextBox.Text;

                shopService.UpdateUser(selectedUser);
            }

            formPanel.Visible = false;
            LoadUsers();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string filter = filterTextBox.Text.ToLower();

            List<User> filteredData = shopService.GetUsers()
                .Where(u => u.UserName.ToLower().Contains(filter)
                || u.Email.ToLower().Contains(filter)
                || u.PhoneNumber.ToLower().Contains(filter)
                || u.FullName.ToLower().Contains(filter)
                || u.Address.ToLower().Contains(filter))
                .ToList();

            usersGridView.DataSource = filteredData;
        }

        private void HideColumns(params string[] columns)
        {
            foreach (var column in columns)
            {
                if (usersGridView.Columns[column] != null)
                {
                    usersGridView.Columns[column].Visible = false;
                }
            }
        }
    }
}
