using System.Runtime.CompilerServices;

namespace Lambda
{
    public static class Program
    {
        private static void Main()
        {
            /*
            * Digamos que queremos aplicar uma condição entre dois números, porém, não sabemos qual condição ainda
            * Isso implica a deixarmos a decisão da implementação desta condição para o momento do uso.
            * Par isso uma das formas de realizarmos isso seria através de um delegate.
            */

            Console.WriteLine($"Condição 3 \"EhMaior\" 4 {ExecutaCondicao(EhMaior, 3, 4)}");
            Console.WriteLine($"Condição 3 \"EhMenor\" 4 {ExecutaCondicao(EhMenor, 3, 4)}");
            Console.WriteLine($"Condição 3 \"EhIgual\" 4 {ExecutaCondicao(EhIgual, 3, 4)}");

            /*
             * Apesar de termos atingido o objetivo note que todos os tipos e métodos declarados foram utilizados apenas uma vez
             * O Tipo Condicionador
             * Os métodos EhMaior, EhMenor e EhIgual
             * Para esse tipo de situação existe uma abordagem muito mais elegante
             * a expressão lambda
             */

            Console.WriteLine($"Lambda maior 3 - 4 {ExecutaCondicaoLambda((x, y) => x > y, 3, 4) }");
            Console.WriteLine($"Lambda menor 3 - 4 {ExecutaCondicaoLambda((x, y) => x < y, 3, 4) }");
            Console.WriteLine($"Lambda igual 3 - 4 {ExecutaCondicaoLambda((x, y) => x == y, 3, 4) }");

            /*
             * Isso se aplicar melhor a métodos de extensão:
             * Pense que queremos verificar qual é o índice de um determinado item de uma lista de inteiros
             * Este recurso já existe (Não utlize esse meio, este exemplo é apenas para explicação) utilize os recursos do LINQ
             */

            var l = new List<int>(new int[]{ 9,3,2,6,4,1,7,8,5 });

            Console.WriteLine($"Busca primitiva em lista: 9,3,2,6,4,1,7,8,5");
            Console.WriteLine($"Buscando o índice do número 1: {l.BuscaWhere(x => x == 1)}");


        }

        private delegate bool Condicionador(int x, int y);

        private static bool ExecutaCondicao(Condicionador condicionador, int x, int y)
        {
            return condicionador(x, y);
        }
        private static bool ExecutaCondicaoLambda(Func<int, int, bool> func, int x , int y)
        {
            return func(x, y) ;
        }

        private static bool EhMaior(int x, int y)
        {
            return x > y;
        }

        private static bool EhMenor(int x, int y)
        {
            return x < y;
        }
        private static bool EhIgual(int x, int y)
        {
            return x == y;
        }

        public static int BuscaWhere(this List<int> l, Predicate<int> search)
        {
            for(var i =0; i <= l.Count; i++)
            {
                if (search(l[i]))
                    return i;       
            }

            throw new Exception("Valor não existe na lista");
        }


    }
}