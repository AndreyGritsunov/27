
Console.WriteLine("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 & number > 9)
{
    Console.Write((number / 10) + (number % 10));
}
else if (number > 99 & number < 1000)
{
    Console.Write((number / 100) + ((number % 100) / 10) + ((number - 100) % 10));

}
else if (number > 999 & number < 10000)
{
    Console.Write(((number / 10) / 100) + (((number / 10) % 100) / 10) + (((number / 10) - 100) % 10) + (number % 10));

}
else{
    Console.Write("Введено не правильное число!");
}

