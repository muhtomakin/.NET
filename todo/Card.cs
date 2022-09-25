using System;
using System.Collections.Generic;

namespace todo {
    class Card {
        private string headline;
        private string context;
        private string person;
        private string size;

        public string Headline {get => headline; set => headline = value;}
        public string Context {get => context; set => context = value;}
        public string Person {get => person; set => person = value;}
        public string Size {get => size; set => size = value;}

        public Card (string headline, string context, string person, string size) {
            Headline = headline;
            Context = context;
            Person = person;
            Size = size;
        }
    }
}