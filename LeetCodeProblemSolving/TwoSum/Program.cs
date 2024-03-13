public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();


        int[] arr = Array.ConvertAll(s, int.Parse);

        int Target = int.Parse(Console.ReadLine());    

        int[] array = TwoSum(arr, Target);

        for(int i  = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        
    }


    public static int[] TwoSum(int[] arr, int target)
    {
        int k = 0;
        int[] array = new int[2];

       
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr.Length; j++)
            {
                if(i != j)
                {
                    if (arr[i] + arr[j] == target)
                    {

                        array[k] = i;
                        array[k + 1] = j;
                        
                    }
                }
                
            }
            
        }
            
        
        return array;   
    }

}