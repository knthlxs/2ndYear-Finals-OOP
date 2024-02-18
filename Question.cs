using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsOOP {
    internal class Question {
        public int answer { get; }
        public string text { get; }
        public string[] choices { get; }
        public string img { get; set; }
        public Question(string text, string[] choices, int answer, string img) {
            this.answer = answer;
            this.text = text;
            this.choices = choices;
            this.img = img;
        }
        public string getQuestion() {
            return text;
        }

        public string getChoices(int n) {
            return choices[n];
        }
    }
}
