using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz myQuiz = new Quiz();

            string userChoice;

            do{
                Console.WriteLine("1. Add a question to the quiz");
                Console.WriteLine("2. Remove a question from the quiz");
                Console.WriteLine("3. Modify a question in the quiz");
                Console.WriteLine("4. Take the quiz");
                Console.WriteLine("5. Quit");
                userChoice = Console.ReadLine();
                Console.WriteLine();

                if(int.Parse(userChoice) == 1){
                    Console.WriteLine("What is the question Text? ");
                    string qt = Console.ReadLine();
                    Console.WriteLine("\nWhat is the answer?");
                    string qa = Console.ReadLine();
                    Console.WriteLine("\nHow difficult (1-3)?");
                    string diff = Console.ReadLine();
                    Console.WriteLine();
                    myQuiz.add_question(qt,qa,int.Parse(diff));
                }else if(int.Parse(userChoice) == 2){
                    myQuiz.remove_questions();
                    Console.WriteLine();
                }else if(int.Parse(userChoice) == 3){
                    myQuiz.modify_question();
                    Console.WriteLine();
                }else if(int.Parse(userChoice) == 4){
                    myQuiz.give_quiz();
                }


            }while(int.Parse(userChoice) != 5);
        }
    }
}
