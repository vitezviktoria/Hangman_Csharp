using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Words
    {
        
        GameForm newGame;
        public void getAllatWords()
        {
            string[] words = { "dog", "cat", "lion", "snake", "mouse", "duck", "horse", "crocodile", "fish", "hamster" };
            newGame = new GameForm(words);
            newGame.ShowDialog();

        }

        public void getOrszagWords()
        {
            string[] words = { "Hungary", "England", "Mexico", "Italy", "France", "Spain", "Japan", "Sweden", "Brazil" };
            newGame = new GameForm(words);
            newGame.ShowDialog();
        }

        public void getSportWords()
        {
            string[] words = { "Voleyball", "Football", "Soccer", "Tennis", "Swimming", "Handball", "Basketball" };
            newGame = new GameForm(words);
            newGame.ShowDialog();
        }

        public void getRuhaWords()
        {
            string[] words = { "Shirt", "Pulover", "Jeans", "Pants", "Skirt", "Jacket", "Socks", "Shoes", "Belt", "Dress" };
            newGame = new GameForm(words);
            newGame.ShowDialog();
        }
    }
}
