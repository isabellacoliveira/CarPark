// See https://aka.ms/new-console-template for more information

using bytebank_ADM.Funcionarios;
using CarPark_ADM.SistemaInterno;
using DESAFIO_1___EXIBINDO_DADOS_NO_CONSOLE;

Console.WriteLine("Seja bem vindo ao estacionamento CarPark!");

UsarSistema();

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno(); 
    Funcionario isabella = new Funcionario("Isabella", 123123, 2000); 
    isabella.Nome = "Isabella Oliveira"; 
    isabella.Senha = "123456"; 


    Console.WriteLine("Por favor digite seu nome: "); 
    string nomeUsuario = Console.ReadLine(); 

    Console.WriteLine("Por favor digite sua senha: "); 
    string senha = Console.ReadLine(); 

    sistema.Logar(isabella, senha, nomeUsuario); 
}



