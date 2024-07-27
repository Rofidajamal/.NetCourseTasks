namespace Common
{
    public class TypeA
    {
        private int X;
        internal int Y;
        public int Z;

        public void print()
        {
            Console.WriteLine(X); // it works because X is private and we can access it inside its class
        }

    }
}