using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Laba_1c_;

internal class Laba
{
    Random random = new Random();
    



    
    public int sumLastNums(int x) //1.2
    {
        if (x > 9)
        {
            int n1 = x % 10;
            x = x / 10;
            n1 += x % 10;
            

            return n1;
        }
        else
        {
            return 0;
            
        }
    }

    public bool isPositive(int x) //1.4
    {
        if (x > 0)
        {
            return true;
           
        }
        else
        {
            return false;
            
        }
    }

    public bool isUpperCase(char x) //1.6
    {
        String Alph = "QWERTYUIOPASDFGHJKLZXCVBNM";

        if (Alph.Contains(x))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isDivisor(int a, int b) //1.8
    {
        if ( (a % b == 0) || (b % a == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int lastNumSum(int a, int b) //1.10
    {
        int sum = 0;

        sum = (a%10) + (b%10);
        
        for (int i = 1; i <= 4; i++)
        {
            sum = (sum % 10) + (random.Next(10,25) % 10);
            
        }

        return sum;
    }

    public double safeDiv(int x, int y) //2.2
    {
        if (y == 0) 
        {
            return 0;
        }
        else
        {
            return x / y;
        }
    }

    public String makeDecision(int x, int y) //2.4
    {
        if (x > y)
        {
            return " > ";
        }
        else if (x < y)
        {
            return " < ";
        }
        else
        {
            return " == ";
        }
        
    }

    public bool sum3(int x, int y, int z) //2.6
    {
        if ((x + y) == z || (x + z) == y || (y + z) == x)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public String age(int x) //2.8
    {
        if (x % 10 == 1 && x != 11)
        {
            return " год";
        }
        else if ( ((x % 10) == 2 || (x % 10) == 3 || (x % 10) == 4 ) && (x!= 12 || x != 13 || x != 14) )
        {
            return " года";
        }
        else
        {
            return " лет";
        }
    }

    public void printDays(String x) //2.10
    {
        switch (x)
        {
            case "Понедельник":
                Console.WriteLine("Понедельник \nВторник \nСреда \nЧетверг \nПятница \nСуббота \nВоскресенье ");
                break;
            case "Вторник":
                Console.WriteLine("Вторник \nСреда \nЧетверг \nПятница \nСуббота \nВоскресенье ");
                break;
            case "Среда":
                Console.WriteLine("Среда \nЧетверг \nПятница \nСуббота \nВоскресенье ");
                break;
            case "Четверг":
                Console.WriteLine("Четверг \nПятница \nСуббота \nВоскресенье ");
                break;
            case "Пятница":
                Console.WriteLine("Пятница \nСуббота \nВоскресенье ");
                break;
            case "Суббота":
                Console.WriteLine("Суббота \nВоскресенье ");
                break;
            case "Воскресенье":
                Console.WriteLine("Воскресенье ");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;


        }
    }

    public String reverseListNums(int x) //3.2
    {
        String result = "";
        for (int i = x; i >= 0; i--)
        {
            result += i + " ";
           
        }
        return result;
    }

    public int pow(int x, int y) //3.4
    {
        int prois = 1;
        for (int i = 0; i < y; i++)
        {
            prois *= x;
        }
        return prois;
    }

    public bool equalNum(int x) //3.6
    {
        String str = Convert.ToString(x);

        if (x > 9)
        {
            int n1 = x % 10;
            x = x / 10;

            for (int i = 1; i < str.Length; i++)
            {
                int n2 = x % 10;
                x = x / 10;
                if (n1 == n2)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        else
        {
            return true;
        }

        
    }

    public void leftTriangle(int x) //3.8
    {
        for (int i = 0;i < x; i++)
        {
            for (int j = 0;j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void guessGame() //3.10
    {
        int i = 1;
        bool find = false;
        int x = random.Next(0, 9);
        Console.WriteLine("Введите число от 0 до 9: ");

        

        while (find == false) 
        {

            String str = Console.ReadLine();
            int n;

            if (!int.TryParse(str, out n))
            {
                Console.WriteLine("Вы ввели не число");
                
            }
            if (x == n)
            {
                Console.WriteLine("Вы угадали! \nЧисло попыток: " + i);
                find = true;
            }
            else
            {
                i++;
                Console.WriteLine("Вы не угадали, введите число от 0 до 9:");
            }
        }
    }

    public int findLast(int[] arr, int x) //4.2 
    {

        for (int i = arr.Length - 1;  i > 0; i--)
        {
            if (x == arr[i])
            {
                return i;
            }
        }

        return -1;
    }

    public int[] add(int[] arr, int x, int pos) //4.4
    {
        int n = arr.Length;
        int[] matrix2 = new int[n + 1];
        for (int i = 0; i < pos; i++)
        {
            matrix2[i] = arr[i];
        }
        matrix2[pos] = x;
        for (int i = pos+1; i < matrix2.Length; i++)
        {
            matrix2[i] = arr[i - 1];
        }
        return matrix2;
    }

    public void reverse(int[] arr) //4.6
    {
        Console.Write("Результат: arr = [");
        int[] matrix = new int[arr.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            matrix[i] = arr[i];
            Console.Write(matrix[i]);

            if (i > 0)
            {
                Console.Write(",");
            }

        }
        Console.Write("]\n");

        
    }

    public int[] concat(int[] arr1, int[] arr2) //4.8
    {
        int n = arr1.Length + arr2.Length;
        int[] matrix = new int[n];
        for (int i = 0;i < arr1.Length; i++)
        {
            matrix[i] = arr1[i];
        }
        for (int i = arr1.Length; i < n; i++)
        {
            matrix[i] = arr2[i - arr1.Length]; //сдвиг индекса
        }
        return matrix;
    }

    public int[] deleteNegative(int[] arr) //4.10
    {
        int n = 0;
        for (int i = 0;  i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                n++;
            }
        }
        int[] matrix = new int[n];

        int j = 0;
        for (int i = 0; i < arr.Length; i++)   // ← идём по ВСЕМУ arr
        {
            if (arr[i] >= 0)
            {
                matrix[j] = arr[i];            // ← пишем по индексу j
                j++;                            // ← и увеличиваем j
            }
        }

        return matrix;
    }

}
