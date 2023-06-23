public class ValidSudokuSln {
    public bool IsValidSudoku(char[][] board)
    {
        int length = board.Length;

        var rows = new HashSet<int>[length];
        var columns = new HashSet<int>[length];
        var boxes = new HashSet<int>[length];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                var character = board[i][j];
                if (character == '.')
                {
                    continue;
                }

                int box = 3 * (i / 3) + j / 3;
                var rowSet = rows[i] ??= new HashSet<int>();
                var columnSet = columns[j] ??= new HashSet<int>();
                var boxSet = boxes[box] ??= new HashSet<int>();

                if (!rowSet.Add(character) ||
                    !columnSet.Add(character) ||
                    !boxSet.Add(character))
                {
                    return false;
                }
            }
        }

        return true;
    }
}