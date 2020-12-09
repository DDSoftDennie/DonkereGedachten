using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BlazorApp.Shared
{
   public class Question
    {
        public int Number { get; set; }

        public string Path { get; set; }

        public string File => this.Path + Number + ".png";


    }
}
