using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class QuestionRepository
    {
        private string _path;
        private int _index;
        private List<Question> AllQuestions { get; set; }


       public QuestionRepository()
        {
            _path = "/Cards/";
            AllQuestions = new List<Question>();

            for (int i = 1; i < 39; i++)
            {
                Question q = new Question
                {
                    Number = i,
                    Path = _path
                };
                AddQuestion(q);
            }
            _index = 0;

        }

        public void AddQuestion(Question q)
        {
            AllQuestions.Add(q);
        }

        public Question NextQuestion()
        {
            if (_index <= 39)
            {
                _index += 1;
            }
            else
                _index = 0;

            Question q = AllQuestions[_index];
            return q;
        }

        public Question ShowQuestion(bool random = false)
        {
 
            if(random == false)
            {
                 return  AllQuestions[_index];            
            }
            else
            {
                Random rnd = new Random();
                int _question = rnd.Next(0, 38);
                return AllQuestions[_question];
            }
        
        }

    }
}
