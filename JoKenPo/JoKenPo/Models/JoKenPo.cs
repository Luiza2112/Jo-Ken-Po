namespace JoKenPo.Models
{
	public class JoKenPo
	{
        public string OpcoesPicker { get; set; }
        public string OpcaoSorteada { get; set; }

        public JoKenPo()
		{

		}
        
        public string Jogar()
		{
            string OpcaoEscolhida = OpcoesPicker;
            string OpcaoSorteada = null;
            int Opcao = new Random().Next(3);

			if (Opcao == 0)
			{
				OpcaoSorteada = "Pedra";
			}
			else if(Opcao == 1)
			{
				OpcaoSorteada = "Papel";
			}
			else if(Opcao == 2)
			{
				OpcaoSorteada = "Tesoura";
			}

			return OpcaoSorteada;
		}
	}
}