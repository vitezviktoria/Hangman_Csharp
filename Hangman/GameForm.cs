using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class GameForm : Form
    {
        List<Label> letters = new List<Label>();
        List<Button> buttons;

        private int badGuesses;
        private int points;
        private int score;
        private Random rand = new Random();
        private string randWord;
        private string[] words;
        private int second;


        public GameForm(string[] newWords)
        {
            InitializeComponent();
            words = newWords;

            AddButtons();
            Start();

        }

        public void Random() //A tömbből random szót választunk
        {
            randWord = words[rand.Next(0, words.Length)];
        }

        public void Start()
        {
            pictureBox.BackgroundImage = null;
            badGuesses = 0;
            points = 0;
            score = 0;
            second = 0;
            timer.Start();

            Random();
            LettersDisplay();

        }

        public void Finish(bool didWin)
        {
            if (didWin)
            {
                timer.Stop();
                MessageBox.Show("Gratulálunk, nyertél!");
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Vesztettél!");
            }
        }

        //A kapott random szó betűnkénti kiírása
        public void LettersDisplay()
            {

                groupBox.Controls.Clear();
                letters.Clear();
                char[] wordChars = randWord.ToCharArray(); //Vizsgáljuk a random szó karakteres hosszát, feltöltjük egy tömbbe
                int length = wordChars.Length; 

                for (int i = 0; i < length; i++) //for ciklussal kiírjuk a karakterek helyére az alávonást
                {
                    Label label = new Label();
                    label.Text = "__";
                    label.Location = new Point(110 + i * (213 / length), 30);
                    label.Parent = groupBox;
                    label.BringToFront();
                    letters.Add(label);
                }
            }

        private bool isCompleted
        {
            get
            {
                if (points == letters.Count) //Ha a pont megegyezik a betűk számával (azaz kitaláltuk az összes betűt) true értéket ad vissza
                    return true;
                else
                    return false;
            }
        }

        public void AddButtons()
        {

            buttons = new List<Button>();
            buttons.Clear();


            for (int i = (int)'A'; i <= (int)'Z'; i++) //Létrehozzuk a gombokat A-tól Z-ig
            {
                Button button = new Button();
                button.Text = ((char)i).ToString();
                button.Parent = flowLayoutPanel1;
                button.Font = new Font(FontFamily.GenericSansSerif, 12);
                button.Size = new Size(35, 35);
                button.Click += button_Click;
                buttons.Add(button); //Hozzáadjuk egy listához az összes létrehozott gombot
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            char charClicked = button.Text.ToCharArray()[0]; //Vizsgáljuk a lenyomott gomb értékét
            button.Enabled = false; //A lenyomott gombot nem engedélyezzük (hogy ne lehessen mégegyszer lenyomni)
            bool hit = false;

            if ((randWord = randWord.ToUpper()).Contains(charClicked)) //Vizsgáljuk, hogy a random szóban van-e a gomb által kapott karakter
            {
                char[] charArray = randWord.ToCharArray();

                for (int i = 0; i < randWord.Length; i++) //Végignézzük egyesével a betűit
                {
                    if (charArray[i] == charClicked) //Ha van, kiírjuk a szó i indexű helyére az annak megfelelő betűt
                    {
                        hit = true;
                        letters[i].Text = charClicked.ToString();
                        points++;

                        score++;
                        scoreLabel.Text = score.ToString();
                    }
                }
            }
            if (hit == false)
            {
                IncrementHangman();
            }

            if (isCompleted)
                Finish(true);

        }

        //Ha nem tartalmazza a betűt a szó
        public void IncrementHangman()
        {
            badGuesses++; //Növeljük a rossz válaszok értékét, ez értéket visszakapva tudjuk az akasztófa képeit változtatni
            score--; //Levonunk a pontszámból, amit egy stringként kiíratunk
            scoreLabel.Text = score.ToString();

            switch (badGuesses)
            {
                case 1:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman1.png");
                    break;
                case 2:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman2.png");
                    break;
                case 3:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman3.png");
                    break;
                case 4:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman4.png");
                    break;
                case 5:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman5.png");
                    break;
                case 6:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman6.png");
                    break;
                case 7:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman7.png");
                    break;
                case 8:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman8.png");
                    break;
                case 9:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman9.png");
                    break;
                case 10:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman10.png");
                    break;
                case 11:
                    pictureBox.BackgroundImage = Image.FromFile(Application.StartupPath + "/Images/hangman11.png");
                    Finish(false);
                    break;
            }
        }
        

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            second++;
            elapsedTime.Text = second.ToString();
        }


    }
}
