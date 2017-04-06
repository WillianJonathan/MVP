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
    public partial class Form1 : Form
    {
        public Form1()
        {
            _viewModel = new ViewModel();
            InitializeComponent();

        }
        private ViewModel _viewModel { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {


            txtId.DataBindings.Add("Text", _viewModel.Pessoa, "Id", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCodigo.DataBindings.Add("Text", _viewModel.Pessoa, "Codigo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNome.DataBindings.Add("Text", _viewModel.Pessoa, "NomeRazaoSocial", false, DataSourceUpdateMode.OnPropertyChanged);
            //dgvPessoas.DataSource = new BindingSource() { DataSource = _viewModel.Pessoas };
            //dgvPessoas.DataBindings.Add("DataSource", _viewModel,"Pessoas" , false, DataSourceUpdateMode.OnPropertyChanged);
            //txtId.DataBindings.Add("Text", dgvPessoas, "SelectedRows[0][1]", false, DataSourceUpdateMode.OnValidation);

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = DateTime.Now;
            Console.WriteLine(dataInicio.ToString() + " - Inicio");
            txtNome.Text = await Criptografar(txtCodigo.Text, Convert.ToInt32(txtId.Text));
            Console.WriteLine(DateTime.Now.ToString() + " - Termino");
            Console.WriteLine("Fator de Esforço " + txtId.Text);
            Console.WriteLine("Tempo decorido em segundos : " + (dataInicio - DateTime.Now).ToString());

            //_viewModel.Salvar();
        }

        private async Task<string> Criptografar(string password, int esforco)
        {

            Task<string> first = Task.Run(() => BCrypt.Net.BCrypt.HashPassword(password, esforco));
            await first;
            return first.Result;
        }

        private async Task<bool> Verficar(string password, string hash)
        {
            Task<bool> first = Task.Run(() => BCrypt.Net.BCrypt.Verify(password, hash));
            //var a = await Criptografar(password, Convert.ToInt32(txtId.Text));
            await first;

            return first.Result;
        }

        //private void dgvPessoas_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvPessoas.SelectedRows.Count > 0 && dgvPessoas.Rows.Count > 0)
        //    {

        //        txtId.Text = Convert.ToString(dgvPessoas.SelectedRows[0].Cells[0].Value);
        //        txtCodigo.Text = Convert.ToString(dgvPessoas.SelectedRows[0].Cells[1].Value);
        //        txtNome.Text = Convert.ToString(dgvPessoas.SelectedRows[0].Cells[2].Value);

        //    }
        //}

        private async void btnLimpar_Click(object sender, EventArgs e)
        {
            var b = BCrypt.Net.BCrypt.GenerateSalt(13, BCrypt.Net.SaltRevision.Revision2B);
            var c = BCrypt.Net.BCrypt.HashPassword("123", b);
            var a = await Verficar("123", c);
            lblResultado.Text = a ? "Válido" : "Incorreto";
        }
    }
}
