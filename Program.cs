// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        float uahInWallet;
        float cadInWallet;

        int uahToCad = 28, cadToUah = 29;

        float exchangeCurrencyCount;

        string desireOption;

        Console.WriteLine("Welcome to the currency exchange!");

        Console.Write("Enter your UAH ballance ");
        uahInWallet = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter your CAD ballance ");
        cadInWallet = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Choose the option");
        Console.WriteLine("1 - exchange UAH to CAD");
        Console.WriteLine("2 - exchange CAD to UAH");
        Console.Write("Your choice: ");
        desireOption = Console.ReadLine();

        switch (desireOption) {
            case "1":
                Console.WriteLine("UAH to CAD exchange");
                Console.Write("How much do you want to exchange? ");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if(uahInWallet >= exchangeCurrencyCount) {
                    uahInWallet -= exchangeCurrencyCount;
                    cadInWallet += exchangeCurrencyCount / uahToCad;
                } else {
                    Console.WriteLine("Low ballance in your wallet");
                }
                break;
            case "2":
                Console.WriteLine("CAD to UAH exchange");
                Console.Write("How much do you want to exchange? ");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if(cadInWallet >= exchangeCurrencyCount) {
                    cadInWallet -= exchangeCurrencyCount;
                    uahInWallet += exchangeCurrencyCount * cadToUah;
                } else {
                    Console.WriteLine("Low ballance in your wallet");
                }
                break;
            default: 
            Console.WriteLine("Incorrect option");
                break;
        }
        Console.WriteLine($"Your ballance: {uahInWallet} UAH " + $"{cadInWallet} CAD");
    }
}      



     
