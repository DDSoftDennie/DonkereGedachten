using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class Questions
    {
        private int _index;
        public List<Question> AllQuestions { get; private set; }

       public Questions()
        {
            _index = 0;
            AllQuestions = new List<Question>();
        }

        public void Add(Question q)
        {
            AllQuestions.Add(q);
        }

        public Question Next()
        {
            _index += 1;
            Question q = AllQuestions[_index];
            return q;
        }

        public Question ShowQuestion(int index)
        {
            Question q = AllQuestions[index];
            return q;
        }

    }
}
