namespace GuessTheCharacter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lstCharacters = new ListBox();
            characterImage = new PictureBox();
            lblCharactersList = new Label();
            lblCounterQuestions = new Label();
            lblQuestions = new Label();
            lblGuess = new Label();
            guessName = new TextBox();
            checkButton = new Button();
            newGame = new Button();
            lstDeleteCharacters = new ListBox();
            flpChat = new FlowLayoutPanel();
            lstQuestions = new ListBox();
            lblKnowWho = new Label();
            lblDeletedCharacters = new Label();
            ((System.ComponentModel.ISupportInitialize)characterImage).BeginInit();
            SuspendLayout();
            // 
            // lstCharacters
            // 
            lstCharacters.FormattingEnabled = true;
            lstCharacters.ItemHeight = 15;
            lstCharacters.Location = new Point(60, 44);
            lstCharacters.Name = "lstCharacters";
            lstCharacters.Size = new Size(254, 274);
            lstCharacters.TabIndex = 0;
            lstCharacters.SelectedIndexChanged += lstCharacters_SelectedIndexChanged;
            // 
            // characterImage
            // 
            characterImage.Image = (Image)resources.GetObject("characterImage.Image");
            characterImage.InitialImage = (Image)resources.GetObject("characterImage.InitialImage");
            characterImage.Location = new Point(1482, 63);
            characterImage.Name = "characterImage";
            characterImage.Size = new Size(181, 231);
            characterImage.SizeMode = PictureBoxSizeMode.StretchImage;
            characterImage.TabIndex = 1;
            characterImage.TabStop = false;
            // 
            // lblCharactersList
            // 
            lblCharactersList.AutoSize = true;
            lblCharactersList.Location = new Point(152, 9);
            lblCharactersList.Name = "lblCharactersList";
            lblCharactersList.Size = new Size(86, 15);
            lblCharactersList.TabIndex = 2;
            lblCharactersList.Text = "רשימת הדמויות";
            // 
            // lblCounterQuestions
            // 
            lblCounterQuestions.AutoSize = true;
            lblCounterQuestions.Location = new Point(692, 27);
            lblCounterQuestions.Name = "lblCounterQuestions";
            lblCounterQuestions.Size = new Size(90, 15);
            lblCounterQuestions.TabIndex = 3;
            lblCounterQuestions.Text = "שאלות שנשאלו:";
            // 
            // lblQuestions
            // 
            lblQuestions.AutoSize = true;
            lblQuestions.Location = new Point(993, 27);
            lblQuestions.Name = "lblQuestions";
            lblQuestions.Size = new Size(92, 15);
            lblQuestions.TabIndex = 4;
            lblQuestions.Text = "לחצו על השאלה";
            // 
            // lblGuess
            // 
            lblGuess.AutoSize = true;
            lblGuess.Location = new Point(1535, 27);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(89, 15);
            lblGuess.TabIndex = 5;
            lblGuess.Text = "נחשו את הדמות";
            // 
            // guessName
            // 
            guessName.Location = new Point(1496, 348);
            guessName.Name = "guessName";
            guessName.Size = new Size(167, 23);
            guessName.TabIndex = 6;
            // 
            // checkButton
            // 
            checkButton.BackColor = SystemColors.ActiveCaption;
            checkButton.Location = new Point(1535, 388);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(105, 43);
            checkButton.TabIndex = 7;
            checkButton.Text = "נחש את הדמות?";
            checkButton.UseVisualStyleBackColor = false;
            checkButton.Click += checkButton_Click;
            // 
            // newGame
            // 
            newGame.BackColor = SystemColors.ActiveCaption;
            newGame.Location = new Point(1535, 437);
            newGame.Name = "newGame";
            newGame.Size = new Size(107, 44);
            newGame.TabIndex = 8;
            newGame.Text = "משחק חדש";
            newGame.UseVisualStyleBackColor = false;
            newGame.Click += newGame_Click;
            // 
            // lstDeleteCharacters
            // 
            lstDeleteCharacters.FormattingEnabled = true;
            lstDeleteCharacters.ItemHeight = 15;
            lstDeleteCharacters.Location = new Point(60, 388);
            lstDeleteCharacters.Name = "lstDeleteCharacters";
            lstDeleteCharacters.Size = new Size(254, 364);
            lstDeleteCharacters.TabIndex = 9;
            lstDeleteCharacters.SelectedIndexChanged += lstDeleteCharacters_SelectedIndexChanged;
            // 
            // flpChat
            // 
            flpChat.AutoScroll = true;
            flpChat.BackColor = SystemColors.ActiveCaption;
            flpChat.FlowDirection = FlowDirection.TopDown;
            flpChat.Location = new Point(532, 63);
            flpChat.Name = "flpChat";
            flpChat.Size = new Size(290, 499);
            flpChat.TabIndex = 10;
            flpChat.WrapContents = false;
            flpChat.Paint += flpChat_Paint;
            // 
            // lstQuestions
            // 
            lstQuestions.FormattingEnabled = true;
            lstQuestions.ItemHeight = 15;
            lstQuestions.Location = new Point(899, 63);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(307, 499);
            lstQuestions.TabIndex = 11;
            lstQuestions.SelectedIndexChanged += lstQuestions_SelectedIndexChanged;
            // 
            // lblKnowWho
            // 
            lblKnowWho.AutoSize = true;
            lblKnowWho.Location = new Point(1540, 316);
            lblKnowWho.Name = "lblKnowWho";
            lblKnowWho.Size = new Size(93, 15);
            lblKnowWho.TabIndex = 12;
            lblKnowWho.Text = "?יודעים מי הדמות";
            // 
            // lblDeletedCharacters
            // 
            lblDeletedCharacters.AutoSize = true;
            lblDeletedCharacters.Location = new Point(143, 348);
            lblDeletedCharacters.Name = "lblDeletedCharacters";
            lblDeletedCharacters.Size = new Size(95, 15);
            lblDeletedCharacters.TabIndex = 13;
            lblDeletedCharacters.Text = "הדמויות שמחקתי";
            lblDeletedCharacters.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 1061);
            Controls.Add(lblDeletedCharacters);
            Controls.Add(lblKnowWho);
            Controls.Add(lstQuestions);
            Controls.Add(flpChat);
            Controls.Add(lstDeleteCharacters);
            Controls.Add(newGame);
            Controls.Add(checkButton);
            Controls.Add(guessName);
            Controls.Add(lblGuess);
            Controls.Add(lblQuestions);
            Controls.Add(lblCounterQuestions);
            Controls.Add(lblCharactersList);
            Controls.Add(characterImage);
            Controls.Add(lstCharacters);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)characterImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCharacters;
        private PictureBox characterImage;
        private Label lblCharactersList;
        private Label lblCounterQuestions;
        private Label lblQuestions;
        private Label lblGuess;
        private TextBox guessName;
        private Button checkButton;
        private Button newGame;
        private ListBox lstDeleteCharacters;
        private FlowLayoutPanel flpChat;
        private ListBox lstQuestions;
        private Label lblKnowWho;
        private Label lblDeletedCharacters;
    }
}
