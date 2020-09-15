// Runtime: 216 ms, faster than 29.48% of JavaScript online submissions for Roman to Integer.
// Memory Usage: 41.8 MB, less than 81.37% of JavaScript online submissions for Roman to Integer.
/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function(s) {
    var values = function(c) {
        switch (c) {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default: 
                throw "Not valid";
        }
    }
    var decimal = 0;

    for(var i=s.length-1; i>=0; i--){
        decimal += values(s[i]);
        if (i > 0 && values(s[i-1]) < values(s[i])){
            decimal -= values(s[i-1]);
            i--;
        }
    }

    return decimal;
};
