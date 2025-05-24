namespace CONSUMER_SENTIMENT_ANALYSIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnEnter_Click(object sender, EventArgs e)
        {
            // Get user input
            string userInput = txtBoxResponse.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter some text.");
                return;
            }

            // Tokenize input
            var words = userInput.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Define sentiment word sets
            var badWords = new HashSet<string> { "awful", "terrible", "poor", "bad", "worst" };
            var averageWords = new HashSet<string> { "okay", "fine", "mediocre", "average", "not bad" };
            var goodWords = new HashSet<string> { "excellent", "amazing", "great", "good", "fantastic" };

            // Count occurrences
            int badCount = words.Count(word => badWords.Contains(word));
            int averageCount = words.Count(word => averageWords.Contains(word));
            int goodCount = words.Count(word => goodWords.Contains(word));

            // Determine sentiment
            string sentiment = DetermineSentiment(badCount, averageCount, goodCount);

            // Update UI safely
            UpdateUI(sentiment);
        }

        private string DetermineSentiment(int bad, int average, int good)
        {
            if (bad > average && bad > good) return "BAD";
            if (good > bad && good > average) return "GOOD";
            return "AVERAGE"; // Default if mixed or unclear
        }

        private void UpdateUI(string sentiment)
        {
            if (picBoxBad == null || picBoxAverage == null || picBoxGood == null) return; // Safety check

            picBoxBad.Visible = sentiment == "BAD";
            picBoxAverage.Visible = sentiment == "AVERAGE";
            picBoxGood.Visible = sentiment == "GOOD";
        }

        private void bttnEnter_Click_1(object sender, EventArgs e)
        {

        }
    }
}