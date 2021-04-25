using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LearnMultiplication
{
    public partial class Form1 : Form
    {
        static int theAnswer;
        static int myAnswer;

        static int personalBest;

        static int lastFlash;
        static int deleteFlashCard;

        static string lastProblem;

        static int correctAnswers = 0;
        static int wrongAnswers = 0;

        static bool numberLock = false;
        static bool rangeLock = false;
        static bool easyExclude = false;
        static bool practicing = true;

        string problemsFilePath = @"D:\Repos\PersonalNeeds\LearnMultiplication\LearnMultiplication\LearnMultiplication\FlashCardProblems.txt";
        string answersFilePath = @"D:\Repos\PersonalNeeds\LearnMultiplication\LearnMultiplication\LearnMultiplication\FlashCardAnswers.txt";
        string personalBestFilePath = @"D:\Repos\PersonalNeeds\LearnMultiplication\LearnMultiplication\LearnMultiplication\PersonalBest.txt";

        public Form1()
        {
            InitializeComponent();
            SolveThis.Enabled = false;
            Answer.Enabled = false;
            ConfirmAnswer.Enabled = false;            
            Correct.Text = "";
            FinalScore.Text = "";
            ClearWrong.Enabled = true;
            ProblemList.Visible = false;
            AnswerList.Visible = false;
            ExcludeEasy.Enabled = false;
            DeleteAllFlashCards.Enabled = false;
            PracticeBox.Checked = true;
            PracticeBox.Visible = false;

            ProblemList.Items.AddRange(File.ReadAllLines(problemsFilePath));
            AnswerList.Items.AddRange(File.ReadAllLines(answersFilePath));

            personalBest = Convert.ToInt32(File.ReadAllText(personalBestFilePath));

            PersonalBestLabel.Text = $"Current Record: {personalBest}";
            
        }

        private void CountDown_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            MathTimer.Start();

            correctAnswers = 0;
            wrongAnswers = 0;

            SolveThis.Enabled = true;
            Answer.Enabled = true;
            ConfirmAnswer.Enabled = true;
            CountDown.Value = 0;
            Answer.Text = "";
            FlashAnswer.Text = "";
            FlashCard.Text = "";

            FlashCard.Visible = false;
            FlashAnswer.Visible = false;
            ShowFlashAnswer.Visible = false;

            if (practicing == true)
            {
                WrongAnswers.Visible = true;
            }
            else
            {
                WrongAnswers.Visible = false;
            }

            PersonalBestLabel.ForeColor = System.Drawing.Color.Black;
            PersonalBestLabel.Text = $"Current Record: {personalBest}";

            NewProblem();
            ActiveControl = Answer;
            
        }

        private void SolveThis_TextChanged(object sender, EventArgs e)
        {

        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmAnswer_Click(object sender, EventArgs e)
        {            
            this.UpdateDefaultButton();
            int myAnswer = Convert.ToInt32(Answer.Text);
            if (CountDown.Value < 100)
            {                
                if (myAnswer == theAnswer)
                {
                    Correct.Text = "Correct!";                   
                    do
                    {
                        NewProblem();
                    } while (lastProblem == SolveThis.Text);
                    correctAnswers++;
                    
                    Answer.Text = "";
                }
                else
                {
                    File.AppendAllText(problemsFilePath, SolveThis.Text + "\n");
                    File.AppendAllText(answersFilePath, Convert.ToString(theAnswer) + "\n");
                    Correct.Text = "Try Again!";
                    WrongAnswers.Text += $"{SolveThis.Text} {theAnswer}\n";
                    
                    wrongAnswers++;
                    Answer.Text = "";
                    ProblemList.Items.Add(SolveThis.Text);
                    AnswerList.Items.Add(Convert.ToString(theAnswer));
                }                
            }

            lastProblem = SolveThis.Text;
        }

        private int NewProblem()
        {
            int a = StaticRandom.Instance.Next(2, 13);
            int b = StaticRandom.Instance.Next(3, 13);           

            int fiftyFifty = StaticRandom.Instance.Next(0, 2);
            if (numberLock == true && rangeLock == false)
            {
                if (SpecificTable.Text == "" || OnlyDigits(SpecificTable.Text) == false && SpecificTable2.Text == "")
                {
                    MessageBox.Show("Put in a number dummy! ;)");
                }
                else if(SpecificTable2.Text != "")
                {
                    int c = Convert.ToInt32(SpecificTable.Text);
                    int d = Convert.ToInt32(SpecificTable2.Text);
                    if (fiftyFifty == 0 && OnlyDigits(SpecificTable.Text) == true && OnlyDigits(SpecificTable2.Text) == true)
                    {
                        a = c;
                    }
                    else if (fiftyFifty == 1 && OnlyDigits(SpecificTable.Text) == true && OnlyDigits(SpecificTable2.Text) == true)
                    {
                        a = d;
                    }
                    else
                    {
                        MessageBox.Show("Put in a number dummy! ;)");
                    }
                }
                else
                {
                    int c = Convert.ToInt32(SpecificTable.Text);
                    a = c;
                }
            }
            else if (rangeLock == true && numberLock == false && easyExclude == false)
            {
                if(LowRange.Text == "" || HighRange.Text == "" || OnlyDigits(LowRange.Text) == false || OnlyDigits(HighRange.Text) == false)
                {
                    MessageBox.Show("Fix the range!");
                }
                else if(Convert.ToInt32(LowRange.Text) > Convert.ToInt32(HighRange.Text))
                {
                    MessageBox.Show("Fix the range!\nYour first number is higher than the second!");
                }
                else
                {
                    int min = Convert.ToInt32(LowRange.Text);
                    int max = Convert.ToInt32(HighRange.Text);
                    int e = StaticRandom.Instance.Next(min, max + 1);
                    a = e;
                }                                
            }
            else if (rangeLock == true && easyExclude == true && numberLock == false)
            {
                string rangeOfNumbers = "range";
                string allTheNumbers = "full";

                if (LowRange.Text == "" || HighRange.Text == "" || OnlyDigits(LowRange.Text) == false || OnlyDigits(HighRange.Text) == false)
                {
                    MessageBox.Show("Fix the range!");
                }
                else if (Convert.ToInt32(LowRange.Text) > Convert.ToInt32(HighRange.Text))
                {
                    MessageBox.Show("Fix the range!\nYour first number is higher than the second!");
                }
                else if (Convert.ToInt32(LowRange.Text) == 10 && Convert.ToInt32(HighRange.Text) == 11)
                {
                    MessageBox.Show("10 to 11 is not a valid range while Exclude Easy is selected!");
                }
                else
                {
                    int min = Convert.ToInt32(LowRange.Text);
                    int max = Convert.ToInt32(HighRange.Text);
                    int f = StaticRandom.Instance.Next(min, max + 1);
                    a = f;

                    if (a == 5 || a == 10)
                    {
                        a = NoEasyNumbers(a, rangeOfNumbers);
                    }

                    if (b == 5 || b == 10)
                    {
                        b = NoEasyNumbers(b, allTheNumbers);
                    }

                    if (a < 10 && b == 11)
                    {
                        int maxRange = Convert.ToInt32(HighRange.Text);
                        if (maxRange == 12 && fiftyFifty == 0)
                        {
                            b += 1;
                        }
                        else
                        {
                            b = NoEasyNumbers(b, allTheNumbers);
                        }
                    }

                    if (a == 11 && b < 10)
                    {
                        int maxRange = Convert.ToInt32(HighRange.Text);
                        if (maxRange == 12 && fiftyFifty == 1)
                        {
                            a += 1;
                        }
                        else
                        {
                            a = NoEasyNumbers(a, rangeOfNumbers);
                        }
                    }
                }               
            }


            SolveThis.Text = $"{a} * {b}=";

            return theAnswer = a * b;

        }      

        private void Correct_Click(object sender, EventArgs e)
        {

        }

        private void WrongAnswers_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinalScore_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ConfirmAnswer.PerformClick();
        }

        private void CopyWrong_Click(object sender, EventArgs e)
        {
            WrongAnswers.SelectAll();
            WrongAnswers.Copy();
        }

        private void ClearWrong_Click(object sender, EventArgs e)
        {
            WrongAnswers.Text = "";
        }

        private void FlashButton_Click(object sender, EventArgs e)
        {
            SolveThis.Text = "";
            Answer.Text = "";
            WrongAnswers.Visible = false;

            if (ProblemList.Items.Count == 0 )
            {
                MessageBox.Show("No Flash Cards! Get Some Wrong First :P");
            }
            else
            {

                FlashCard.Visible = true;
                ShowFlashAnswer.Visible = true;

                int flashPicker = StaticRandom.Instance.Next(0, ProblemList.Items.Count);
                FlashAnswer.Visible = false;

                if (ProblemList.Items.Count > 1)
                {
                    if (flashPicker != lastFlash)
                    {
                        lastFlash = flashPicker;
                    }
                    else
                    {
                        if (flashPicker == ProblemList.Items.Count - 1)
                        {
                            flashPicker -= 1;
                        }
                        else
                        {
                            flashPicker += 1;
                        }
                        lastFlash = flashPicker;
                    }
                }

                ProblemList.SelectedIndex = flashPicker;
                AnswerList.SelectedIndex = flashPicker;

                FlashCard.Text = ProblemList.SelectedItem.ToString();
                FlashAnswer.Text = AnswerList.SelectedItem.ToString();

                deleteFlashCard = flashPicker;
            }          
        }

        private void FlashCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowFlashAnswer_Click(object sender, EventArgs e)
        {
            FlashAnswer.Visible = true;
        }

        private void FlashAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void LockNumberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (LockNumberCheck.Checked)
            {
                LockRange.Checked = false;
                LockRange.Enabled = false;
                rangeLock = false;
                numberLock = true;
            }
            else
            {
                LockRange.Enabled = true;
                numberLock = false;
                SpecificTable.Text = "";
                SpecificTable2.Text = "";
            }
        }

        private void SpecificTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProblemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnswerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearFlashCards_Click(object sender, EventArgs e)
        {
            ProblemList.Items.Clear();
            AnswerList.Items.Clear();
            FlashCard.Text = "";
            FlashAnswer.Text = "";
        }

        private bool OnlyDigits(string text)
        {
            foreach (char x in text)
            {
                if (x < '0' || x > '9')
                    return false;
            }
            return true;
        }

        private void SpecificTable2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LockRange_CheckedChanged(object sender, EventArgs e)
        {
            if (LockRange.Checked)
            {
                LockNumberCheck.Checked = false;
                LockNumberCheck.Enabled = false;
                numberLock = false;
                rangeLock = true;
                ExcludeEasy.Enabled = true;
            }
            else
            {
                LockNumberCheck.Enabled = true;
                rangeLock = false;
                ExcludeEasy.Checked = false;
                ExcludeEasy.Enabled = false;
                LowRange.Text = "";
                HighRange.Text = "";
            }


        }

        private void LowRange_TextChanged(object sender, EventArgs e)
        {

        }

        private void HighRange_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExcludeEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (ExcludeEasy.Checked)
            {
                easyExclude = true;
            }
            else
            {
                easyExclude = false;
            }
        }

        private int NoEasyNumbers(int easyNumber, string fullOrRange)
        {
            int minRange = 3;
            int maxRange = 13;

            if(fullOrRange == "range")
            {
                minRange = Convert.ToInt32(LowRange.Text);
                maxRange = Convert.ToInt32(HighRange.Text);
            }
            else if (fullOrRange == "full")
            {
                minRange = 3;
                maxRange = 13;
            }

            do
            {
                easyNumber = StaticRandom.Instance.Next(minRange, maxRange);
            } while (easyNumber == 11 || easyNumber == 5 || easyNumber == 10);          

            return easyNumber;

        }

        public static class StaticRandom
        {
            private static int seed;

            private static ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
                (() => new Random(Interlocked.Increment(ref seed)));

            static StaticRandom()
            {
                seed = Environment.TickCount;
            }

            public static Random Instance { get { return threadLocal.Value; } }
        }

        private void DeleteSafety_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteSafety.Checked)
            {
                DeleteAllFlashCards.Enabled = true;
            }
            else
            {
                DeleteAllFlashCards.Enabled = false;
            }
        }

        private void DeleteAllFlashCards_Click(object sender, EventArgs e)
        {
            FlashCard.Text = "";
            FlashAnswer.Text = "";

            File.WriteAllText(problemsFilePath, String.Empty);
            File.WriteAllText(answersFilePath, String.Empty);
        }

        private void LoadAllFlashcards_Click(object sender, EventArgs e)
        {
            FlashCard.Text = "";
            FlashAnswer.Text = "";

            ProblemList.Items.AddRange(File.ReadAllLines(problemsFilePath));
            AnswerList.Items.AddRange(File.ReadAllLines(answersFilePath));

            List<string> AllProblems = new List<string>();
            List<string> AllAnswers = new List<string>();

            foreach (string a in ProblemList.Items)
            {
                AllProblems.Add(a);
            }
            foreach (string b in AnswerList.Items)
            {
                AllAnswers.Add(b);
            }

            int index1 = 0;
            int index2 = 0;

            while (index1 < AllProblems.Count - 1)
            {
                index2 = 0;
                while (index2 < AllProblems.Count -1)
                {
                    if(AllProblems.ElementAt(index1) == AllProblems.ElementAt(index2))
                    {
                        AllProblems.RemoveAt(index2);
                        AllAnswers.RemoveAt(index2);                       
                    }
                    index2++;
                }
                index1++;
            }
            ProblemList.Items.Clear();
            AnswerList.Items.Clear();

            File.WriteAllLines(problemsFilePath, AllProblems);
            File.WriteAllLines(answersFilePath, AllAnswers);

            ProblemList.Items.AddRange(File.ReadAllLines(problemsFilePath));
            AnswerList.Items.AddRange(File.ReadAllLines(answersFilePath));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MathTimer.Enabled = true;
            MathTimer.Interval = 3000;
            MathTimer.Stop();
        }

        private void MathTimer_Tick(object sender, EventArgs e)
        {
            if (CountDown.Value == 100)
            {
                MathTimer.Stop();
                SolveThis.Enabled = false;
                PracticeBox.Checked = true;
                SolveThis.Text = "";
                Answer.Text = "";
                ConfirmAnswer.Enabled = false;
                Correct.Text = "";
                FinalScore.Text = $"Correct Answers: {correctAnswers}\n Wrong Answers: {wrongAnswers}";
                WrongAnswers.Visible = true;

                if (correctAnswers > personalBest && practicing == false)
                {
                    string bestNew = Convert.ToString(correctAnswers);
                    File.WriteAllText(personalBestFilePath, bestNew);

                    personalBest = correctAnswers;
                    PersonalBestLabel.ForeColor = System.Drawing.Color.Purple;
                    PersonalBestLabel.Text = $"NEW RECORD: {personalBest}";
                }
            }
            else
            {
                CountDown.PerformStep();
            }
        }

        private void PersonalBestLabel_Click(object sender, EventArgs e)
        {

        }

        private void PracticeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PracticeBox.Checked)
            {
                RecordBox.Checked = false;
            }

        }

        private void RecordBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RecordBox.Checked)
            {
                PracticeBox.Checked = false;                
                WrongAnswers.Visible = false;
                
                practicing = false;

                LockRange.Checked = false;
                LockRange.Enabled = false;
                LowRange.Text = "";
                HighRange.Text = "";
                
                LockNumberCheck.Checked = false;
                LockNumberCheck.Enabled = false;
                SpecificTable.Text = "";
                SpecificTable2.Text = "";

                FlashCard.Visible = false;
                FlashAnswer.Visible = false;
            }
            else
            {
                PracticeBox.Checked = true;
                WrongAnswers.Visible = true;

                LockRange.Enabled = true;
                LockNumberCheck.Enabled = true;

                practicing = true;

                FlashCard.Visible = true;
                FlashAnswer.Visible = true;
            }
        }

        private void DeleteCurrentFlash_Click(object sender, EventArgs e)
        {
            ProblemList.SelectedIndex = deleteFlashCard;
            string deleteProblem = ProblemList.SelectedItem.ToString();
                       
            ProblemList.Items.RemoveAt(deleteFlashCard);
            AnswerList.Items.RemoveAt(deleteFlashCard);

            ProblemList.Items.AddRange(File.ReadAllLines(problemsFilePath));
            AnswerList.Items.AddRange(File.ReadAllLines(answersFilePath));

            List<string> AllProblems = new List<string>();
            List<string> AllAnswers = new List<string>();
            
            foreach(string x in ProblemList.Items)
            {
                AllProblems.Add(x);
            }
            foreach(string y in AnswerList.Items)
            {
                AllAnswers.Add(y);
            }
            
            for(int index = 0; index <= AllProblems.Count - 1; index++)
            {
                if (AllProblems.ElementAt(index) == deleteProblem)
                {
                    AllProblems.RemoveAt(index);
                    AllAnswers.RemoveAt(index);
                }

            }

            File.WriteAllLines(problemsFilePath, AllProblems);
            File.WriteAllLines(answersFilePath, AllAnswers);

            AllProblems.Clear();
            AllAnswers.Clear();

            ProblemList.Items.Clear();
            AnswerList.Items.Clear();

            ProblemList.Items.AddRange(File.ReadAllLines(problemsFilePath));
            AnswerList.Items.AddRange(File.ReadAllLines(answersFilePath));

            FlashCard.Text = "";
            FlashAnswer.Text = "";

        }
    }
}
