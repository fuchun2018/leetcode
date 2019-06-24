using System.Collections.Generic;

namespace leetcode.WordSearch
{
    public class WordSearchSolution
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            var result = new List<string>();
            if (words.Length == 0 || board.Length == 0) return new List<string>();
            var trie = Build(words);
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    TraversalBoard(i, j, trie, result, board);
                }
            }
            return result;
        }

        private Trie Build(string[] words)
        {
            var result = new Trie();

            foreach (var word in words)
            {
                var current = result;
                foreach (var element in word)
                {
                    if (current.Key[element - 'a'] == null) current.Key[element - 'a'] = new Trie();
                    current = current.Key[element - 'a'];
                }

                current.Word = word;
            }

            return result;
        }

        private void TraversalBoard(int x, int y, Trie trie, List<string> result, char[][] board)
        {
            var _ = board[x][y];
            if (_ == '\0') return;
            if (trie.Key[_ - 'a'] == null) return;
            trie = trie.Key[_ - 'a'];
            if (string.IsNullOrEmpty(trie.Word) != true && result.Contains(trie.Word) != true) result.Add(trie.Word);


            board[x][y] = '\0';
            if (y < board[0].Length - 1)
                TraversalBoard(x, y + 1, trie, result, board);
            if (y > 0)
                TraversalBoard(x, y - 1, trie, result, board);
            if (x < board.Length - 1)
                TraversalBoard(x + 1, y, trie, result, board);
            if (x > 0)
                TraversalBoard(x - 1, y, trie, result, board);
            board[x][y] = _;
        }

        private class Trie
        {
            public Trie[] Key { get; set; } = new Trie[26];
            public string Word { get; set; }
        }
    }
}