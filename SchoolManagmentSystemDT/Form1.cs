namespace SchoolManagmentSystemDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var emailAddress = txtEmailAddress.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(emailAddress) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Email Address And Password Is Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (emailAddress == "admin" && password == "123456")
            {
                this.Hide();
                var main = new Main();
                main.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var di = MessageBox.Show("Are you sure you want to exit ?","Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (di == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
