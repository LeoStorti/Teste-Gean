using System;
using System.Windows.Forms;

namespace SeuNamespace
{
    public partial class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += new EventHandler(btnLogin_Click); // Verifique se essa linha está presente

        }

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();

            // Configuração dos componentes
            this.SuspendLayout();

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(50, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtUsername);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(50, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(this.txtPassword);

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(50, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.Controls.Add(this.btnLogin);

            this.ResumeLayout(false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lógica de autenticação
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Aqui você faria a verificação das credenciais com seus dados de autenticação
            if (username == "usuario" && password == "senha")
            {
                // Se as credenciais forem válidas, você pode abrir o MainForm ou outra tela principal
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Por favor, tente novamente.");
            }
        }
    }
}
