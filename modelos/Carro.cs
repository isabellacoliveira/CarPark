namespace DESAFIO_1___EXIBINDO_DADOS_NO_CONSOLE.modelos
{
    public class Carro : IComparable<Carro>
    {
        private string _modelo_carro;
        private string _vaga;

        public string Modelo_Carro { 
                get 
                {
                  return _modelo_carro;
                } 
                set
                {
                    // TODO: conferir se o modelo digitado tem mais que 3 caracteres
                    // if(_modelo_carro.Count() == 3)
                    // {
                    //     Console.WriteLine("O modelo deve ter mais de 3 caracteres");
                    // }
                    // else
                    // {
                        _modelo_carro = value;
                    // }
                }
                
             }
        public Carro(string placa, Cliente titular, string horaEntrada, string horaSaida, string precoAPagar) 
        {
                this.Placa = placa;
                this.Titular = titular;
                this.HoraEntrada = horaEntrada;
                this.HoraSaida = horaSaida;
                this.PrecoAPagar = precoAPagar;
               
        }
        public string Placa { get; set; }
        public Cliente Titular { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSaida { get; set; }
        public string PrecoAPagar { get; set; }

        public string Vaga
        {
            get
            {
                return _vaga;
            }
            set
            {
                if(value == null)
                {
                    return;
                }
                else
                {
                    _vaga = value;
                }
            }
        }

        public Carro(string modelo_carro, string placa)
        {
            Modelo_Carro = modelo_carro;
            Placa = placa;
            Titular = new Cliente();
            TotalDeCarrosEstacionados += 1;
        }
         public Carro(string modelo_carro)
        {
            Modelo_Carro = modelo_carro;
            Vaga = Guid.NewGuid().ToString().Substring(0, 8);
            Titular = new Cliente();
            TotalDeCarrosEstacionados += 1;
        }

        public void CalcularValorAPagar(string HoraEntrada, string HoraSaida)
        {
            Console.WriteLine("Cheguei no calcular valor");
            Console.WriteLine(HoraEntrada);
            Console.WriteLine(HoraSaida);
        }

        public static int TotalDeCarrosEstacionados { get; set; }

        public override string ToString()
        {

            return $" === DADOS DO CARRO   === \n" +
                   $"Nome do Carro : {this.Modelo_Carro} \n" +
                   $"Placa do Carro : {this.Placa} \n" +
                   $"Nome do Titular: {this.Titular.Nome} \n" +
                   $"Tempo permanecido: {this.HoraEntrada} \n" +
                   $"CPF do Titular  : {this.Titular.Cpf} \n" +
                   $"Preco a pagar: { this.PrecoAPagar }\n\n";
        }

        public int CompareTo(Carro? other)
        {
            if(other == null)
            {
                return 1; 
            }
            else
            {
                 return this.Titular.Cpf.CompareTo(other.Titular.Cpf);
            }
        }
    }
}