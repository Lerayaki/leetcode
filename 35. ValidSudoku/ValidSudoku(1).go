// Runtime: 4 ms, faster than 70.55% of Go online submissions for Valid Sudoku.
// Memory Usage: 2.8 MB, less than 69.82% of Go online submissions for Valid Sudoku.
func isValidSudoku(board [][]byte) bool {
    seen := []byte{}

	//rows
    for i:=0; i<9; i++ {
        for j:=0; j<9; j++ {
            if(Contains(seen, board[i][j])){
                return false
            }
            if(board[i][j] != '.'){
				seen = append(seen, board[i][j])
            }
		}
		seen = []byte{}
	}
	//cols
    for i:=0; i<9; i++ {
        for j:=0; j<9; j++ {
            if(Contains(seen, board[j][i])){
                return false
            }
            if(board[j][i] != '.'){
                seen = append(seen, board[j][i])
            }
		}
		seen = []byte{}
	}
	//grids
    for i:=0; i<3; i++ {
        for j:=0; j<3; j++ {
            for ii:=i*3; ii<i*3+3; ii++ {
                for jj:=j*3; jj<j*3+3; jj++ {
                    if(Contains(seen, board[ii][jj])){
                        return false
                    }
                    if(board[ii][jj] != '.'){
                        seen = append(seen, board[ii][jj])
                    }
				}
			}
			seen = []byte{}
		}
	}

	return true;
}
func Contains(array []byte, e byte) bool{
	for _, arrayElement := range array{
        if (arrayElement == e){
			return true
        }
	}
	return false
}