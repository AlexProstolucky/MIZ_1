using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Введіть кількість букв:");
        n = Int32.Parse(Console.ReadLine());
        string[] str = { "відбудова", "стратегія", "місія", "реформа", "візія", "модернізація", "екосистема", "реконструкція", "політика", "спроможність" };  
        var zap = from st in str
            where st.Length == n
                select st;

        Console.WriteLine($"Результат пошуку слів з кількістю букв ({n}):");
        foreach (var st in zap) 
        {
            Console.Write($"{st} ");
        }
    }
}