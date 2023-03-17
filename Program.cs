namespace Day8LineComparisionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Computation Problems");
            //LineDiffrence Difference = new LineDiffrence();
            //Difference.LineDistance();

            //CheckLineEquality Equality = new CheckLineEquality();
            //Equality.LineEquality();

            CompareTwoLine twoLines = new CompareTwoLine();
            twoLines.CompareLines();
        }
    }
}
