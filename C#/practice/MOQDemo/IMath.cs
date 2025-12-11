namespace MOQDemo
{
    public interface IMath
    {
        string Add(int x, int y);
    }
    internal class RealClass : IMath
    {
        public string Add(int x, int y)
        {

            return "the sum is " + (x + y);
        }
    }
}
