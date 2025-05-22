internal class Program
{
    public static (int, int) ConvertMToHM(int nbMin)
    {
        return (nbMin / 60, nbMin % 60);
    }

    private static void Main(string[] args)
    {
        // Programme principal
        (int H, int M) = ConvertMToHM(130);
        Console.WriteLine($"{H}:{M}");
    }
}