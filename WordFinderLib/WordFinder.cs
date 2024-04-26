using System.Text;

namespace WordFinderLib
{
    class FindedWord
    {
        public string word { get; set; }
        public int timesRepeated { get; set; }

        public FindedWord(string findedWord)
        {
            word = findedWord;
            timesRepeated = 1;
        }
    }

    public class WordFinder
    {
        IEnumerable<string> matrixH;//Horizontal
        IEnumerable<string> matrixV;//Vertical
        List<FindedWord> findedWords = new List<FindedWord>();

        public WordFinder(IEnumerable<string> matrix)
        {
            matrixH = matrix;

            //matrix must be 64x64
            ValidateMatrix();

            matrixV = RotateMatrix(matrix);
        }

        public IEnumerable<string> RotateMatrix(IEnumerable<string> matrix)
        {
            List<string> currentMatrix = matrix.ToList();
            List<string> rotatedMatrix = new List<string>();

            for (int i = 0; i < 64; i++)
            {
                StringBuilder rotatedRow = new StringBuilder();
                for (int j = 0; j < 64; j++)
                {
                    rotatedRow.Append(currentMatrix[j][i]);
                }
                rotatedMatrix.Add(rotatedRow.ToString());
            }

            return rotatedMatrix;
        }

        public IEnumerable<string> Find(IEnumerable<string> wordsream)
        {
            foreach (string word in wordsream)
            {
                //search horizontaly
                foreach(string row in matrixH)
                {
                    int index = -1;
                    int starPosition = 0;
                    do
                    {
                        index = row.IndexOf(word, starPosition);
                        if (index != -1)
                        {
                            AddFindedWord(word);
                            starPosition = index + 1;
                        }
                    } while (index != -1);
                }

                //search verticaly
                foreach (string row in matrixV)
                {
                    int index = -1;
                    int starPosition = 0;
                    do
                    {
                        index = row.IndexOf(word, starPosition);
                        if (index != -1)
                        {
                            AddFindedWord(word);
                            starPosition = index + 1;
                        }
                    } while (index != -1);
                }
            }

            //return the top 10 most repeated words
            IEnumerable<string> result = findedWords.OrderByDescending(fw => fw.timesRepeated).Take(10).Select(fw => fw.word);

            //return an empty set of strings if no words are found
            if(!result.Any())
                result = new List<string>();

            return result;
        }

        private void AddFindedWord(string word)
        {
            if (findedWords.Exists(w => w.word == word))
            {
                findedWords.Where(w => w.word == word).First().timesRepeated++;
            }
            else
            {
                FindedWord findedWord = new FindedWord(word);

                findedWords.Add(findedWord);
            }
        }

        private void ValidateMatrix()
        {
            if (matrixH.Count() != 64) throw new Exception("The matrix must be 64x64");

            foreach(string row in matrixH)
            {
                if(row.Length != 64) throw new Exception("The matrix must be 64x64");
            }
        }
    }
}
