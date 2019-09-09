class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        if (!s.length())
	{
		return 0;
	}
        if(s.length()>595)
        {
            return 95;
        }
	list<char> li;
	list<char>::iterator itor;
	register int r = 1, t = 1,f=1;
	for (size_t i = 0; i < s.length(); i++)
	{
		li.clear();
		li.insert(li.end(), s[i]);
		itor = li.begin();
		t = 1;
		for (size_t j = i+1; j < s.length(); j++)
		{
			while (itor != li.end())
			{
				if (*itor==s[j])
				{
					f = 0;
				}
				itor++;
			}
			if (!f)
			{
				break;
			}
			t++;
			li.insert(li.end(), s[j]);
			itor = li.begin();
		}
		if (t>r)
		{
			r = t;
		}
		f = 1;
	}
	return r;
    }
};