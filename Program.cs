using System;

namespace Learnings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.16
            Console.WriteLine(CountMaximums(new int[] { 1, 2, 2,1,2,0,0, 1 }));
            
            //7.17
            int[,] matrix = new[,] { 
                { 1, -2, 3 },
                { 4, -5, 6 },
                { 7, -8, 9 }
            };
            matrix = ChangeNegative(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            //7.18
            Console.WriteLine(CountMinSum(matrix));

            //7.21
            Console.WriteLine(ReverseLine("Привет"));

            //7.22
            Console.WriteLine(AddSigns("тест"));

            //7.23
            Console.WriteLine(FormString('@', 10));

            //7.24
            Console.WriteLine(SumFirstN(3, new int[] { 1, 1, 1, 2 }));
            Console.ReadLine();
        }

        //7.16
        static int CountMaximums(int[] arr)
        {
            int maxValue = arr[0]; 
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue) 
                {
                    maxValue = arr[i];
                }
            }
            int maxCount = 0; 
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == maxValue) 
                {
                    maxCount++;
                }
            }
            return maxCount;
        }
        
        //7.17
        static int[,] ChangeNegative(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++) 
            {
                for(int j = 0; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] < 0) 
                    {
                        matrix[i, j] = 1; 
                    }
                }
            }

            return matrix;
        }
       
        //7.18
        static int CountMinSum(int[,] matrix)
        {
            int[] mins = new int[matrix.GetLength(0)];
            for(int i = 0;i < matrix.GetLength(0); i++)
            {
                
                int min = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] < min) 
                    {
                        min = matrix[i, j]; 
                    }
                }
                mins[i] = min;
            }
            int sum = 0;
            for(int i = 0; i < mins.Length; i++) 
            {
                sum += mins[i]; 
            }

            return sum;
        }
        
        //7.21
        static string ReverseLine(string str)
        {
            string newString = "";
           
            for(int i = str.Length - 1; i != -1; i--)
            {
                newString += str[i];
            }

            return newString;
        }

        //7.22
        static string AddSigns(string str)
        {
            for(int i = 0; i < 4; i++) 
            {
                str = "+" + str;
               
            }
            for (int i = 0; i < 5; i++)
            {
                str = "-" + str;
            }
            return str;
        }
    
        //7.23
        static string FormString(char symbol,int k)
        {
            string res = "";
            for(int i = 0; i < k; i++)
            {
                res += symbol; 
            }
            return res;
        }

        //7.24
        static int SumFirstN(int n, int[] arr)
        {
            int sum = 0; 
            for(int i = 0; i < n; i++)
            {
                sum += arr[i]; 
            }
            return sum;
        }
    }


}
