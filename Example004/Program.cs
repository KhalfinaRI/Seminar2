// выводит третью с начала цифру заданного числа,
// или сообщает что 3ей цифры нет

int num = 45567;
if(num<100){
    Console.WriteLine("Третьей цифры нет");
}
else{
    while(num>999){
        num /= 10;
    }
    Console.WriteLine($"Result is {num%10}");
}


