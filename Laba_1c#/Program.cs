namespace Laba_1c_;


class Program
{
    void showMenu()
    {
        Console.Clear();
        Console.WriteLine("\nЛабараторная работа №1\n");
        Console.WriteLine("1) Задание 1 - Методы");
        Console.WriteLine("2) Задание 2 - Условия");
        Console.WriteLine("3) Задание 3 - Циклы");
        Console.WriteLine("4) Задание 4 - Массивы");
        Console.WriteLine("0) Выход\n");
        Console.WriteLine("Выберете пункт (0-4)");
    }

    void Task1()
    {
        Console.Clear();
        Console.WriteLine("Методы\n");
        Console.WriteLine("1) 2 - Сумма знаков.");
        Console.WriteLine("2) 4 - Есть ли позитив.");
        Console.WriteLine("3) 6 - Большая буква.");
        Console.WriteLine("4) 8 - Делитель.");
        Console.WriteLine("5) 10 - Многократный вызов.");
        Console.WriteLine("0) Выход\n");
        Console.WriteLine("Выберете пункт (0-5)");
    }

    void Task2()
    {
        Console.Clear();
        Console.WriteLine("Условия\n");
        Console.WriteLine("1) 2 - Безопасное деление.   ");
        Console.WriteLine("2) 4 - Строка сравнения.  ");
        Console.WriteLine("3) 6 - Тройная сумма. ");
        Console.WriteLine("4) 8 - Возраст. ");
        Console.WriteLine("5) 10 - Вывод дней недели.  ");
        Console.WriteLine("0) Выход\n");
        Console.WriteLine("Выберете пункт (0-5)");
    }

    void Task3()
    {
        Console.Clear();
        Console.WriteLine("Циклы\n");
        Console.WriteLine("1) 2 - Числа наоборот.  ");
        Console.WriteLine("2) 4 - Степень числа. ");
        Console.WriteLine("3) 6 - Одинаковость. ");
        Console.WriteLine("4) 8 - Левый треугольник. ");
        Console.WriteLine("5) 10 - Угадайка.  ");
        Console.WriteLine("0) Выход\n");
        Console.WriteLine("Выберете пункт (0-5)");
    }

    void Task4()
    {
        Console.Clear();
        Console.WriteLine("Массивы\n");
        Console.WriteLine("1) 2 - Поиск последнего значения.  ");
        Console.WriteLine("2) 4 - Добавление в массив. ");
        Console.WriteLine("3) 6 - Реверс.  ");
        Console.WriteLine("4) 8 - Объединение.  ");
        Console.WriteLine("5) 10 - Удалить негатив.  ");
        Console.WriteLine("0) Выход\n");
        Console.WriteLine("Выберете пункт (0-5)");
    }





    private static void Main(String[] args)
    {
        Random random = new Random();
        Tasks labs = new Tasks();
        Program prog = new Program();

        bool exit = false;

        while (!exit)
        {

            prog.showMenu();
            String choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        prog.Task1();
                        String choiceIn = Console.ReadLine();

                        switch (choiceIn)
                        {
                            case "1":
                                {
                                    Console.WriteLine("Введите число не меньше 10: ");
                                    String str = Console.ReadLine();
                                    int n = 0;

                                    if (!int.TryParse(str, out n))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        
                                    }
                                    
                                    Console.WriteLine("Результат: " + labs.sumLastNums(n));

                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("Введите положительное или отрицательное число:");
                                    String str = Console.ReadLine();
                                    int n = 0;

                                    if (!int.TryParse(str, out n))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        
                                    }

                                    if (n == 0)
                                    {
                                        Console.WriteLine("Введено число 0");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Результат: " + labs.isPositive(n));
                                    }
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("Введите Заглавные буквы от A-Z:");
                                    char n = char.Parse(Console.ReadLine());
                                    Console.WriteLine("Результат: " + labs.isUpperCase(n));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine("Введите 1-e числo:");

                                    String str1 = Console.ReadLine();
                                    int n1 = 0;
                                    int n2 = 0;

                                    if (!int.TryParse(str1, out n1))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }

                                    Console.WriteLine("Введите 2-e числo:");
                                    String str2 = Console.ReadLine();

                                    if (!int.TryParse(str2, out n2))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }



                                    Console.WriteLine("Результат: " + labs.isDivisor(n1, n2));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "5":
                                {
                                    Console.WriteLine("Введите 1-e числo:");

                                    String str1 = Console.ReadLine();
                                    int n1 = 0;
                                    int n2 = 0;

                                    if (!int.TryParse(str1, out n1))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }

