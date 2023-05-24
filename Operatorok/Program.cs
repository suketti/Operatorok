namespace Operatorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Expression> expressions = new List <Expression> ();
            StreamReader sr = new StreamReader("kifejezesek.txt", encoding: System.Text.Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string[] lineIn = sr.ReadLine().Split(' ');
                Console.WriteLine(lineIn[2]);
            }

            sr.Close();
        }
    }
}