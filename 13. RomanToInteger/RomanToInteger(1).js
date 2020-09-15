// Runtime: 264 ms, faster than 14.92% of JavaScript online submissions for Roman to Integer.
// Memory Usage: 42.1 MB, less than 63.92% of JavaScript online submissions for Roman to Integer.
/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function(s) {
    var decimal = 0;
    for (var i=s.length-1; i>=0; i--){
        if (s[i] == 'I'){
            decimal++;
            continue;
        }

        if (s[i] == 'V'){
            decimal += 5;
            if (i > 0 && s[i-1] == 'I'){
                decimal--;
                i--;
            }
            continue;
        }
        if (s[i] == 'X'){
            decimal += 10;
            if (i > 0 && s[i-1] == 'I'){
                decimal--;
                i--;
            }
            continue;
        }

        if (s[i] == 'L'){
            decimal += 50;
            if (i > 0 && s[i-1] == 'X'){
                decimal -= 10;
                i--;
            }
            continue;
        }
        if (s[i] == 'C'){
            decimal += 100;
            if (i > 0 && s[i-1] == 'X'){
                decimal -= 10;
                i--;
            }
            continue;
        }

        if (s[i] == 'D'){
            decimal += 500;
            if (i > 0 && s[i-1] == 'C'){
                decimal -= 100;
                i--;
            }
            continue;
        }
        if (s[i] == 'M'){
            decimal += 1000;
            if (i > 0 && s[i-1] == 'C'){
                decimal -= 100;
                i--;
            }
            continue;
        }
    }
    return decimal;
};