                                    Console.WriteLine("Введите 2-e числo:");
                                    String str2 = Console.ReadLine();

                                    if (!int.TryParse(str2, out n2))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }
                                    Console.WriteLine("Результат: " + labs.lastNumSum(n1, n2));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;

                                }
                            case "0":
                                {
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Ошибка");
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }


                        }
                        break;


                    }

                case "2":
                    {
                        prog.Task2();
                        String choiceIn = Console.ReadLine();

                        switch (choiceIn)
                        {
                            case "1":
                                {
                                    Console.WriteLine("Введите числитель:");

                                    String str1 = Console.ReadLine();
                                    int n1 = 0;
                                    int n2 = 0;

                                    if (!int.TryParse(str1, out n1))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }

                                    Console.WriteLine("Введите знаминатель:");
                                    String str2 = Console.ReadLine();

                                    if (!int.TryParse(str2, out n2))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }
                                    Console.WriteLine("Результат: " + labs.safeDiv(n1, n2));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("Введите 1-e числo:");

                                    String str1 = Console.ReadLine();
                                    int n1 = 0;
                                    int n2 = 0;

                                    if (!int.TryParse(str1, out n1))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }

                                    Console.WriteLine("Введите 2-e числo:");
                                    String str2 = Console.ReadLine();

                                    if (!int.TryParse(str2, out n2))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }
                                    Console.WriteLine("Результат: " + n1 + labs.makeDecision(n1, n2) + n2);
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("Введите 1-e числo:");

                                    String str1 = Console.ReadLine();
                                    int n1 = 0;
                                    int n2 = 0;
                                    int n3 = 0;

                                    if (!int.TryParse(str1, out n1))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }

                                    Console.WriteLine("Введите 2-e числo:");
                                    String str2 = Console.ReadLine();

                                    if (!int.TryParse(str2, out n2))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }

                                    Console.WriteLine("Введите 3-е число: ");
                                    String str3 = Console.ReadLine();

                                    if (!int.TryParse (str3, out n3))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }
                                    Console.WriteLine("Результат :" + labs.sum3(n1, n2, n3));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine("Введите возраст: ");
                                    String str = Console.ReadLine();
                                    int n = 0;

                                    if (!int.TryParse(str, out n))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        
                                    }

                                    Console.WriteLine("Результат: " + n + labs.age(n));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;

                                }
                            case "5":
                                {
                                    Console.WriteLine("Введите день недели: ");
                                    String n = Console.ReadLine();
                                    Console.WriteLine("Результат: ");
                                    labs.printDays(n);
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                    
                                }
                            case "0":
                                {
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Ошибка");
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }

                        }
                        break;

                    }

                case "3":
                    {
                        prog.Task3();
                        String choiceIn = Console.ReadLine();

                        switch (choiceIn)
                        {
                            case "1":
                                {
                                    Console.WriteLine("Введите число: ");
                                    String str = Console.ReadLine();
                                    int n = 0;

                                    if (!int.TryParse(str, out n))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        
                                    }

                                    Console.WriteLine("Результат: " + labs.reverseListNums(n));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("Введите число: ");
                                    String str1 = Console.ReadLine();
                                    int n1 = 0;
                                    int n2 = 0;

                                    if (!int.TryParse(str1, out n1))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }

                                    Console.WriteLine("Введите степень числа:");
                                    String str2 = Console.ReadLine();

                                    if (!int.TryParse(str2, out n2))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;

                                    }

                                    Console.WriteLine("Результат: " + labs.pow(n1, n2));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("Введите число: ");
                                    String str = Console.ReadLine();
                                    int n = 0;

                                    if (!int.TryParse(str, out n))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        
                                    }

                                    Console.WriteLine("Результат: " + labs.equalNum(n));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine("Введите количество *: ");
                                    String str = Console.ReadLine();
                                    int n = 0;

                                    if (!int.TryParse(str, out n))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        
                                    }

                                    labs.leftTriangle(n);
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "5":
                                {

                                    labs.guessGame();
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "0":
                                {
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Ошибка");
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                        }
                        break;
                    }
                case "4":
                    {
                        prog.Task4();
                        String choiceIn = Console.ReadLine();

                        switch (choiceIn)
                        {
                            case "1":
                                {
                                    Console.Write("\n[");
                                    int[] matrix = new int[8];
                                    for (int i = 0; i < matrix.GetLength(0); i++)
                                    {
                                        matrix[i] = random.Next(0, 10);
                                        Console.Write(matrix[i]);

                                        if (i < matrix.GetLength(0) - 1)  
                                        {
                                            Console.Write(",");
                                        }
                                    }
                                    Console.Write("]\n");

                                    Console.WriteLine("Введите число: ");
                                    String str = Console.ReadLine();
                                    int n = 0;

                                    if (!int.TryParse(str, out n))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        
                                    }

                                    Console.WriteLine("Резултат : " + labs.findLast(matrix, n));
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Console.Write("\n[");
                                    int[] matrix = new int[6];
                                    for (int i = 0; i < matrix.Length; i++)
                                    {
                                        matrix[i] = random.Next(0, 10);
                                        Console.Write(matrix[i]);

                                        if (i < matrix.Length - 1)
                                        {
                                            Console.Write(",");
                                        }
                                    }

                                    Console.Write("]\n");


                                    Console.WriteLine("Введите число: ");
                                    String str1 = Console.ReadLine();
                                    int n1 = 0;
                                    int n2 = 0;

                                    if (!int.TryParse(str1, out n1))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;
                                    }

                                    Console.WriteLine("Введите позицию числа:");
                                    String str2 = Console.ReadLine();

                                    if (!int.TryParse(str2, out n2))
                                    {
                                        Console.WriteLine("Вы ввели не число");
                                        Console.ReadKey();
                                        break;
                                    }

                                    Console.Write("\nРезультат: [");
                                    
                                    for (int i = 0; i < labs.add(matrix, n1, n2).Length; i++)
                                    {
                                        Console.Write(labs.add(matrix,n1,n2)[i]);

                                        if (i < labs.add(matrix, n1, n2).Length - 1)
                                        {
                                            Console.Write(",");
                                        }
                                    }
                                    Console.Write("]\n");


                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "3":
                                {
                                    Console.Write("\n[");
                                    int[] matrix = new int[6];
                                    for (int i = 0; i < matrix.Length; i++)
                                    {
                                        matrix[i] = random.Next(0, 10);
                                        Console.Write(matrix[i]);

                                        if (i < matrix.Length - 1)
                                        {
                                            Console.Write(",");
                                        }
                                    }

                                    Console.Write("]\n");
                                    labs.reverse(matrix);


                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "4":
                                {

                                    Console.Write("arr1 =[");
                                    int[] matrix = new int[3];
                                    for (int i = 0; i < matrix.Length; i++)
                                    {
                                        matrix[i] = random.Next(0, 10);
                                        Console.Write(matrix[i]);

                                        if (i < matrix.Length - 1)
                                        {
                                            Console.Write(",");
                                        }
                                    }

                                    Console.Write("]\n");

                                    Console.Write("arr2 =[");
                                    int[] matrix1 = new int[3];
                                    for (int i = 0; i < matrix1.Length; i++)
                                    {
                                        matrix1[i] = random.Next(0, 10);
                                        Console.Write(matrix1[i]);

                                        if (i < matrix1.Length - 1)
                                        {
                                            Console.Write(",");
                                        }
                                    }

                                    Console.Write("]\n");

                                    Console.Write("Результат: [");
                                    for (int i = 0; i < labs.concat(matrix, matrix1).Length; i++)
                                    {
                                        Console.Write(labs.concat(matrix, matrix1)[i]);

                                        if (i < labs.concat(matrix, matrix1).Length - 1)
                                        {
                                            Console.Write(",");
                                        }
                                    }

                                    Console.Write("]\n");

                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "5":
                                {
                                    Console.Write("arr =[");
                                    int[] matrix = new int[6];
                                    for (int i = 0; i < matrix.Length; i++)
                                    {
                                        matrix[i] = random.Next(-10, 10);
                                        Console.Write(matrix[i]);

                                        if (i < matrix.Length - 1)
                                        {
                                            Console.Write(",");
                                        }
                                    }

                                    Console.Write("]\n");

                                    Console.Write("Результат: [");
                                    for (int i = 0; i < labs.deleteNegative(matrix).Length; i++)
                                    {
                                        Console.Write(labs.deleteNegative(matrix)[i]);

                                        if (i < labs.deleteNegative(matrix).Length - 1)
                                        {
                                            Console.Write(",");
                                        }
                                    }

                                    Console.Write("]\n");

                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                            case "0":
                                {
                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Ошибка");
                                    Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                                    Console.ReadKey();
                                    break;
                                }
                        }
                        break;


                    }
                case "0":
                    {
                        exit = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка");
                        Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                        Console.ReadKey();
                        break;

                    }
            }



        }
    }
}
