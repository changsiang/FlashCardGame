using FlashCardGame.Operation;
using FlashCardGame.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace FlashCardGame
{
    public partial class Form1 : Form
    {
        string[] operators = { "+", "-", "x", "÷" };
        private int correctCount = 0;
        private int incorrectCount = 0;
        private int currentScore = 0;
        static int topScore = -169;
        private int timeTicker; //in seconds    
        private int timeLimit = 60; //in seconds
        private List<Tuple<string, string>> history;
        Operator ops;

        public Form1()
        {
            InitializeComponent();
            cboOps.DataSource = operators;
            cboOps.SelectedIndex = 2;
            InitializeForm();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }
        private void InitializeForm()
        {
            correctCount = 0;
            incorrectCount = 0;
            currentScore = 0;
            topScore = GetLastTopScore();
            timeTicker = timeLimit;
            btnChkAnswer.Enabled = true;
            label2.ForeColor = Color.DarkGreen;
            label2.Text = timeTicker.ToString();
            lblCorrect.Text = correctCount.ToString();
            lblIncorrect.Text = incorrectCount.ToString();
            lblTopScore.Text = topScore.ToString();
            lblCurrentScore.Text = currentScore.ToString();
            lblOutcome.Text = "";
            history = new List<Tuple<string, string>>();
            ops = OperatorFactory.GetOperator(cboOps.SelectedItem.ToString());  
            SetQuiz();
            timer1.Start();
        }
            private void SetQuiz()
        {
            Tuple<int, int> quiz = Tuple.Create(0, 0);
            try
            {
                quiz = ops.GenerateQuiz();
            }
            catch (AllCombinationTestedException e)
            {
                GameOver(e.Message);
                topScore = currentScore > topScore ? currentScore : topScore;
            }
            catch(InvalidOperationException e)
            {
                MessageBox.Show(this, e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblDigitOne.Text = quiz.Item1.ToString();
            lblDigitTwo.Text = quiz.Item2.ToString();
        }
        private void BtnChkAnswer_Click(object sender, EventArgs e)
        {
            int digitOne = int.Parse(lblDigitOne.Text);
            int digitTwo = int.Parse(lblDigitTwo.Text);
            double result = ops.PerformCalculation(digitOne, digitTwo);
            double answer;
            double.TryParse(txtAnswer.Text, out answer);
            if (answer == result)
            {
                lblOutcome.ForeColor = Color.DarkGreen;
                lblOutcome.Text = "Correct Answer!";
                correctCount++;
            }
            else
            {
                lblOutcome.ForeColor = Color.DarkRed;
                lblOutcome.Text = "Incorrect Answer.";
                incorrectCount++;
            }
            currentScore = correctCount - incorrectCount;
            lblCorrect.Text = correctCount.ToString();
            lblIncorrect.Text = incorrectCount.ToString();
            lblCurrentScore.Text = currentScore.ToString();            
            lblTopScore.Text = topScore.ToString();
            AddQuizHistory(digitOne, digitTwo, answer,cboOps.SelectedItem.ToString());
            txtAnswer.Clear();
            SetQuiz();
        }
        private void AddQuizHistory(int digitOne, int digitTwo, double answer, string ops)
        {
            string quiz = digitOne.ToString() + " " + ops + " " + digitTwo.ToString() + " = " + answer.ToString();             
            string outcome = lblOutcome.Text == "Correct Answer!" ? "Correct" : "Incorrect";
            history.Add(Tuple.Create(quiz, outcome));
            UpdateDataGrid();
        }
        private void CboOps_SelectedIndexChanged(object sender, EventArgs e)
        {
            ops = OperatorFactory.GetOperator(cboOps.SelectedItem.ToString());
        }
        private void TxtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Return) && (btnChkAnswer.Enabled != false))
            {
                BtnChkAnswer_Click(sender, e);
            }
        }
        private void GameOver(string title)
        {
            topScore = currentScore > topScore ? currentScore : topScore;
            Settings.Default.lastTopScore = topScore;

            double totalAnswered = Convert.ToDouble(correctCount + incorrectCount);
            int timeTaken = timeLimit - timeTicker;            
            double responseTime = Math.Round((timeTaken / totalAnswered) * 1000, 0);
            string message =
                "Game Over!\nScore: " + currentScore.ToString() +
                "\nTotal Answered: " + totalAnswered.ToString() + 
                "\nTime Taken: " + timeTaken.ToString() + "s" + 
                "\nReaction Time: " + responseTime + "ms";
            DialogResult dr = MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                InitializeForm();
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeTicker--;
            if(timeTicker < 20 && timeTicker > 0)
            {
                label2.ForeColor = Color.Red;
            }
            else if(timeTicker == 0)
            {
                timer1.Stop();
                GameOver("Game Over!");
            }
            label2.Text = timeTicker.ToString();
        }
        private void UpdateDataGrid()
        {
            dataGridView1.DataSource = typeof(List<Tuple<string, string>>);
            dataGridView1.DataSource = history;
            dataGridView1.Columns[0].HeaderText = "Quiz";
            dataGridView1.Columns[1].HeaderText = "Outcome";
        }
        private int GetLastTopScore()
        {
            int lastTopScore;
            try
            {
                lastTopScore = Settings.Default.lastTopScore;
            }
            catch(SettingsPropertyNotFoundException)
            {
                lastTopScore = -169;
                return lastTopScore;
            }
            return lastTopScore;
        }

    }
}
