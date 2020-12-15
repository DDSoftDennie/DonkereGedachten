using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class QuestionRepository
    {
        private readonly string _path = "/Cards/";
        private int _index;
        private List<Question> AllQuestions { get; set; }


       public QuestionRepository()
        {
            AllQuestions = new List<Question>();
       
            for (int i = 1; i <=38; i++)
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

        public Question NextQuestion()
        {
            if (_index < 37)
            {
                _index += 1;
            }
            else
            {
                _index = 0;
            }

        
            Question q = AllQuestions[_index];
 
            return q;
        }

        public Question ShowQuestion()
        {
                 return  AllQuestions[_index];            
        }

    }
}
