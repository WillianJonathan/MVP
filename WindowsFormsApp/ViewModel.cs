using Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Core.Model.Pessoa;

namespace WindowsFormsApp
{
    public class ViewModel :INotifyPropertyChanged
    {
        public ViewModel()
        {
            Pessoa = new PessoaModel();
            Pessoas = new BindingList<PessoaModel>();
            Pessoas.Add(new PessoaModel() { Id = 1, Codigo = "123", NomeRazaoSocial = "Joao" });
            Pessoas.Add(new PessoaModel() { Id = 2, Codigo = "1234", NomeRazaoSocial = "Pedro" });
        }

        public PessoaModel Pessoa { get; set; }
        private BindingList<PessoaModel> _pessoas;
        public BindingList<PessoaModel> Pessoas
        {
            get { return _pessoas; }
            set
            {
                _pessoas = value;
                RaisePropertyChanged();
            }
        }

        public void Salvar()
        {

            if (Pessoa.Id > 0)
            {
                var index = Pessoas.IndexOf(Pessoas.Where(x => x.Id == Pessoa.Id).FirstOrDefault());
                Pessoas[index].Codigo = Pessoa.Codigo;
                Pessoas[index].NomeRazaoSocial = Pessoa.NomeRazaoSocial;
            }
            else
            {
                Pessoa.Id = Pessoas.Count + 1;
                Pessoas.Add(Pessoa);
            }

            Pessoa = new PessoaModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
