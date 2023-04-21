
namespace lab_OOP_2_2_Katya
{
    class OddInMassiveException : Exception
    {
        protected Exception? exception; // ? - жопускает значение NULL. ТОЛЬКО С  ВЕРСИИ 9.0!
        private string? message;

        public OddInMassiveException() { }

        public OddInMassiveException(string message) : base(message)
        {

        }
        public OddInMassiveException(string message, Exception inner) : base(message, inner)
        {
            this.message = message;
            inner = exception;
        }
    }

    class TryException : OddInMassiveException
    {
        public TryException(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    throw new OddInMassiveException($"В массиве присутствуют нечетные числа", exception);
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];

            try
            {
                TryException exception = new TryException(array);
            }
            catch (OddInMassiveException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}