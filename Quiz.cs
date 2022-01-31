using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3
{
    public class Quiz
    {
        List<Question> quiz1 = new List<Question>();
        public void add_question(string userQ, string userQA, int diff){
            Question userQuestion = new Question(userQ,userQA,diff);
            quiz1.Add(userQuestion);
        }

        public void remove_questions(){
            string userChoice;
            Console.WriteLine("Choose the question to remove: ");
            for(int i=0; i<quiz1.Count;i++){
                Console.WriteLine(i + ". " +quiz1[i].getQuestionText());

            }
            userChoice = Console.ReadLine();
            quiz1.RemoveAt(int.Parse(userChoice));
        }

        public void modify_question(){

            Console.WriteLine("Choose the question to modify: ");
            for(int i=0; i<quiz1.Count;i++){
                Console.WriteLine(i + ". " +quiz1[i].getQuestionText());
            }
            string modifiedIndex = Console.ReadLine();
            Console.WriteLine("\nWhat is the question Text?");
            string newQT = Console.ReadLine();
            quiz1[int.Parse(modifiedIndex)].setQuestionText(newQT);
            Console.WriteLine("\nWhat is the answer?");
            string newQA = Console.ReadLine();
            quiz1[int.Parse(modifiedIndex)].setQuestionAnswer(newQA);
            Console.WriteLine("\nHow diffucult (1-3)?");
            string newDiff = Console.ReadLine();
            quiz1[int.Parse(modifiedIndex)].setDifficulty(int.Parse(newDiff));
 
        }

        public void give_quiz(){
            //count of questions
            //if userSTring matches quiz1.getanswer then increment points
            
            int score = 0;
            string userAnswer;
            int question_count = quiz1.Count;
            
            for(int i=0;i<quiz1.Count;i++){
                Console.WriteLine("\n"+ quiz1[i].getQuestionText());
                userAnswer = Console.ReadLine();
                if(userAnswer == quiz1[i].getQuestionAnswer()){
                    score++;
                    Console.WriteLine("Correct");
                }else{
                    Console.WriteLine("Incorrect");
                }
            }
            Console.WriteLine("\nYou got " + score + " out of " + question_count);

        }



    }
}