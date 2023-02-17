using CarPark_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario : FuncionarioAutenticavel
    {
        
        // private List<Funcionario> _carrosEstacionados = new List<Carro>(){
        //   new Funcionario("Argo", "FHT0343"){Titular = new Cliente{Cpf=9999,Nome ="Carolina"}, HoraEntrada = "10:00"},
        //   new Funcionario("Sandero", "DWA8191"){Titular = new Cliente{Cpf=22222,Nome ="Elias"}, HoraEntrada = "13:00"},
        //   new Funcionario("HB-20", "DTV3417"){Titular = new Cliente{Cpf=33333,Nome ="Isabella"}, HoraEntrada = "14:59"},
        //   new Funcionario("HB-20", "DTV3417"){Titular = new Cliente{Cpf=11111,Nome ="Alberth"}, HoraEntrada = "14:59"}
        // };

        public string Nome { get; set; }
        public int Cnpj { get; set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string nome, int cnpj, double salario)
        {
            this.Nome = nome;
            this.Salario = salario; 
            this.Cnpj = cnpj; 
            TotalDeFuncionarios++;   
        }

        private void AdicionarFuncionario(string nome, int cnpj, double salario)
        {
            Nome = nome; 
            Cnpj = cnpj;
            Salario = salario;
            Console.WriteLine(TotalDeFuncionarios);
        }
    }
}