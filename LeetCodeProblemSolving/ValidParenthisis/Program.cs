public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        Program p = new Program();
        bool Isvalid = p.IsValid(s);
        Console.WriteLine(Isvalid);
    }
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if(c == '{' ||  c == '(' ||  c == '[')
            {
                stack.Push(c);  
            }
            else
            {
                if(stack.Count == 0  )
                {
                    return false;   
                       
                }
                if(stack.Peek() == '[' && c == ']' || stack.Peek() == '{' && c == '}' || stack.Peek() == '(' && c == ')')
                {
                    stack.Pop();   
                }
            }
        }

        return stack.Count == 0;

        



    }
}