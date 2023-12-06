// из 3х значного числа сделать 2х значное, состоящее из первой и третьей цифры 3х значного

int num = 456;
int first = 456 / 100;
int second = 456 % 10;

Console.WriteLine($"{first}{second}");
