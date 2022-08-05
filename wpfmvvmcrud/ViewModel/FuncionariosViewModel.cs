using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfmvvmcrud.Model;

namespace wpfmvvmcrud.ViewModel
{
    public class FuncionariosViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Funcionario> Funcionarios { get; private set; }

        private Funcionario _funcionarioSelecionado;
        public Funcionario FuncionarioSelecionado
        {
            get { return _funcionarioSelecionado; }
            set 
            { 
                SetField(ref _funcionarioSelecionado, value);
                Deletar.RaiseCanExecuteChanged();
                Editar.RaiseCanExecuteChanged();
            }
        }

        public FuncionariosViewModel()
        {
            Funcionarios = new ObservableCollection<Funcionario>();
            Funcionarios.Add(new Funcionario()
            {
                Id = 1,
                Nome = "Felipe",
                Sobrenome = "Alves",
                DataNascimento = new DateTime(1991, 08, 21),
                DataAdmissao = new DateTime(2021, 08, 06),
                EstadoCivil = EstadoCivil.Casado,
                Sexo = Sexo.Masculino
            });

            FuncionarioSelecionado = Funcionarios.First();
        }

        public DeletarCommand Deletar { get; private set; } = new DeletarCommand();

        public NovoCommand Novo { get; private set; } = new NovoCommand();

        public EditarCommand Editar { get; private set; } = new EditarCommand();

    }
}
