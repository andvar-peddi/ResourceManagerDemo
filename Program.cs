using System.Globalization;
using System.Reflection;
using System.Resources;

namespace ResourceManagerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResourceManager rm = new ResourceManager("ResourceManagerDemo.Resources.Strings", Assembly.GetExecutingAssembly());

            Console.WriteLine(rm.GetString("Welcome", new CultureInfo("EN")));
            Console.WriteLine(rm.GetString("Welcome", new CultureInfo("IT")));
            Console.WriteLine(rm.GetString("Welcome", new CultureInfo("RO")));
        }
    }
}
