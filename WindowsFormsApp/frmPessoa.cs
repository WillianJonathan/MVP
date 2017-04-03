using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmPessoa : Form
    {

        private Core.Repository.Pessoa.PessoaRepository _pessoaRepository = new Core.Repository.Pessoa.PessoaRepository();
        private Core.Model.Pessoa.Pessoa _pessoa = new Core.Model.Pessoa.Pessoa();

        public frmPessoa()
        {
            InitializeComponent();

        }

        private void frmPessoa_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (!string.IsNullOrEmpty(txtId.Text.Trim()))
                id = Convert.ToInt32(txtId.Text);

            var pessoa = new Core.Model.Pessoa.Pessoa()
            {
                Id = id,
                Codigo = txtCodigo.Text,
                NomeRazaoSocial = txtNome.Text
            };

            _pessoaRepository.Add(pessoa);

            CarregarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _pessoaRepository.Remove(_pessoa);
            _pessoa = new Core.Model.Pessoa.Pessoa();
            CarregarGrid();
        }

        private void dvgPessoas_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgPessoas.Rows.Count > 0 && dvgPessoas.SelectedRows != null && dvgPessoas.SelectedRows.Count > 0)
            {
                _pessoa = _pessoaRepository.Get(Convert.ToInt32(dvgPessoas.SelectedRows[0].Cells[0].Value));
                AlterarCampos();
            }
        }

        void AlterarCampos()
        {
            txtId.Text = _pessoa.Id.ToString();
            txtCodigo.Text = _pessoa.Codigo;
            txtNome.Text = _pessoa.NomeRazaoSocial;
        }

        void CarregarGrid()
        {
            dvgPessoas.SelectionChanged -= dvgPessoas_SelectionChanged;

            dvgPessoas.DataSource = _pessoaRepository.GetAll();

            dvgPessoas.SelectionChanged += dvgPessoas_SelectionChanged;
            dvgPessoas_SelectionChanged(this, null);
        }


    }
}
