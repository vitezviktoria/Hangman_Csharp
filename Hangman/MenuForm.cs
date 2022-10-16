using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class MenuForm : Form
    {
        Words get = new Words();

        public MenuForm()
        {
            InitializeComponent();
        }

        //A gombokra kattintva meghívjuk a megfelelő függvényt a Words classból, és egy új ablakban megnyitjuk a játékot
        private void allatokButton_Click(object sender, EventArgs e)
        {
            get.getAllatWords();
        }

        private void orszagokButton_Click(object sender, EventArgs e)
        {
            /*string filePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "orszagok.txt");
            using (TextReader tr = new StreamReader(filePath, Encoding.ASCII))
            {
                var words = tr.ReadToEnd().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                newGame = new GameForm(words);
                newGame.ShowDialog();
            }*/
            get.getOrszagWords();
        }

        private void sportButton_Click(object sender, EventArgs e)
        {
            get.getSportWords();
        }

        private void ruhazatButton_Click(object sender, EventArgs e)
        {
            get.getRuhaWords();
        }
    }
}
