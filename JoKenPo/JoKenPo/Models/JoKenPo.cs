namespace JoKenPo.Models
{
	public class JoKenPo
	{
        public string OpcaoEscolhida { get; set; }
        public string OpcaoSorteada { get; set; }

        public JoKenPo()
		{

		}
        
        public string Jogar()
		{
			string OpcaoEscolhida = Convert.ToString(OpcoesPicker.SelectedItem);
			int Opcao = new Random().Next(3);

			if (Opcao == 1)
			{
				OpcaoSorteada = "Pedra";
			}
			else if(Opcao == 2)
			{
				OpcaoSorteada = "Papel";
			}
			else if(Opcao == 3)
			{
				OpcaoSorteada = "Tesoura";
			}

			return OpcaoSorteada;
		}
	}
}