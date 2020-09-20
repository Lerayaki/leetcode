// Runtime: 112 ms, faster than 74.11% of C# online submissions for Valid Sudoku.
// Memory Usage: 27.2 MB, less than 93.70% of C# online submissions for Valid Sudoku.
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> seen = new HashSet<char>();

        //rows
        for (int i=0; i<9; i++){
            for (int j=0; j<9; j++){
                if(seen.Contains(board[i][j]))
                    return false;
                if(board[i][j] != '.')
                    seen.Add(board[i][j]);
            }
            seen.Clear();
        }
        //cols
        for (int i=0; i<9; i++){
            for (int j=0; j<9; j++){
                if(seen.Contains(board[j][i]))
                    return false;
                if(board[j][i] != '.')
                    seen.Add(board[j][i]);
            }
            seen.Clear();
        }
        //grids
        for (int i=0; i<3; i++){
            for (int j=0; j<3; j++){
                for (int ii=i*3; ii<i*3+3; ii++){
                    for (int jj=j*3; jj<j*3+3; jj++){
                        if(seen.Contains(board[ii][jj]))
                            return false;
                        if(board[ii][jj] != '.')
                            seen.Add(board[ii][jj]);
                    }
                }
                seen.Clear();
            }
        }

        return true;
    }
}