using FinalsOOP;
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

namespace FinalsOOP {
    public partial class ExerciseForm : Form {
        private Question currentQuestion; // Declare the class of Question, to access the object of the class
        private int questionNum = 0; // Variable for the current index of question
        private int num = 1; // Variable for the what number of question is displayed
        private int userScore = 0; // Current score of the user
        private int passingScore = 7;
        private int numTry = 3; // User number of tries for taking the quiz
        private bool isDone = false; // Check if the quiz is done
        private int timeRemaining; // in seconds
        Random random = new Random();

        // List of all questions
        List<Question> questions = new List<Question> {
    new Question("What is the capital of Japan?", new string[] { "Beijing", "Tokyo", "Seoul", "Bangkok" }, 1, "C:/Users/kenth/source/repos/FinalsOOP/images/japan.png"),
    new Question("Who wrote the play \"Romeo and Juliet\"?", new string[] { "Charles Dickens", "Jane Austen", "Mark Twain", "William Shakespeare" }, 3, "C:/Users/kenth/source/repos/FinalsOOP/images/romeojuliet.jpg"),
    new Question("Which planet is known as the \"Red Planet\"?", new string[] { "Earth", "Jupiter", "Mars", "Venus" }, 2, "C:/Users/kenth/source/repos/FinalsOOP/images/solarsystem.jpg"),
    new Question("What is the largest mammal on Earth?", new string[] { "Blue Whale", "Elephant", "Giraffe", "Dolphin" }, 0 , "C:/Users/kenth/source/repos/FinalsOOP/images/nature.jpg"),
    new Question("In which year did the Titanic sink?", new string[] { "1905", "1912", "1920", "1935" }, 1, "C:/Users/kenth/source/repos/FinalsOOP/images/titanic.jpg"),
    new Question("What is the capital of Australia?", new string[] { "Sydney", "Melbourne", "Canberra", "Perth" }, 2, "C:/Users/kenth/source/repos/FinalsOOP/images/australia.jpg"),
    new Question("Who painted the Mona Lisa?", new string[] { "Vincent van Gogh", "Pablo Picasso", "Michelangelo", "Leonardo da Vinci" }, 3, "C:/Users/kenth/source/repos/FinalsOOP/images/monalisa.jpg"),
    new Question("What is the chemical symbol for gold?", new string[] { "Gd", "Au", "Ag", "Fe" }, 1, "C:/Users/kenth/source/repos/FinalsOOP/images/gold.jpg"),
    new Question("What is the powerhouse of the cell?", new string[] { "Mitochondria", "Nucleus", "Endoplasmic reticulum", "Golgi apparatus" }, 0, "C:/Users/kenth/source/repos/FinalsOOP/images/cell.jpg"),
    new Question("Which programming language was developed by Microsoft?", new string[] { "Java", "Python", "C#", "Ruby" }, 2, "C:/Users/kenth/source/repos/FinalsOOP/images/programminglang.jpg"),
 new Question("Who is the author of the Harry Potter series?", new string[] { "J.R.R. Tolkien", "J.K. Rowling", "George R.R. Martin", "Dan Brown" }, 1, "C:/Users/kenth/source/repos/FinalsOOP/images/harrypotter.jpg")
        ,  new Question("What is the capital of France?", new string[] { "Berlin", "London", "Madrid", "Paris" }, 3, "C:/Users/kenth/source/repos/FinalsOOP/images/france.jpg"),
    new Question("Who wrote the play \"Hamlet\"?", new string[] { "Charles Dickens", "William Shakespeare", "Jane Austen", "Mark Twain" }, 1, "C:/Users/kenth/source/repos/FinalsOOP/images/hamlet.jpg"),
    new Question("Which gas do plants absorb during photosynthesis?", new string[] { "Carbon Dioxide", "Oxygen", "Nitrogen", "Hydrogen" }, 0, "C:/Users/kenth/source/repos/FinalsOOP/images/plant.jpg"),
    new Question("What is the tallest mountain in the world?", new string[] { "Mount Kilimanjaro", "Mount Everest", "K2", "Matterhorn" }, 1, "C:/Users/kenth/source/repos/FinalsOOP/images/mteverest.jpg"),
    new Question("In which year did World War II end?", new string[] { "1943", "1950", "1945", "1939" }, 2, "C:/Users/kenth/source/repos/FinalsOOP/images/wwII.jpg"),
    new Question("What is the largest ocean on Earth?", new string[] { "Atlantic Ocean", "Indian Ocean", "Southern Ocean", "Pacific Ocean" }, 3, "C:/Users/kenth/source/repos/FinalsOOP/images/pacific-ocean.jpg"),
    new Question("Who invented the telephone?", new string[] { "Thomas Edison", "Alexander Graham Bell", "Nikola Tesla", "Marie Curie" }, 1, "C:/Users/kenth/source/repos/FinalsOOP/images/telephone.jpg"),
    new Question("What is the chemical symbol for water?", new string[] { "H2O", "CO2", "O2", "N2" }, 0, "C:/Users/kenth/source/repos/FinalsOOP/images/water.jpg"),
    new Question("Who is known as the \"Father of Computer Science\"?", new string[] { "Zark Muckerburg", "Charles Babbage", "Alan Turing", "Bill Gates" }, 2, "C:/Users/kenth/source/repos/FinalsOOP/images/alanturing.jpg")};

