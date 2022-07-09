public class Solution {
    public int MyAtoi(string s) {
            string str = s.Trim();
    string numStr = string.Empty;
    int result = 0;
    for(int i=0;i<str.Length;i++)
    {
        if(Char.IsNumber(str[i]))
        {
            int x = str[i] - '0';
            numStr += x.ToString();
        }
        else if((str[i]=='-' || str[i]=='+') && (numStr==string.Empty))
        {
            numStr += str[i].ToString(); 
        }
        else
        {
            break;
        }
    }
    if(numStr==string.Empty)
    {
        return result;
    }
    BigInteger output;
    bool isNumeric = BigInteger.TryParse(numStr, out output);
    if(isNumeric)
    {  
    if(BigInteger.Parse(numStr)<int.MinValue)
    {
        return int.MinValue;
    }
    else if(BigInteger.Parse(numStr)>int.MaxValue)
    {
        return int.MaxValue;
    }
    result = int.Parse(numStr);
    return result;
    }
    else
    {
        return result;
    }
}
    }
