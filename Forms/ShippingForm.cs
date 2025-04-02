using ToyShop.Entities;

namespace ToyShop.Forms
{
    public partial class ShippingForm : Form
    {
        public string FullName { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }

        public ShippingForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Моля, попълнете всички полета!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = Session.CurrentUser;

            FullName = nameTextBox.Text;
            Address = addressTextBox.Text;
            PhoneNumber = phoneTextBox.Text;
            Email = emailTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
