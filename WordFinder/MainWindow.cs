using NLipsum.Core;
using System.Text.RegularExpressions;
using WordFinderLib;

namespace WordFinder
{
    public partial class MainWindow : Form
    {
        #region Fields
        IList<string> matrix = new List<string>();
        List<string> wordsToFind = new List<string>();
        BindingSource bsWordsToFind = new BindingSource();
        IEnumerable<string> findedWords = new List<string>();
        BindingSource bsFindedWords = new BindingSource();
        #endregion

        #region Contructors
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region General
        private void MainWindow_Load(object sender, EventArgs e)
        {
            FillRandomMatrix();

            UpdateGridMatrix();

            BindWordsToFindList();

            BindFindedWordsList();
        }
        #endregion

        #region WordsToFind
        private void AddWordToFind(string word)
        {
            try
            {
                ValidateWord(word);

                wordsToFind.Add(word);
                bsWordsToFind.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindWordsToFindList()
        {
            bsWordsToFind.DataSource = wordsToFind;
            lstWordsToFind.DataSource = bsWordsToFind;
        }
        private void ClearWordToFind()
        {
            txtWordToFind.Clear();
            txtWordToFind.Focus();
        }
        private void RemoveWordToFind(string word)
        {
            wordsToFind.Remove(word);
            bsWordsToFind.ResetBindings(false);
        }
        private void ValidateWord(string word)
        {
            if (string.IsNullOrEmpty(word)) throw new Exception("Capture a word");
            if (!Regex.IsMatch(word, @"^[a-zA-Z]+$")) throw new Exception("Only letters");
            if (wordsToFind.Exists(w => w == word)) throw new Exception("The word is already in the list");
        }

        #region Events
        private void btnAddWord_Click(object sender, EventArgs e)
        {
            AddWordToFind(txtWordToFind.Text);

            ClearWordToFind();
        }
        private void lstWordsToFind_DoubleClick(object sender, EventArgs e)
        {
            if (lstWordsToFind.SelectedItem != null)
            {
                string selected = (string)lstWordsToFind.SelectedItem;
                RemoveWordToFind(selected);
            }
        }
        private void txtWordToFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddWord.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        #endregion

        #endregion

        #region FindedWords
        private void BindFindedWordsList()
        {
            bsFindedWords.DataSource = findedWords;
            lstFindedWords.DataSource = bsFindedWords;
        }
        private void RefreshFindedList()
        {
            bsFindedWords.DataSource = findedWords;
        }
        private void RestartFindedList()
        {
            findedWords = new List<string>();
            RefreshFindedList();
        }

        #region Events
        private void btnFindWords_Click(object sender, EventArgs e)
        {
            try
            {
                RestartFindedList();

                WordFinderLib.WordFinder wordFinder = new WordFinderLib.WordFinder(matrix);

                findedWords = wordFinder.Find(wordsToFind);

                if (findedWords == null || findedWords.Count() == 0) MessageBox.Show("No words are found");

                RefreshFindedList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #endregion

        #region MatrixAndGrid
        public void FillPerzonalizedMatrix()
        {
            InputBoxMultiline inputBoxMultiline = new InputBoxMultiline(matrix);
            DialogResult dr = inputBoxMultiline.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                matrix = inputBoxMultiline.CapturedText.Split("\r\n");
                UpdateGridMatrix();
            }
        }
        public void FillRandomMatrix()
        {
            matrix = new List<string>();

            for (int i = 0; i < 64; i++)
            {
                string line;

                do
                {
                    line = LipsumGenerator.Generate(1);

                    // only lowercase letters
                    line =
                        Regex.Replace(line, "[^a-zA-Z0-9 -]", "")
                        .Replace(" ", "")
                        .ToLower();
                } while (line.Length < 64);// we make sure the line is at least 64 characters

                line = line.Substring(1, 64);

                matrix.Add(line);
            }
        }
        public void UpdateGridMatrix()
        {
            dgvMatrixLetters.Rows.Clear();

            foreach (string row in matrix)
            {
                dgvMatrixLetters.Rows.Add(
                    row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],
                    row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19],
                    row[20], row[21], row[22], row[23], row[24], row[25], row[26], row[27], row[28], row[29],
                    row[30], row[31], row[32], row[33], row[34], row[35], row[36], row[37], row[38], row[39],
                    row[40], row[41], row[42], row[43], row[44], row[45], row[46], row[47], row[48], row[49],
                    row[50], row[51], row[52], row[53], row[54], row[55], row[56], row[57], row[58], row[59],
                    row[60], row[61], row[62], row[63]);
            }
        }

        #region Events
        private void btnClear_Click(object sender, EventArgs e)
        {
            matrix = new List<string>();
            dgvMatrixLetters.Rows.Clear();
            RestartFindedList();
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            FillRandomMatrix();

            UpdateGridMatrix();

            RestartFindedList();
        }
        private void Personalized_Click(object sender, EventArgs e)
        {
            FillPerzonalizedMatrix();

            RestartFindedList();
        }
        #endregion

        #endregion
    }
}
