public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        return logs
        .Where(l => !IsDigit(l))// logs 에서 Digit이 아닌 데이터만
        .OrderBy(l => l.Split(" ", 2)[1]) //나는 것에 대해서 정렬
        .ThenBy(l => l.Split(" ", 2)[0])// 한번 더 정렬
        .Union(logs
        .Where(l => IsDigit(l)))
        .ToArray();
    }
    
    private bool IsDigit(string log)
    {
        return char.IsDigit(log[log.IndexOf(' ') + 1]);
    }
}

