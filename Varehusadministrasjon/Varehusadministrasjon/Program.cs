namespace Varehusadministrasjon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warehouse w = new Warehouse();
            Product p = new Product("1000","Pizza", 50);
            StockItem s = new StockItem(p,40);
            w.AddToStock(s);
            ConsoleApp app = new ConsoleApp(w);
            app.Start();

        }
    }
}
