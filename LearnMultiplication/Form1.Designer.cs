
namespace LearnMultiplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CountDown = new System.Windows.Forms.ProgressBar();
            this.Start = new System.Windows.Forms.Button();
            this.SolveThis = new System.Windows.Forms.RichTextBox();
            this.Answer = new System.Windows.Forms.RichTextBox();
            this.ConfirmAnswer = new System.Windows.Forms.Button();
            this.Correct = new System.Windows.Forms.Label();
            this.WrongAnswers = new System.Windows.Forms.RichTextBox();
            this.FinalScore = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CopyWrong = new System.Windows.Forms.Button();
            this.ClearWrong = new System.Windows.Forms.Button();
            this.FlashButton = new System.Windows.Forms.Button();
            this.FlashCard = new System.Windows.Forms.RichTextBox();
            this.FlashAnswer = new System.Windows.Forms.RichTextBox();
            this.ShowFlashAnswer = new System.Windows.Forms.Button();
            this.LockNumberCheck = new System.Windows.Forms.CheckBox();
            this.SpecificTable = new System.Windows.Forms.TextBox();
            this.ProblemList = new System.Windows.Forms.ListBox();
            this.AnswerList = new System.Windows.Forms.ListBox();
            this.ClearFlashCards = new System.Windows.Forms.Button();
            this.SpecificTable2 = new System.Windows.Forms.TextBox();
            this.LockRange = new System.Windows.Forms.CheckBox();
            this.LowRange = new System.Windows.Forms.TextBox();
            this.HighRange = new System.Windows.Forms.TextBox();
            this.ExcludeEasy = new System.Windows.Forms.CheckBox();
            this.DeleteAllFlashCards = new System.Windows.Forms.Button();
            this.DeleteSafety = new System.Windows.Forms.CheckBox();
            this.LoadAllFlashcards = new System.Windows.Forms.Button();
            this.MathTimer = new System.Windows.Forms.Timer(this.components);
            this.PersonalBestLabel = new System.Windows.Forms.Label();
            this.PracticeBox = new System.Windows.Forms.CheckBox();
            this.RecordBox = new System.Windows.Forms.CheckBox();
            this.DeleteCurrentFlash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountDown
            // 
            this.CountDown.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountDown.Location = new System.Drawing.Point(13, 13);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(1039, 42);
            this.CountDown.Step = 4;
            this.CountDown.TabIndex = 0;
            this.CountDown.Click += new System.EventHandler(this.CountDown_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Start.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start.Location = new System.Drawing.Point(359, 185);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(318, 116);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // SolveThis
            // 
            this.SolveThis.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SolveThis.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SolveThis.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SolveThis.Location = new System.Drawing.Point(359, 307);
            this.SolveThis.Name = "SolveThis";
            this.SolveThis.Size = new System.Drawing.Size(318, 96);
            this.SolveThis.TabIndex = 2;
            this.SolveThis.Text = "";
            this.SolveThis.TextChanged += new System.EventHandler(this.SolveThis_TextChanged);
            // 
            // Answer
            // 
            this.Answer.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Answer.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Answer.Location = new System.Drawing.Point(359, 409);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(159, 96);
            this.Answer.TabIndex = 3;
            this.Answer.Text = "";
            this.Answer.TextChanged += new System.EventHandler(this.Answer_TextChanged);
            // 
            // ConfirmAnswer
            // 
            this.ConfirmAnswer.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmAnswer.Location = new System.Drawing.Point(525, 410);
            this.ConfirmAnswer.Name = "ConfirmAnswer";
            this.ConfirmAnswer.Size = new System.Drawing.Size(152, 95);
            this.ConfirmAnswer.TabIndex = 4;
            this.ConfirmAnswer.Text = "OK";
            this.ConfirmAnswer.UseVisualStyleBackColor = true;
            this.ConfirmAnswer.Click += new System.EventHandler(this.ConfirmAnswer_Click);
            // 
            // Correct
            // 
            this.Correct.AutoSize = true;
            this.Correct.Location = new System.Drawing.Point(359, 512);
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(122, 42);
            this.Correct.TabIndex = 5;
            this.Correct.Text = "label1";
            this.Correct.Click += new System.EventHandler(this.Correct_Click);
            // 
            // WrongAnswers
            // 
            this.WrongAnswers.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.WrongAnswers.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.WrongAnswers.Location = new System.Drawing.Point(13, 62);
            this.WrongAnswers.Name = "WrongAnswers";
            this.WrongAnswers.Size = new System.Drawing.Size(253, 506);
            this.WrongAnswers.TabIndex = 6;
            this.WrongAnswers.Text = "";
            this.WrongAnswers.TextChanged += new System.EventHandler(this.WrongAnswers_TextChanged);
            // 
            // FinalScore
            // 
            this.FinalScore.AutoSize = true;
            this.FinalScore.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinalScore.Location = new System.Drawing.Point(359, 65);
            this.FinalScore.Name = "FinalScore";
            this.FinalScore.Size = new System.Drawing.Size(103, 35);
            this.FinalScore.TabIndex = 7;
            this.FinalScore.Text = "label1";
            this.FinalScore.Click += new System.EventHandler(this.FinalScore_Click);
            // 
            // CopyWrong
            // 
            this.CopyWrong.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyWrong.Location = new System.Drawing.Point(13, 574);
            this.CopyWrong.Name = "CopyWrong";
            this.CopyWrong.Size = new System.Drawing.Size(120, 90);
            this.CopyWrong.TabIndex = 8;
            this.CopyWrong.Text = "Copy";
            this.CopyWrong.UseVisualStyleBackColor = true;
            this.CopyWrong.Click += new System.EventHandler(this.CopyWrong_Click);
            // 
            // ClearWrong
            // 
            this.ClearWrong.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearWrong.Location = new System.Drawing.Point(146, 574);
            this.ClearWrong.Name = "ClearWrong";
            this.ClearWrong.Size = new System.Drawing.Size(120, 90);
            this.ClearWrong.TabIndex = 9;
            this.ClearWrong.Text = "Clear";
            this.ClearWrong.UseVisualStyleBackColor = true;
            this.ClearWrong.Click += new System.EventHandler(this.ClearWrong_Click);
            // 
            // FlashButton
            // 
            this.FlashButton.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlashButton.Location = new System.Drawing.Point(734, 293);
            this.FlashButton.Name = "FlashButton";
            this.FlashButton.Size = new System.Drawing.Size(318, 95);
            this.FlashButton.TabIndex = 10;
            this.FlashButton.Text = "Flash";
            this.FlashButton.UseVisualStyleBackColor = true;
            this.FlashButton.Click += new System.EventHandler(this.FlashButton_Click);
            // 
            // FlashCard
            // 
            this.FlashCard.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FlashCard.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlashCard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FlashCard.Location = new System.Drawing.Point(734, 394);
            this.FlashCard.Name = "FlashCard";
            this.FlashCard.Size = new System.Drawing.Size(318, 96);
            this.FlashCard.TabIndex = 11;
            this.FlashCard.Text = "";
            this.FlashCard.TextChanged += new System.EventHandler(this.FlashCard_TextChanged);
            // 
            // FlashAnswer
            // 
            this.FlashAnswer.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FlashAnswer.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlashAnswer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FlashAnswer.Location = new System.Drawing.Point(893, 496);
            this.FlashAnswer.Name = "FlashAnswer";
            this.FlashAnswer.Size = new System.Drawing.Size(159, 96);
            this.FlashAnswer.TabIndex = 12;
            this.FlashAnswer.Text = "";
            this.FlashAnswer.TextChanged += new System.EventHandler(this.FlashAnswer_TextChanged);
            // 
            // ShowFlashAnswer
            // 
            this.ShowFlashAnswer.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowFlashAnswer.Location = new System.Drawing.Point(734, 496);
            this.ShowFlashAnswer.Name = "ShowFlashAnswer";
            this.ShowFlashAnswer.Size = new System.Drawing.Size(153, 95);
            this.ShowFlashAnswer.TabIndex = 13;
            this.ShowFlashAnswer.Text = "Show";
            this.ShowFlashAnswer.UseVisualStyleBackColor = true;
            this.ShowFlashAnswer.Click += new System.EventHandler(this.ShowFlashAnswer_Click);
            // 
            // LockNumberCheck
            // 
            this.LockNumberCheck.AutoSize = true;
            this.LockNumberCheck.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LockNumberCheck.Location = new System.Drawing.Point(359, 574);
            this.LockNumberCheck.Name = "LockNumberCheck";
            this.LockNumberCheck.Size = new System.Drawing.Size(155, 22);
            this.LockNumberCheck.TabIndex = 14;
            this.LockNumberCheck.Text = "Lock Number(s)";
            this.LockNumberCheck.UseVisualStyleBackColor = true;
            this.LockNumberCheck.CheckedChanged += new System.EventHandler(this.LockNumberCheck_CheckedChanged);
            // 
            // SpecificTable
            // 
            this.SpecificTable.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecificTable.Location = new System.Drawing.Point(520, 569);
            this.SpecificTable.Name = "SpecificTable";
            this.SpecificTable.Size = new System.Drawing.Size(31, 33);
            this.SpecificTable.TabIndex = 15;
            this.SpecificTable.TextChanged += new System.EventHandler(this.SpecificTable_TextChanged);
            // 
            // ProblemList
            // 
            this.ProblemList.FormattingEnabled = true;
            this.ProblemList.ItemHeight = 42;
            this.ProblemList.Location = new System.Drawing.Point(272, 62);
            this.ProblemList.Name = "ProblemList";
            this.ProblemList.Size = new System.Drawing.Size(81, 172);
            this.ProblemList.TabIndex = 16;
            this.ProblemList.Visible = false;
            this.ProblemList.SelectedIndexChanged += new System.EventHandler(this.ProblemList_SelectedIndexChanged);
            // 
            // AnswerList
            // 
            this.AnswerList.FormattingEnabled = true;
            this.AnswerList.ItemHeight = 42;
            this.AnswerList.Location = new System.Drawing.Point(272, 240);
            this.AnswerList.Name = "AnswerList";
            this.AnswerList.Size = new System.Drawing.Size(81, 172);
            this.AnswerList.TabIndex = 17;
            this.AnswerList.Visible = false;
            this.AnswerList.SelectedIndexChanged += new System.EventHandler(this.AnswerList_SelectedIndexChanged);
            // 
            // ClearFlashCards
            // 
            this.ClearFlashCards.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearFlashCards.Location = new System.Drawing.Point(734, 257);
            this.ClearFlashCards.Name = "ClearFlashCards";
            this.ClearFlashCards.Size = new System.Drawing.Size(318, 30);
            this.ClearFlashCards.TabIndex = 18;
            this.ClearFlashCards.Text = "Clear These Flashcards";
            this.ClearFlashCards.UseVisualStyleBackColor = true;
            this.ClearFlashCards.Click += new System.EventHandler(this.ClearFlashCards_Click);
            // 
            // SpecificTable2
            // 
            this.SpecificTable2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecificTable2.Location = new System.Drawing.Point(555, 569);
            this.SpecificTable2.Name = "SpecificTable2";
            this.SpecificTable2.Size = new System.Drawing.Size(31, 33);
            this.SpecificTable2.TabIndex = 19;
            this.SpecificTable2.TextChanged += new System.EventHandler(this.SpecificTable2_TextChanged);
            // 
            // LockRange
            // 
            this.LockRange.AutoSize = true;
            this.LockRange.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LockRange.Location = new System.Drawing.Point(359, 612);
            this.LockRange.Name = "LockRange";
            this.LockRange.Size = new System.Drawing.Size(120, 22);
            this.LockRange.TabIndex = 20;
            this.LockRange.Text = "Lock Range";
            this.LockRange.UseVisualStyleBackColor = true;
            this.LockRange.CheckedChanged += new System.EventHandler(this.LockRange_CheckedChanged);
            // 
            // LowRange
            // 
            this.LowRange.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LowRange.Location = new System.Drawing.Point(520, 605);
            this.LowRange.Name = "LowRange";
            this.LowRange.Size = new System.Drawing.Size(31, 33);
            this.LowRange.TabIndex = 21;
            this.LowRange.TextChanged += new System.EventHandler(this.LowRange_TextChanged);
            // 
            // HighRange
            // 
            this.HighRange.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HighRange.Location = new System.Drawing.Point(555, 605);
            this.HighRange.Name = "HighRange";
            this.HighRange.Size = new System.Drawing.Size(31, 33);
            this.HighRange.TabIndex = 22;
            this.HighRange.TextChanged += new System.EventHandler(this.HighRange_TextChanged);
            // 
            // ExcludeEasy
            // 
            this.ExcludeEasy.AutoSize = true;
            this.ExcludeEasy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcludeEasy.Location = new System.Drawing.Point(359, 647);
            this.ExcludeEasy.Name = "ExcludeEasy";
            this.ExcludeEasy.Size = new System.Drawing.Size(305, 22);
            this.ExcludeEasy.TabIndex = 23;
            this.ExcludeEasy.Text = "Exclude Easy 5 / 10 / (11 * x<10)";
            this.ExcludeEasy.UseVisualStyleBackColor = true;
            this.ExcludeEasy.CheckedChanged += new System.EventHandler(this.ExcludeEasy_CheckedChanged);
            // 
            // DeleteAllFlashCards
            // 
            this.DeleteAllFlashCards.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteAllFlashCards.Location = new System.Drawing.Point(734, 150);
            this.DeleteAllFlashCards.Name = "DeleteAllFlashCards";
            this.DeleteAllFlashCards.Size = new System.Drawing.Size(318, 30);
            this.DeleteAllFlashCards.TabIndex = 24;
            this.DeleteAllFlashCards.Text = "Delete ALL Flashcards";
            this.DeleteAllFlashCards.UseVisualStyleBackColor = true;
            this.DeleteAllFlashCards.Click += new System.EventHandler(this.DeleteAllFlashCards_Click);
            // 
            // DeleteSafety
            // 
            this.DeleteSafety.AutoSize = true;
            this.DeleteSafety.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteSafety.Location = new System.Drawing.Point(734, 122);
            this.DeleteSafety.Name = "DeleteSafety";
            this.DeleteSafety.Size = new System.Drawing.Size(202, 22);
            this.DeleteSafety.TabIndex = 25;
            this.DeleteSafety.Text = "Unlock Delete Button";
            this.DeleteSafety.UseVisualStyleBackColor = true;
            this.DeleteSafety.CheckedChanged += new System.EventHandler(this.DeleteSafety_CheckedChanged);
            // 
            // LoadAllFlashcards
            // 
            this.LoadAllFlashcards.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadAllFlashcards.Location = new System.Drawing.Point(734, 221);
            this.LoadAllFlashcards.Name = "LoadAllFlashcards";
            this.LoadAllFlashcards.Size = new System.Drawing.Size(318, 30);
            this.LoadAllFlashcards.TabIndex = 26;
            this.LoadAllFlashcards.Text = "Load All Flashcards";
            this.LoadAllFlashcards.UseVisualStyleBackColor = true;
            this.LoadAllFlashcards.Click += new System.EventHandler(this.LoadAllFlashcards_Click);
            // 
            // MathTimer
            // 
            this.MathTimer.Tick += new System.EventHandler(this.MathTimer_Tick);
            // 
            // PersonalBestLabel
            // 
            this.PersonalBestLabel.AutoSize = true;
            this.PersonalBestLabel.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonalBestLabel.Location = new System.Drawing.Point(734, 65);
            this.PersonalBestLabel.Name = "PersonalBestLabel";
            this.PersonalBestLabel.Size = new System.Drawing.Size(103, 35);
            this.PersonalBestLabel.TabIndex = 27;
            this.PersonalBestLabel.Text = "label1";
            this.PersonalBestLabel.Click += new System.EventHandler(this.PersonalBestLabel_Click);
            // 
            // PracticeBox
            // 
            this.PracticeBox.AutoSize = true;
            this.PracticeBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PracticeBox.Location = new System.Drawing.Point(359, 129);
            this.PracticeBox.Name = "PracticeBox";
            this.PracticeBox.Size = new System.Drawing.Size(91, 22);
            this.PracticeBox.TabIndex = 28;
            this.PracticeBox.Text = "Practice";
            this.PracticeBox.UseVisualStyleBackColor = true;
            this.PracticeBox.CheckedChanged += new System.EventHandler(this.PracticeBox_CheckedChanged);
            // 
            // RecordBox
            // 
            this.RecordBox.AutoSize = true;
            this.RecordBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecordBox.Location = new System.Drawing.Point(359, 157);
            this.RecordBox.Name = "RecordBox";
            this.RecordBox.Size = new System.Drawing.Size(182, 22);
            this.RecordBox.TabIndex = 29;
            this.RecordBox.Text = "Go For New Record";
            this.RecordBox.UseVisualStyleBackColor = true;
            this.RecordBox.CheckedChanged += new System.EventHandler(this.RecordBox_CheckedChanged);
            // 
            // DeleteCurrentFlash
            // 
            this.DeleteCurrentFlash.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteCurrentFlash.Location = new System.Drawing.Point(734, 186);
            this.DeleteCurrentFlash.Name = "DeleteCurrentFlash";
            this.DeleteCurrentFlash.Size = new System.Drawing.Size(318, 30);
            this.DeleteCurrentFlash.TabIndex = 30;
            this.DeleteCurrentFlash.Text = "Delete THIS Flashcards";
            this.DeleteCurrentFlash.UseVisualStyleBackColor = true;
            this.DeleteCurrentFlash.Click += new System.EventHandler(this.DeleteCurrentFlash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.DeleteCurrentFlash);
            this.Controls.Add(this.RecordBox);
            this.Controls.Add(this.PracticeBox);
            this.Controls.Add(this.PersonalBestLabel);
            this.Controls.Add(this.LoadAllFlashcards);
            this.Controls.Add(this.DeleteSafety);
            this.Controls.Add(this.DeleteAllFlashCards);
            this.Controls.Add(this.ExcludeEasy);
            this.Controls.Add(this.HighRange);
            this.Controls.Add(this.LowRange);
            this.Controls.Add(this.LockRange);
            this.Controls.Add(this.SpecificTable2);
            this.Controls.Add(this.ClearFlashCards);
            this.Controls.Add(this.AnswerList);
            this.Controls.Add(this.ProblemList);
            this.Controls.Add(this.SpecificTable);
            this.Controls.Add(this.LockNumberCheck);
            this.Controls.Add(this.ShowFlashAnswer);
            this.Controls.Add(this.FlashAnswer);
            this.Controls.Add(this.FlashCard);
            this.Controls.Add(this.FlashButton);
            this.Controls.Add(this.ClearWrong);
            this.Controls.Add(this.CopyWrong);
            this.Controls.Add(this.FinalScore);
            this.Controls.Add(this.WrongAnswers);
            this.Controls.Add(this.Correct);
            this.Controls.Add(this.ConfirmAnswer);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.SolveThis);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.CountDown);
            this.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Multiplication Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar CountDown;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RichTextBox SolveThis;
        private System.Windows.Forms.RichTextBox Answer;
        private System.Windows.Forms.Button ConfirmAnswer;
        private System.Windows.Forms.Label Correct;
        private System.Windows.Forms.RichTextBox WrongAnswers;
        private System.Windows.Forms.Label FinalScore;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CopyWrong;
        private System.Windows.Forms.Button ClearWrong;
        private System.Windows.Forms.Button FlashButton;
        private System.Windows.Forms.RichTextBox FlashCard;
        private System.Windows.Forms.RichTextBox FlashAnswer;
        private System.Windows.Forms.Button ShowFlashAnswer;
        private System.Windows.Forms.CheckBox LockNumberCheck;
        private System.Windows.Forms.TextBox SpecificTable;
        private System.Windows.Forms.ListBox ProblemList;
        private System.Windows.Forms.ListBox AnswerList;
        private System.Windows.Forms.Button ClearFlashCards;
        private System.Windows.Forms.TextBox SpecificTable2;
        private System.Windows.Forms.CheckBox LockRange;
        private System.Windows.Forms.TextBox LowRange;
        private System.Windows.Forms.TextBox HighRange;
        private System.Windows.Forms.CheckBox ExcludeEasy;
        private System.Windows.Forms.Button DeleteAllFlashCards;
        private System.Windows.Forms.CheckBox DeleteSafety;
        private System.Windows.Forms.Button LoadAllFlashcards;
        private System.Windows.Forms.Timer MathTimer;
        private System.Windows.Forms.Label PersonalBestLabel;
        private System.Windows.Forms.CheckBox PracticeBox;
        private System.Windows.Forms.CheckBox RecordBox;
        private System.Windows.Forms.Button DeleteCurrentFlash;
    }
}

