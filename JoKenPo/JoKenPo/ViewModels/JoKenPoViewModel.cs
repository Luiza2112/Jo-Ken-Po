
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using JoKenPo.Models;

namespace JoKenPo.ViewModels
{
    public partial class JoKenPoViewModel : ObservableObject
	{
        [ObservableProperty]
        private string imagem1;

        [ObservableProperty]
        public string pontuacao1;

        [ObservableProperty]
        public string imagem2;

        [ObservableProperty]
        public string pontuacao2;

        [ObservableProperty]
        public string resultado;

        [ObservableProperty]
        public string escolha;

        public ICommand JogarCommand { get; }

        public JoKenPoViewModel()
        {
            JogarCommand = new Command(Jogar);
            Pontuacao1 = contUser.ToString();
            Pontuacao2 = contOponent.ToString();

        }

        int contUser = 0;
        int contOponent = 0;

        public void Jogar()
        {
            Play play = new Play();
            play.Jogar();
            Imagem1 = $"{Escolha}.png";
            Imagem2 = $"{play.OpcaoSorteada}.png";

            if(Escolha == play.OpcaoSorteada)
            {
                Pontuacao1 = Pontuacao1;
                Pontuacao2 = Pontuacao2;
            }
            else if (( Escolha == "Papel" && play.OpcaoSorteada == "Tesoura") || (Escolha == "Pedra" && play.OpcaoSorteada == "Papel") || (Escolha == "Tesoura" && play.OpcaoSorteada == "Pedra"))
            {
                Pontuacao2 = (contOponent = contOponent + 1).ToString();
                if(Pontuacao2 == "10")
                {
                    Resultado = "Você perdeu :(";
                }
            }
            else if ((Escolha == "Tesoura" && play.OpcaoSorteada == "Papel") || (Escolha == "Papel" && play.OpcaoSorteada == "Pedra") || (Escolha == "Pedra" && play.OpcaoSorteada == "Tesoura"))
            {
                Pontuacao1 = (contUser = contUser + 1).ToString();
                if (Pontuacao1 == "10")
                {
                    Resultado = "Você venceu :)";
                }
            }
        }

    }

}