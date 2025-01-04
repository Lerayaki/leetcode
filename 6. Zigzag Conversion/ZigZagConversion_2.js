function convert(s: string, numRows: number): string {
    if (numRows == 1 || numRows >= s.length) return s;

    let result = Array(numRows).fill('');
    const n = numRows - 1;
    for(let i=0; i<s.length; i++){
        result[n - Math.abs(i%(n*2) - n)] += s[i]
    }

    return result.join('');
};