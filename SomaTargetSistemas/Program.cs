namespace SomaTargetSistemas
{
    using static Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while(K < INDICE)
            {
              //K = K + 1 OU
                K += 1;
              //SOMA = SOMA + K OU
                SOMA += K;
            }
            Write(SOMA);

        }

    }
}
