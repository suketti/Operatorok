namespace Operatorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Expression> expressions = new List<Expression>();
            StreamReader sr = new StreamReader("kifejezesek.txt", encoding: System.Text.Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string[] lineIn = sr.ReadLine().Split(' ');
                expressions.Add(new Expression(Int32.Parse(lineIn[0]), lineIn[1], Int32.Parse(lineIn[2])));
            }

            Console.WriteLine("2. feladat: Kifejezesések száma: " + expressions.Count);
            Console.WriteLine("3. feladat: Kifejezések maradékos osztással" + expressions.Where(e => e.Operand == "mod").Count());
            if (expressions.Where(e => e.FirstNum % 10 == 10 || e.SecondNum % 10 == 10).Count() > 0)
            {
                Console.WriteLine("4. feladat: Létezik ilyen kifezejés");
            } 
            else
            {
                Console.WriteLine("4. feladat: Nem létezik ilyen kifejezés");
            }

            int additionCount = 0;
            int substractionCount = 0;
            int multiplationCount = 0;
            int divisionCount = 0;
            int wholeDivisionDount = 0;
            int remainderCount = 0;


            foreach(Expression e in expressions)
            {
                switch(e.Operand)
                {
                    case "+":
                        additionCount++;
                        break;
                    case "-":
                        substractionCount++;
                        break;
                    case "*":
                        multiplationCount++;
                        break;
                    case "/":
                        divisionCount++;
                        break;
                    case "div":
                        wholeDivisionDount++;
                        break;
                    case "mod":
                        remainderCount++;
                        break;
                }
            }

            Console.WriteLine("5. feladat: Statisztika");
            Console.WriteLine($"mod -> { remainderCount}db\n /-> {divisionCount}db\n div->{wholeDivisionDount}db\n - -> {substractionCount}db\n *-> {multiplationCount}db\n + -> {additionCount}db");

        }



    }
}