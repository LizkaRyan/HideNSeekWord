using TextBuster.Encoding;
using TextBuster.Encoding.Tree;

namespace TextBuster
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            string content =
                "For any code that is biunique, meaning that the code is uniquely decodeable, the sum of the probability budgets across all symbols is always less than or equal to one. In this example, the sum is strictly equal to one; as a result, the code is termed a complete code. If this is not the case, one can always derive an equivalent code by adding extra symbols (with associated null probabilities), to make the code complete while keeping it biunique";

            
            TextAnalyzer textAnalyzer = new TextAnalyzer(content);
            GraphCollection graphCollection = textAnalyzer.CreateGraphCollection();
            graphCollection.CreateTree();
            
            Console.WriteLine("VITA");
            
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());
        }
    }
}