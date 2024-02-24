
using System;
public class Pattern
{
    public static void Main()
    {
        int n;
        n=Console.ToInt32(Console.ReadLine("Enter the number of rows:""));
        for (int i=0;i<n;i++)
        {
            for(int j=0;j<n-i;j++)
            {
                Console.Write(" ");
                for(int k=0;k<=i;k++)
                {
                    if(i==0 || k==0)
                    {
                        c=1;
                    }
                    else
                    {
                        char=char*(i-k+1)/j;
                        Console.WriteLine(char+" ");
                    }
                    }
                }
            }
        }

        
    }
}
