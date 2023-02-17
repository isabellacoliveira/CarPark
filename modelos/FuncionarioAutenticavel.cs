namespace CarPark_ADM.SistemaInterno 
{
    public abstract class FuncionarioAutenticavel: IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
           return this.Senha == senha; 
        }
        
    }
}