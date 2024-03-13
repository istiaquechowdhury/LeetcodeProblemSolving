using System.Text;

public class Program
{
    public static void Main()
    {

        string x = (Console.ReadLine());

        Program p = new Program();
       if( p.IsPalindrome(int.Parse(x.ToString())))
       {
            Console.WriteLine("YES");
       }
       else
       {
            Console.WriteLine("NO");
       }



    }


    public bool IsPalindrome(int x)
    {
       string s = x.ToString();

       char[] chars = s.ToCharArray();

       Array.Reverse(chars);    

       string l = new string(chars);   
        
        if(s.Equals(l))
        {
            return true;    
        }
        
        return false;   
            

    }
}