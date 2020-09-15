
// Runtime: 228 ms, faster than 25.62% of JavaScript online submissions for Roman to Integer.
// Memory Usage: 42.1 MB, less than 60.60% of JavaScript online submissions for Roman to Integer.
/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function(s) {
    var dict = {};
    dict['I'] = 1;
    dict['V'] = 5;
    dict['X'] = 10;
    dict['L'] = 50;
    dict['C'] = 100;
    dict['D'] = 500;
    dict['M'] = 1000;
    
    var decimal = 0;

    for(var i=s.length-1; i>=0; i--){
        decimal += dict[s[i]];
        if (i > 0 && dict[s[i-1]] < dict[s[i]]){
            decimal -= dict[s[i-1]];
            i--;
        }
    }

    return decimal;
};
