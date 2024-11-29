namespace functions
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();//we hebben een program gemaakt met de naam program.

            Program vraag1 = new Program();
            program.vraag1();
        }
        internal void Run()
        {
            Console.WriteLine("...");
        }    
        internal void vraag1()
        {
            Console.WriteLine("how long would you survive in a zombie apocolips?");
            var words = new[] { "idk dont ask me", "a weak", "you will not survive i will" };
            var wordsInRandomOrder = words.OrderBy(i => Guid.NewGuid());

            foreach (var word in wordsInRandomOrder)
            {
                Console.WriteLine(word);
            }


        }
    }
}
