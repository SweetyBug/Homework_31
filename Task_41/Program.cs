int i = 0;
bool a = true;
string word = "";
while (a == true)
{
    Console.Write("Введите число, если хотетите прекратить введите слово 'end': ");
    word = Console.ReadLine();
    if (word == "end")
    {
        if (i == 0)
        {
            Console.Write("Вы не ввели ни одного числа :(");
        }
        break;
    }
    if (Convert.ToInt32(word) > 0)
    {
        i++;
    }
    Console.WriteLine();
}
if(i == 1)
{
    Console.Write($"Вы ввели только {i} число больше нуля");
}
if(i > 1 && i < 5)
{
    Console.Write($"Вы ввели {i} числа больше нуля");
}
if(i > 4)
{
    Console.Write($"Вы ввели {i} чисел больше нуля");
}