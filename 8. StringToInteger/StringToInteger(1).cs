public class Solution {
    public int MyAtoi(string str)
    {
        if (str.Length == 0)
            return 0;
        //Remove whites
        while (str[0] == ' ')
        {
            str = str.Substring(1);
            if (str.Length == 0)
                return 0;
        }

        //is negative?
        bool neg = false;
        if (str[0] == '-')
        {
            neg = true;
            str = str.Substring(1);
        }
        else if (str[0] == '+')
            str = str.Substring(1);

        if (str.Length == 0 || str[0] < '0' || str[0] > '9')
            return 0;

        int index = 0;
        int num = 0;
        while (index < str.Length && str[index] >= '0' && str[index] <= '9')
        {
            if (num >= Int32.MaxValue / 10 && getIntFromDigitChar(str[index]) % 10 > 7)
            {
                if (neg)
                    return Int32.MinValue;
                return Int32.MaxValue;
            }

            num *= 10;
            num += getIntFromDigitChar(str[index]);
            index++;
        }

        if (neg)
            num = -num;

        return num;
    }
    public int getIntFromDigitChar(char c){
        switch(c){
            case '0':
                return 0;
                break;
            case '1':
                return 1;
                break;
            case '2':
                return 2;
                break;
            case '3':
                return 3;
                break;
            case '4':
                return 4;
                break;
            case '5':
                return 5;
                break;
            case '6':
                return 6;
                break;
            case '7':
                return 7;
                break;
            case '8':
                return 8;
                break;
            case '9':
                return 9;
                break;
            default:
                throw new System.Exception("Not a digit");
        }
    }
}