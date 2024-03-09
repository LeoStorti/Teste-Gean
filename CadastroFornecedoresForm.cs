using System;
using System.Windows.Forms;

namespace SeuNamespace
{
    public partial class CadastroFornecedoresForm : Form
    {
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;

        public CadastroFornecedoresForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();

            // Configuração dos componentes
            this.SuspendLayout();

            // btnNovo
            this.btnNovo.Location = new System.Drawing.Point(50, 50);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.Text = "Novo";
            this.Controls.Add(this.btnNovo);

            // btnEditar
            this.btnEditar.Location = new System.Drawing.Point(150, 50);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.Text = "Editar";
            this.Controls.Add(this.btnEditar);

            // btnExcluir
            this.btnExcluir.Location = new System.Drawing.Point(250, 50);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.Text = "Excluir";
            this.Controls.Add(this.btnExcluir);

            this.ResumeLayout(false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo fornecedor
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Lógica para editar um fornecedor selecionado
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Lógica para excluir um fornecedor selecionado
        }
    }
}
