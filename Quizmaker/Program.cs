using Quizmaker.Services;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Quizmaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Questions = 1");
            Console.WriteLine("Answer Questions = 2");
            string menu1 = Console.ReadLine()!;
            while (menu1 == null)
            {
                Console.WriteLine("insert valid item");
            }
            if (menu1 == "1")
            {
                XMLService xmlService = new XMLService("Quiz.xml");
                Console.WriteLine("-Please Enter Question");
                string question = Console.ReadLine()!;
                Console.WriteLine("-Please Enter Answer");
                string answer = Console.ReadLine()!;
                Quiz newQuiz = new Quiz(question, answer);
                xmlService.CreateNode(newQuiz);
            }
            else if (menu1 == "2")
            {
                Console.WriteLine();
            }
        }
    }
    public class Quiz
    {
        public string question;
        public string answer;

        public Quiz(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}
