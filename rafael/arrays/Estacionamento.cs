class Estacionamento 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();
		bool[][] vagas = new bool[4][];
		for(int i = 0; i < vagas.Length; i++) 
		{
			vagas[i] = new bool[10];			
			for(int j = 0; j < vagas[i].Length; j++) 
			{
				vagas[i][j] = gerador.NextDouble() < 0.5;
				System.Console.Write(vagas[i][j] ?  "- " : "X ");
			}
			System.Console.WriteLine("andar " + (i + 1));
		}

		System.Console.WriteLine("Vagas Livres");
		for(int i = 0; i < vagas.Length; i++) 
		{
			int vagasLivres = 0;
			for(int j = 0; j < vagas[i].Length; j++) 
			{
				if(vagas[i][j]) 
				{
					vagasLivres++;
				}
			}
			System.Console.WriteLine("Andar " + (i + 1) + ": " + vagasLivres);
		}
	}
}
