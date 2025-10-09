namespace PZ3.ABC
{
    internal sealed class B: A
    {
        public int b;

        public B(int b): base(b)
        {
            this.b = b;
        }

        public sealed override int GetInfo()
        {
            a = 3;
            return b;
        }
    }
}
