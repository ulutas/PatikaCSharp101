using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Card
    {
        public enum CardSizeType
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }
        private string title;
        private string content;
        private string assignedPerson;
        private CardSizeType cardSize;
        private string line;

        public Card()
        {

        }
        public Card(string title, string content, string assignedPerson, CardSizeType cardSize, string line)
        {
            this.title = title;
            this.content = content;
            this.assignedPerson = assignedPerson;
            this.cardSize = cardSize;
            this.line = line;
        }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string AssignedPerson { get => assignedPerson; set => assignedPerson = value; }

        public string Line { get => line; set => line = value; }
        public CardSizeType CardSize { get => cardSize; set => cardSize = value; }
    }
}
