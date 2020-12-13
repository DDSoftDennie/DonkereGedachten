using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class QuestionRepository
    {
        private string _path;
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
        }

        public void AddQuestion(Question q)
        {
            AllQuestions.Add(q);
        }

        public Question NextQuestion(int index)
        {
            index += 1;
            Question q = AllQuestions[index];
            return q;
        }

        public Question ShowQuestion(int index)
        {
            Question q = AllQuestions[index];
            return q;
        }

    }
}
