using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3
{
    public class Question
    {
        private string questionText; 
        private string questionAnswer;
        private int difficulty;

        public Question(string qText,string qAnswer, int diff){
            questionText = qText;
            questionAnswer = qAnswer;
            difficulty = diff;
        }
        //getters
        public string getQuestionText(){
            return questionText;
        }
        public string getQuestionAnswer(){
            return questionAnswer;
        }
        public int getDifficulty(){
            return difficulty;
        }

        //setters

        public void setQuestionText(string qText){
            questionText = qText;
        }
        public void setQuestionAnswer(string qAnswer){
            questionAnswer = qAnswer;
        }

        public void setDifficulty(int diff){
            difficulty = diff;
        }
    }
}

//for removal just get the index of the question and remove it from the List