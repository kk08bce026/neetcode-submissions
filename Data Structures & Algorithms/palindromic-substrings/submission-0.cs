public class Solution {
    public int CountSubstrings(string s) 
    {
        int L = 0, n = s.Length, R = n-1, ans =0;
        for(int i=0; i<n; i++)
        {   
            L=i; R=i;
            if(s[L] == s[R]){ ans++; }
            L--; R++;
            
            // for odd.
            while(L>=0 && R<n && s[L] == s[R])
            {
                ans++;
                L--; R++;
            }

            //for even.
            L=i; R=i+1;
            
            while(L>=0 && R<n && s[L] == s[R])
            {
                ans++;
                L--; R++;
            }

        }
        return ans;
        
    }
}
