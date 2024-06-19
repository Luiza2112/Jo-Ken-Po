namespace JoKenPo.Models
{
	public class JoKenPo
	{
        public string OpcaoEscolhida { get; set; }
        public int OpcaoSorteada { get; set; }

        public JoKenPo()
		{

		}

		public string Jogar()
		{
			string OpcaoEscolhida = Convert.ToString(OpcoesPicker.SelectedItem);
			OpcaoSorteada = new Random().Next(3);
		}
	}
}