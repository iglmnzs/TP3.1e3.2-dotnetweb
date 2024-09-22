namespace AT1._1e1._2_dotnetweb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*QUESTÕES DO AT -> 1 e 2 */

            /*
             
             QUESTÃO 1 - Explique a função do DbContext em uma aplicação que utiliza EF Core. 
            Por que ele é considerado o coração da interação com o banco de dados?

            RESPOSTA - 
            
            Ele é responsável por fazer a interação entre a aplicação e o banco de dados, fazendo as principais
            operações de inserção, consultas, exclusão  e atualização e, também, realizando o mapeamento entre as entidades 
            da aplicação e as tabelas do banco de dados.

             --------------------------------------------------------------------------------------------------------


            QUESTÃO 2 - Descreva os três tipos principais de relacionamentos que podem ser modelados com EF Core: 
            Relacionamento Um-para-Muito, Relacionamento Um-para-Um e Relacionamento Muitos-para-Muitos.

            RESPOSTA - 
            
            Relacionamento Um-para-Muitos -> Aqui, uma entidade é associada a várias instâncias  de uma outra
            entidade, mas estas instâncias se associam a apenas uma única instância da entidade associada. Se estabelece a partir
            da chave estrangeira e costuma ser o tipo mais comum de relação. Como exemplo: Uma Categoria pode ter vários Produtos, 
            no entanto, cada Produto pertence somente a uma única Categoria

            Relacionamento Um-para-Um-> Aqui a relação é equivalente, uma entidade se associa a uma única instância
            de uma outra entidade e esta mesma se associa a apenas uma instância da primeira entidade. Ou seja, uma Pessoa
            pode ter apenas um Cpf e um Cpf se vincula a apenas uma Pessoa. Se configura através de uma única chave primária
            que também é uma chave estrangeira.

            Relacionamento Muitos-para-Muitos -> Esta relação também é equivalente, no entanto, uma entidade pode 
            se associar a várias instâncias de uma outra entidade e vice-versa. Exemplo: Um Professor pode lecionar em 
            várias Cadeiras e uma Cadeira pode ter muitos Professores.
             
             */
        }
    }
}
