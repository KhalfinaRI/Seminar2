// на ввод 3х значное число, 
//возводим 2ую цифру числа в степень == 3ей цифре числа 

int number= 552;
int first = (number / 10) % 10;
int second = number % 10;
int degree = 1;
int result = first;

while(degree < second)
{
    result = result * first;
    degree++;
}
Console.WriteLine(first);
Console.WriteLine(result);
