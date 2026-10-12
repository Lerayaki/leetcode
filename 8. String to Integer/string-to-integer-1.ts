const MAX_INT32 = 2 ** 31 - 1; // 2147483647
const MIN_INT32 = -(2 ** 31);  // -2147483648

function myAtoi(s: string): number {
    let sign: number = 1;
    let result = 0;
    let i = 0


    while (s[i] == ' ')
        i++

    if (s[i] == '-' || s[i] == '+'){
        sign = s[i] == '-' ? -1 : 1
        i++
    }

    while (s[i] >= '0' && s[i] <= '9' && i < s.length){
        result = result * 10 + Number(s[i])
        i++
    }

    return Math.max(Math.min(result * sign, MAX_INT32), MIN_INT32)
};
