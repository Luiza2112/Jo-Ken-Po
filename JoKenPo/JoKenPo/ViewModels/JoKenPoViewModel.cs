
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

        public ICommand JogarCommand { get; }

        public JoKenPoViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        public void Jogar()
        {
            JoKenPo jokenpo = new JoKenPo();
            jokenpo.Jogar();

            if(Escolha == "Papel" && OpcaoSorteada == "Tesoura" || Escolha == "Pedra" && JoKenPo.OpcaoSorteada == "Papel" || Escolha = "Tesoura" && JoKenPo.OpcaoSorteada == "Pedra")
            {
                pontuacaoOponent += 1;
            }
            else if (escolha == "Tesoura" && JoKenPo.OpcaoSorteada == "Papel" || escolha == "Papel" && JoKenPo.OpcaoSorteada == "Pedra" || escolha = "Pedra" && JoKenPo.OpcaoSorteada == "Tesoura")
            {
                pontuacaoUser += 1;
            }
        }

    }

}