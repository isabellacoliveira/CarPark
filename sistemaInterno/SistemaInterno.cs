// aqui vamos fazer um sistema de autenticação 
using DESAFIO_1___EXIBINDO_DADOS_NO_CONSOLE;

namespace CarPark_ADM.SistemaInterno 
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha, string nomeUsuario)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado)
            {
                Console.WriteLine($"Olá, {nomeUsuario}, seja bem-vindo ao sistema de atendimento ao cliente do CarPark!");
                Console.WriteLine("\n");
                Console.WriteLine("O que você deseja fazer?");
                new CarParkAtendimento().AtendimentoAoCliente();
                return true; 
            }
            else 
            {
                Console.WriteLine("Senha incorreta"); 
                return false; 
            }
        }
    }
}