namespace JoKenPo.Models
{
	public class Play
	{
        public string OpcaoSorteada { get; set; }

        public Play()
		{

		}
        
        public string Jogar()
		{ 
            int Opcao = new Random().Next(3);

			if (Opcao == 0)
			{
				OpcaoSorteada = "pedra";
			}
			else if(Opcao == 1)
			{
				OpcaoSorteada = "papel";
			}
			else if(Opcao == 2)
			{
				OpcaoSorteada = "tesoura";
			
			}

			return OpcaoSorteada;
		}
	}
}