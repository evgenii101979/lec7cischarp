// задача 1 собрать строку с числами от a до b, a<=b

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b)
//         return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }
// System.Console.WriteLine(NumbersFor(1, 10));   // 1 2 3 4 5 6 7 8 9 10
// System.Console.WriteLine(NumbersRec(1, 10));   // 1 2 3 4 5 6 7 8 9 10

// Задача 2 сумма чисел от 1 до N

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 0; i <= n; i++)
//         result += i;
//     return result;
// }
// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// System.Console.WriteLine(SumFor(10));   // 55
// System.Console.WriteLine(SumRec(10));   // 55

// Задача 3 факториал числа

// int FaqctorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }
// int FaqctorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * FaqctorialRec(n - 1);
// }
// System.Console.WriteLine(FaqctorialFor(10)); // 3628800
// System.Console.WriteLine(FaqctorialRec(10)); // 3628800

// Задача 4 вычислить а в степени n

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }
// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     //if (n == 0) return 1;
//     //else return PowerRec(a, n - 1) * a;
// }
// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }
// System.Console.WriteLine(PowerFor(2, 10)); // 3628800
// System.Console.WriteLine(PowerRec(2, 10)); // 3628800
// System.Console.WriteLine(PowerRecMath(2, 10)); // 3628800

// задача 5 перебор слов. В некотором машинном алфавите имеются 4 буквы а и с в. 
//Покажите все слова состоящие из Т букв, которые можно построить из букв этого алфавита.

// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             for (int l = 0; l < count; l++)
//             {
//                 System.Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
//             }
//         }
//     }
// }
// int n =1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         System.Console.WriteLine($"{n++} {new String(word)}");
//         return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }
// FindWords("аисв", new char[3]);


