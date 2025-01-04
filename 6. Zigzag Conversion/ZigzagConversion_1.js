function convert(s: string, numRows: number): string {
    if (numRows == 1 || numRows >= s.length) return s;

    var result = ''
    for(var i: number = 0; i < numRows; i++){
        for(var j: number = i; j < s.length; j++){
            if(j % (numRows*2-2) == i){
                result = result + s[j];

                const index = j + (numRows-1 - i)*2;
                if (i!=0 && i != numRows-1 && index < s.length){
                    result = result + s[index]
                }
            } 
        }
    }
    return result;
};