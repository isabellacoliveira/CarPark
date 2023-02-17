using DESAFIO_1___EXIBINDO_DADOS_NO_CONSOLE.modelos;

namespace DESAFIO_1___EXIBINDO_DADOS_NO_CONSOLE
{
    public class CarParkAtendimento
    {        
        private List<Carro> _carrosEstacionados = new List<Carro>(){
          new Carro("Argo", "FHT0343"){Titular = new Cliente{Cpf=9999,Nome ="Carolina"}, HoraEntrada = "10:00"},
          new Carro("Sandero", "DWA8191"){Titular = new Cliente{Cpf=22222,Nome ="Elias"}, HoraEntrada = "13:00"},
          new Carro("HB-20", "DTV3417"){Titular = new Cliente{Cpf=33333,Nome ="Isabella"}, HoraEntrada = "14:59"},
          new Carro("HB-20", "DTV3417"){Titular = new Cliente{Cpf=11111,Nome ="Alberth"}, HoraEntrada = "14:59"}
        };
        public void AtendimentoAoCliente()
        {
             try
            {
                char opcao = '0';
                while (opcao != '6')
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("===       Atendimento       ===");
                    Console.WriteLine("=== 1 - Cadastrar Carro     ===");
                    Console.WriteLine("=== 2 - Listar Carros       ===");
                    Console.WriteLine("=== 3 - Remover Carro       ===");
                    Console.WriteLine("=== 4 - Ordenar Carro       ===");
                    Console.WriteLine("=== 5 - Pesquisar Carro     ===");
                    Console.WriteLine("=== 6 - Sair do Sistema     ===");
                    Console.WriteLine("===============================");
                    Console.WriteLine("\n\n");
                    Console.Write("Digite a opção desejada: ");
                 try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                 catch (Exception excecao)
                    {
                        throw new Exception(excecao.Message);
                    }
                 switch (opcao)
                    {
                        case '1':
                            AdicionarCarro();
                            break;
                        case '2':
                            ListarCarros();
                            break;
                        case '3':
                            RemoverCarro();
                            break;
                        case '4':
                            OrdenarCarros();
                            break;
                        case '5':
                            PesquisarCarros();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opcao não implementada.");
                        break;
                    }
                }
            }
            catch {
                Console.WriteLine("Deu Errado");
            }
        }

        private void PesquisarCarros()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===    PESQUISAR CARROS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Deseja pesquisar por (1) NÚMERO DA PLACA ou (2) NOME DO TITULAR ou " +
                " (3) MODELO DO CARRO : ");
            Console.WriteLine("\n");
            // switch (int.Parse(Console.ReadLine()))
            // {
            //     case 1:
            //         {
            //             Console.Write("Informe a placa do carro: ");
            //             string _placaCarro = Console.ReadLine();
            //             Carro consultaCarro = ConsultaPorPlacaCarro(_placaCarro);
            //             Console.WriteLine(consultaCarro.ToString());
            //             Console.ReadKey();
            //             break;
            //         }
            //     case 2:
            //         {
            //             Console.Write("Informe o nome do Titular: ");
            //             string _nomeDono = Console.ReadLine();
            //             Carro consultaNomeDono = ConsultaPorNomeDono(_nomeDono);
            //             Console.WriteLine(consultaNomeDono.ToString());
            //             Console.ReadKey();
            //             break;
            //         }
            //     case 3:
            //         {
            //             Console.Write("Informe o Modelo do carro: ");
            //             string _modeloCarro = Console.ReadLine();
            //             var modelosDeCarro = ConsultaPorModelo(_modeloCarro);
            //             ExibirListaDeCarros(modelosDeCarro);
            //             Console.ReadKey();
            //             break;
            //         }
            //     default:
            //         Console.WriteLine("Opção não implementada.");
            //         break;
            // }
        }
        private void ExibirListaDeCarros(List<Carro> modelosCarro)
        {
            if (modelosCarro == null)
            {
                Console.WriteLine(" ... A consulta não retornou dados ...");
            }
            else
            {
                foreach (var item in modelosCarro)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private List<Carro> ConsultaPorModelo(string modeloCarro)
        {
            var consulta = (
                         from modelo in _carrosEstacionados
                         where modelo.Modelo_Carro == modeloCarro
                         select modelo).ToList();
            return consulta;
        }

        private Carro ConsultaPorNomeDono(string? nomeDono)
        {
            return _carrosEstacionados.Where(nome => nome.Titular.Nome == nomeDono).FirstOrDefault();
        }

        private Carro ConsultaPorPlacaCarro(string? placaCarro)
        {
            return _carrosEstacionados.Where(carro => carro.Placa == placaCarro).FirstOrDefault();
        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("... Encerrando a aplicação ...");
            Console.ReadKey();
        }

        private void OrdenarCarros()
        {
            _carrosEstacionados.Sort();
            Console.WriteLine("... Lista de Contas ordenadas ...");
            Console.ReadKey();
        }

        private void RemoverCarro()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===      REMOVER CARROS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Informe a placa do carro: ");
            string placa = Console.ReadLine();
            Carro carro = null;
            
            foreach (var item in _carrosEstacionados)
            {
                if (item.Placa.Equals(placa))
                {
                    carro = item;
                    var HoraEntrada = item.HoraEntrada;

                    Console.WriteLine("Por favor digite o horário de saída: ");
                    var HoraSaida = Console.ReadLine();
                    carro.CalcularValorAPagar(HoraEntrada, HoraSaida);
                    Console.WriteLine("Aqui será calculado o total a pagar ");
                }
            }
            if (carro != null)
            {
                _carrosEstacionados.Remove(carro);
                Console.WriteLine("... Carro removido da lista! ...");
            }
            else
            {
                Console.WriteLine(" ...  Carro não encontrado ...");
            }
            Console.ReadKey();
        }

        private void ListarCarros()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===     LISTA DE CARROS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            if (_carrosEstacionados.Count <= 0)
            {
                Console.WriteLine("... Não há contas cadastradas! ...");
                Console.ReadKey();
                return;
            }
            foreach (Carro item in _carrosEstacionados)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.ReadKey();
            }
        }

        private void AdicionarCarro()
        {

            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===   CADASTRO DE CARROS    ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.WriteLine("=== Informe dados do carro ===");

            Console.Write("Informe o modelo do carro: ");
            string modeloCarro = Console.ReadLine();
            Carro carro = new Carro(modeloCarro);

            Console.WriteLine($"Número da vaga [A ESTACIONAR] : {carro.Vaga}");
            Console.Write("Informe a placa do carro: ");
            carro.Placa = Console.ReadLine().ToLower();

            Console.Write("Infome nome do Titular: ");
            carro.Titular.Nome = Console.ReadLine();

            Console.Write("Infome CPF do Titular: ");
            carro.Titular.Cpf = int.Parse(Console.ReadLine());

            Console.Write("Infome o horário de entrada: ");
            carro.HoraEntrada = Console.ReadLine();

            _carrosEstacionados.Add(carro);

             
            Console.WriteLine("... Carro cadastrado com sucesso! ...");
            Console.ReadKey();
        }
    }
}