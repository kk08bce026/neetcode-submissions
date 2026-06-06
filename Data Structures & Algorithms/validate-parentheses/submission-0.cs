public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> stk = new Stack<char>();
        int n = s.Length;
        for(int i=0; i<n; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stk.Push(s[i]);
            }

            if(stk.Count!=0)
            {
                if( (s[i] == ']' && stk.Peek() == '[') || 
                    (s[i] == '}' && stk.Peek() == '{') ||
                    (s[i] == ')' && stk.Peek() == '(') )
                {
                    stk.Pop();
                }
                else if( (s[i] == ']' && stk.Peek() != '[') ||
                         (s[i] == '}' && stk.Peek() != '{') ||
                         (s[i] == ')' && stk.Peek() != '(')  )
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        if(stk.Count!=0)
        {
            return false;
        }
        return true;
        
    }
}
