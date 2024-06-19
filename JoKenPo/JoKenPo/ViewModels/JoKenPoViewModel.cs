
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace JoKenPo.ViewModels
{
    public partial class JoKenPoViewModel : ObservableObject
	{
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        public string escolha;

        [ObservableProperty]
        public string pontuacaoU;

        [ObservableProperty]
        public string pontuacaoO;

        public ICommand JogarCommand { get; }

        public void JoKenPoViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            JoKenPo jokenpo = new JoKenPo();

            if(escolha == 'Papel' && JoKenPo.OpcaoSorteada == 'Tesoura' || escolha == 'Pedra' && JoKenPo.OpcaoSorteada == 'Papel' || escolha = 'Tesoura' && JoKenPo.OpcaoSorteada == 'Pedra')
            {
                pontuacaoO += 1;
            }
            else if (escolha == 'Tesoura' && JoKenPo.OpcaoSorteada == 'Papel' || escolha == 'Papel' && JoKenPo.OpcaoSorteada == 'Pedra' || escolha = 'Pedra' && JoKenPo.OpcaoSorteada == 'Tesoura')
            {
                pontuacaoU += 1;
            }
        }

    }

}