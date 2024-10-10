using System.Data;
using System.Diagnostics.Metrics;
using IronXL;
using SixLabors.Fonts.Unicode;

namespace GuessTheCharacter
{
    public partial class MainForm : Form
    {
        private DataTable dataTable = new DataTable();
        private List<string> headerList;
        private List<string> valueList;
        private int characterIndex;
        private string character;
        private int counter;
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataTable = DataTableUtils.Read(@"Data\game_dataset.csv");

            if (dataTable is null)
            {
                MessageBox.Show("Cannot load any dataset");
                Application.Exit();
            }
            initGame();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            initGame();

        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (counter <= 0)
            {
                MessageBox.Show("הגעת למכסה של שאלות נסה לחשוב ללא עזרה");
                return;
            }
            
        


            if (lstQuestions.SelectedItem != null)
            {
                counter--;
                lblCounterQuestions.Text = $"נותרו עוד {counter} נסיונות מתוך 10";
                AddChat(lstQuestions.SelectedItem.ToString(), Color.Black);
                if (dataTable is not null)
                {
                    string colName = lstQuestions.SelectedItem.ToString();
                    bool isAnswerCorrect = dataTable.Rows[characterIndex][colName] != "" ? true : false;
                    AddChat(isAnswerCorrect ? "נכון" : "לא נכון", isAnswerCorrect ? Color.Green : Color.Red);
                }
                lstQuestions.Items.Remove(lstQuestions.SelectedItem);
            }



        }
        private void AddChat(string chatText, Color chatColor)
        {
            Label lblChat = new Label();
            lblChat.Text = chatText;
            lblChat.ForeColor = chatColor;
            Font ChatFont = new Font("Arial", 14, FontStyle.Bold);
            lblChat.Font = ChatFont;

            lblChat.AutoSize = true;
            lblChat.RightToLeft = RightToLeft.Yes;
            flpChat.Controls.Add(lblChat);
            flpChat.ScrollControlIntoView(lblChat);
        }

        private void flpChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstDeleteCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDeleteCharacters.SelectedItem != null)
            {
                lstCharacters.Items.Add(lstDeleteCharacters.SelectedItem);
                lstDeleteCharacters.Items.Remove(lstDeleteCharacters.SelectedItem);

            }
        }

        private void lstCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCharacters.SelectedItem != null)
            {
                lstDeleteCharacters.Items.Add(lstCharacters.SelectedItem);
                lstCharacters.Items.Remove(lstCharacters.SelectedItem);

            }

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string guess = guessName.Text;
            if (character == guess)
            {
                MessageBox.Show("היידד ניצחת!");
            }
            else
            {
                MessageBox.Show("הפסדת :( לא נורא נסה שוב");
                initGame();
            }

        }

        private void initGame()
        {
            lstDeleteCharacters.Items.Clear();
            lstCharacters.Items.Clear();
            lstQuestions.Items.Clear();
            flpChat.Controls.Clear();
            guessName.Clear();
            counter = 10;

            lblCounterQuestions.Text = $"נותרו עוד {counter} נסיונות מתוך 10";

            headerList = DataTableUtils.HeaderToList(dataTable);
            valueList = DataTableUtils.ColumnToList(dataTable, 0);

            for (int i = 1; i < headerList.Count; i++)
            {
                lstQuestions.Items.Add(headerList[i]);
            }

            for (int i = 0; i < valueList.Count; i++)
            {
                lstCharacters.Items.Add(valueList[i]);
            }

            Random rnd = new Random();
            characterIndex = rnd.Next(0, valueList.Count);
            character = valueList[characterIndex];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

