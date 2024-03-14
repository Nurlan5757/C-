// Taxt 1

/*int num = 27482;
int great=0;
int count=0;

while (num > 0) 
{
    count = num % 10;

    if (great < count) 
    {
    great = count;  

    }
    num = num / 10;
}
Console.WriteLine(great);*/






//Taxt 2


/*int num=10;
int i = 2;

if (num%i==0)
{
    while (num%i==0)
    {
        num=num/i;  
    }
    if (num == 1)
    {
        Console.WriteLine("2 nin quvvet usdudur");
    }
    else
    {
        Console.WriteLine("2 nin quvvet usdu deyil");
    }
}
else
{
    Console.WriteLine("2 nin quvvet usdu deyil");
}*/





//Taxt 3


/*int[] num = { 1, 2, 3, 4, 5, 6, 7 };
int min = num[0];
int max = num[0];
int sum;
for (int i = 0; i < num.Length; i++)
{
    if (min < num[i])
    {
        min = num[i];
    }
    else
    {
        if (max > num[i])
        {
            max = num[i];
        } 
    }
}
sum = min + max;
Console.WriteLine(sum);*/






//Taxt 4


/*int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21, };
int count = 0;

    for(int i=0; i<num.Length; i++)
{
    if (num[i] % 2 !=0 && num[i] % 3 == 0)
    { 
        count++; 
    }
}
Console.WriteLine(count);*/




//Taxt 5

/*int[] num = { 5, 9, 12, 11 };
int count = 0;

for (int i = 0; i < num.Length; i++)
{
    for (int j = 2; j < num[i]; j++)
    {
        if (num[i] % j == 0)

        {
            count++;
        }
    }
}
Console.WriteLine(count);
*/





