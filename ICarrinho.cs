namespace Aula26
{
    public interface ICarrinho
    {
        //CRUD
        //Create
        //Read
        //Update
        //Delete

         void Ler();
         void Adicionar(Produto _produto);
         void Remover(Produto _produto);
         void Alterar(int _codigo, Produto _produtoAlterado);
         void MostrarTotal();
    }
}