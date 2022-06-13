
/*
int FindSecondNum(int num)
{
    int n1, n2, gap2, n3;

    if(num >= 100 && num <= 999)
{
    n1=num/100;
    gap2=num/10;
    n2=gap2%10;
    n3=num%10;

    return n2;
}

else 
{
    return -1;
}

}

Console.WriteLine("Введите трехзначное число");
int a=Convert.ToInt32(Console.ReadLine());

int result=FindSecondNum(a);

Console.WriteLine("Второй цифрой является " + result);

*/






/*
int FindThirdNum(int num)
{
    int n1, n2, gap2, n3;

    if(num >= 100 && num <= 999)
{
    n1=num/100;
    gap2=num/10;
    n2=gap2%10;
    n3=num%10;

    return n3;
}

else 
{
    return -1;
}

}

Console.WriteLine("Введите трехзначное число");
int a=Convert.ToInt32(Console.ReadLine());

int result=FindThirdNum(a);

if(result == -1)
{
    Console.WriteLine("Число не трехзначное,поэтому третьей цифры нет");
}
else 
{
    Console.WriteLine("Третьей цифрой является " + result);
}
*/







/*
int FindThirdNum(int num)
{

    if(num <=5)
{
    return 0;
}

else 
{
    return 1;
}

}

Console.WriteLine("Введите цифру,обозначающую день недели");
int a=Convert.ToInt32(Console.ReadLine());

int result=FindThirdNum(a);

if(result == 0)
{
    Console.WriteLine("Будний день,не выходной");
}
else 
{
    Console.WriteLine("Выходной день");
}
*/