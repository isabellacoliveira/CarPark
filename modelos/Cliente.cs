namespace DESAFIO_1___EXIBINDO_DADOS_NO_CONSOLE.modelos
{
    public class Cliente
    {
        private string _nome;
        public string Nome { 
            get 
            {
                return _nome;
            }
             set
            {
                if(value.Length < 3)
                {
                    Console.WriteLine("O nome do dono do carro deve ter mais de 3 caracteres");
                }
                _nome = value;
            } 
        }

        public int Cpf { get; set; }

        public static int TotalClientesCadastrados { get; set; }


        public Cliente()
        {
            TotalClientesCadastrados = TotalClientesCadastrados + 1;
        }

    }
}