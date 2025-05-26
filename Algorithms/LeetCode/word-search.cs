namespace Algorithms.LeetCode;

public class word_search
{
    public bool Exist(char[][] board, string word) // rewrite with consumed declared as a rectangular array.
    { 
        bool[][] consumed = new bool[board.Length][];
        for (int m = 0; m < board.Length; m++)
        {
            consumed[m] = new bool[board[m].Length];
        }


        for (int m = 0; m < board.Length; m++)
        {
            for (int n = 0; n < board[m].Length; n++)
            {
                if (board[m][n] == word[0] && Worker(board, consumed, word, m, n, 0))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool Worker(char[][] board, bool[][] consumed, string word, int m, int n, int i) // called if board[m][n] contains word[i]
    {
        if (i == word.Length - 1)
        {
            return true;
        }

        consumed[m][n] = true;

        bool works;
        // above:
        works =
            m > 0 &&
            board[m - 1][n] == word[i + 1] &&
            !consumed[m - 1][n] &&
            Worker(board, consumed, word, m - 1, n, i + 1);
        if (works)
        {
            return true;
        }

        // right
        works = 
            n < board[m].Length - 1 &&
            board[m][n + 1] == word[i + 1] && 
            !consumed[m][n + 1] && 
            Worker(board, consumed, word, m, n + 1, i + 1);
        if (works)
        {
            return true;
        }

        // below
        works = 
            m < board.Length - 1 &&
            board[m + 1][n] == word[i + 1] && 
            !consumed[m + 1][n] && 
            Worker(board, consumed, word, m + 1, n, i + 1);
        if (works)
        {
            return true;
        }

        // left
        works =
            n > 0 &&
            board[m][n - 1] == word[i + 1] &&
            !consumed[m][n - 1] &&
            Worker(board, consumed, word, m, n - 1, i + 1);
        if (works)
        {
            return true;
        }

        consumed[m][n] = false;
        return false;
    }
}
