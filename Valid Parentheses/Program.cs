// See https://aka.ms/new-console-template for more information
string s = "{[]}";
bool IsValid(string s)
{
    Dictionary<char, char> bracketsMap = new Dictionary<char, char>{
            {'{',  '}'},
            {'(',  ')'},
            {'[',  ']'},
        };
    Stack<char> openBrackets = new Stack<char>();

    foreach (char bracket in s)
    {
        if (bracketsMap.ContainsKey(bracket))
        {
            openBrackets.Push(bracket);
        }
        else
        {
            if (openBrackets.Count == 0)
            {
                return false;
            }
            if (bracketsMap[openBrackets.Pop()] == bracket)
            {
                continue;
            };
            return false;
        }
    }
    return openBrackets.Count == 0;
}
Console.WriteLine(IsValid(s));