        public ExerciseForm() {
            InitializeComponent();
            generateRandom();
            generateQuestion();
            InitializeTimer();
        }
        // Start and display 30 seconds timer 
        private void InitializeTimer() {
            timer1 = new Timer();
            timer1.Interval = 1000; // 1 second interval
            timer1.Tick += timer1_Tick;
            timeRemaining = 30;
            lblTimeRemainingVal.Text = $"{timeRemaining / 60}:{timeRemaining % 60:D2}"; // Set initial timer display
            timer1.Start(); // Start the timer
        }

        private void generateQuestion() {
            // Check if there are more questions
            if (questionNum < questions.Count) {
                currentQuestion = questions[questionNum]; // Sets the value of current question from the value of question in list

                lblQuestion.Text = currentQuestion.getQuestion(); // Display the question

                // Change the button text to match the choices
                btnAnswer1.Text = currentQuestion.getChoices(0);
                btnAnswer2.Text = currentQuestion.getChoices(1);
                btnAnswer3.Text = currentQuestion.getChoices(2);
                btnAnswer4.Text = currentQuestion.getChoices(3);
                // Catch if file not found
                try {
                    pbQuestion.Image = Image.FromFile(currentQuestion.img);
                } catch (FileNotFoundException ex) {
                }

                lblNumber.Text = "Question " + num.ToString() + ":"; // Display for the current number of question

                questionNum += 2; // Since the overall count of Question is 20, the increment is +2 to limit the question to 10 items
                num++; // Current question number
            } else {
                isPassedOrFailed();
            }
        }
        // Algorithm for generating a random number
        // The order of the questions will be random
        private void generateRandom() {
            int n = questions.Count;
            while (n > 1) {
                n--;
                int k = random.Next(n + 1);
                Question value = questions[k];
                questions[k] = questions[n];
                questions[n] = value;
            }
        }
        // Prevents the user from exiting the form while the quiz is ongoing
        private void ExerciseForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (!isDone) {
                MessageBox.Show($"Cannot close the form. Exam is still ongoing.", "Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        // Checks the answer of the user if the button clicked is the right answer
        private void checkAnswer(object sender, EventArgs e) {
            try {
                Button btnAnswer = (Button)sender;
                Button[] answerButtons = { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };
                int correctAnswerIndex = currentQuestion.answer;
                // Check if the text of button cliked is equal to the answer 
                if (btnAnswer.Text.Equals(currentQuestion.getChoices(correctAnswerIndex))) {
                    userScore++;
                    lblCurrentScoreVal.Text = userScore.ToString();
                    // Decrement the passing score when it is greater than 0
                    if (passingScore > 0) {
                        passingScore--;
                    }
                    lblPassingScoreVal.Text = passingScore.ToString();
                    // Highlight the correct answer button
                    switch (correctAnswerIndex) {
                        case 0:
                        btnAnswer1.BackColor = Color.Green;
                        break;
                        case 1:
                        btnAnswer2.BackColor = Color.Green;
                        break;
                        case 2:
                        btnAnswer3.BackColor = Color.Green;
                        break;
                        case 3:
                        btnAnswer4.BackColor = Color.Green;
                        break;
                    }
                } else {
                    // The selected answer is incorrect
                    btnAnswer.BackColor = Color.Red;
                }

                Refresh();

                foreach (var button in answerButtons) button.Visible = false; // Hide all buttons - Prevents the user from clicking the button simultaneously because I am encountering a problem in the timer whenever the user click the button fast simultaneously

                btnAnswer.Visible = true;
                btnAnswer.Enabled = false;

                // Unhide all buttons after a second
                Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (timerSender, timerArgs) => {
                    timer.Stop(); // Stop the timer
                                  
                    foreach (var button in answerButtons) button.Visible = true; // Unhide all buttons

                    btnAnswer.Enabled = true;
                    resetButtonColors(); // Reset button colors and proceed to the next question
                    generateQuestion(); // Generate a new question
                    btnAnswer1.Focus();
                };
                timer.Start();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "An exception has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // If the time is greater than 0 continue the countdown
        // Else check if the user is passed or failed
        private void timer1_Tick(object sender, EventArgs e) {
            if (timeRemaining > 0) {
                timeRemaining--;
                lblTimeRemainingVal.Text = $"{timeRemaining / 60}:{timeRemaining % 60:D2}";
            } else {
                isPassedOrFailed();
            }
        }
        // Check if the user is passed or failed
        private void isPassedOrFailed() {
            try {
                timer1.Stop();
              
                // User failed... The quiz will continuously run until the user passed the test or run out of tries
                if (userScore < 7) {

                    numTry--; // Subtract 1 to user number of tries 
                    lblNumTryVal.Text = numTry.ToString();

                    if (numTry < 1) {
                        isDone = true;
                        MessageBox.Show($"Sorry you have no number of tries left. Better luck next time!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    } else {
                        MessageBox.Show($"Failed!\nYour score is {userScore} / {questions.Count / 2}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Retaking the quiz...", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset all variables to from the start - Start the timer back to 30 seconds - Generate a new random question
                        questionNum = 0;
                        num = 1;
                        userScore = 0;
                        passingScore = 7;
                        InitializeTimer();
                        lblCurrentScoreVal.Text = userScore.ToString();
                        lblPassingScoreVal.Text = passingScore.ToString();
                        generateRandom();
                        generateQuestion();
                    }

                } else {
                    // User passed... The quiz will be closed.
                    isDone = true;
                    MessageBox.Show($"Passed!\nYour score is {userScore} / {questions.Count / 2}", "Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "An exception has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Reset all button colors to default
        private void resetButtonColors() {
            btnAnswer1.BackColor = SystemColors.Control;
            btnAnswer2.BackColor = SystemColors.Control;
            btnAnswer3.BackColor = SystemColors.Control;
            btnAnswer4.BackColor = SystemColors.Control;
        }
    }
}
