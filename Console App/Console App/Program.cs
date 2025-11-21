namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response = Class1.callAndResponse("What is 2 + 2");
            Console.WriteLine(response);

            string secondResponse = Class1.callAndResponse();
            Console.WriteLine(secondResponse);

            bool truth = true;
            Console.WriteLine(truth.ToString());
        }
        
    }
}
