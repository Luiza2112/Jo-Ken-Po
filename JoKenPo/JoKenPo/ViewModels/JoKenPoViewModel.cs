
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public int pontuacaoUser;

        [ObservableProperty]
        public int pontuacaoOponent;

        [ObservableProperty]
        public string imageUser;

        [ObservableProperty]
        public string imageOponent;

        public ICommand JogarCommand { get; }

        public JoKenPoViewModel()
        {
            JogarCommand = new Command(Jogar);
        
        }

        public void Jogar()
        {
            JoKenPoViewModel jokenpo = new JoKenPoViewModel();
            jokenpo.Jogar();
            int pontuacaoOponent = 0;
            int pontuacaoUser = 0;

            if (Escolha == "Papel" && OpcaoSorteada == "Tesoura" || Escolha == "Pedra" && OpcaoSorteada == "Papel" || Escolha = "Tesoura" && OpcaoSorteada == "Pedra")
            {
                pontuacaoOponent += 1;
            }
            else if (Escolha == "Tesoura" && OpcaoSorteada == "Papel" || Escolha == "Papel" && OpcaoSorteada == "Pedra" || Escolha = "Pedra" && OpcaoSorteada == "Tesoura")
            {
                pontuacaoUser += 1;
            }
        }

    }

}