using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheet
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            height = 0;
            weight = 0;
            name = "no name";
        }

        public Animal(double height, double weight, string name)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
        }

        public string toString()
        {
            return String.Format("Estatura {0}, peso {1}, y su nombre es ... {2}", height, weight, name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            int maxInt = int.MaxValue;
            var myName = "Erick Rosete Beas";
            Console.WriteLine("Hola, la variable contiene {0} y es tipo {1}", myName, myName.GetTypeCode());

            string randStr = "Random Characters";
            foreach (char c in randStr)
            {
                Console.WriteLine(c);
            }

            if (String.IsNullOrEmpty(randStr))
                Console.WriteLine(maxInt);
            else
                Console.WriteLine(randStr.Length);

            Console.Write("where is ac? in character " + randStr.IndexOf("ac"));
            Console.Write(randStr.Substring(randStr.IndexOf("ac")));
            Console.Write(randStr.Substring(randStr.IndexOf("ac")).Equals("acter"));

            List<int> numList = new List<int>();
            numList.Add(4);
            numList.Add(5);
            numList.Add(4);

            List<string> List2 = new List<string>(new string[] { "hola", "2", "hallo3", "konnichiha4" });

            numList.Remove(4);
            List2.RemoveAt(1);

            numList.Sort();
            for (int i = 0; i < numList.Count; i++)
                Console.WriteLine(numList[i]);

            foreach (var c in List2)
                Console.WriteLine(c);

            try
            {
                Console.Write("ingresa un entero: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("10 / {0} = {1}", num, 10 / num);
            }
            catch (DivideByZeroException)
            {
                Console.Write("No dividas por cero");
            }
            catch (FormatException)
            {
                Console.Write("numero!!!");
            }

            Animal jirafa = new Animal(100, 100, "La jirafa Oscaaaar");
            Console.WriteLine(jirafa.toString());

            Console.WriteLine("INGRESE CUALQUIER TECLA");
            Console.ReadKey();
        }
    }
}
