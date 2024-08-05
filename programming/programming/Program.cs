/*Console.WriteLine("Enter any number");
int nm = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Power");
int power = int.Parse(Console.ReadLine());
power = nm * nm;
Console.WriteLine(power);
Console.ReadKey();*/

/*Console.WriteLine("Enter number 1");
int n1= int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 3");
int n3 = int.Parse(Console.ReadLine());

if(n1>n2 && n1 > n3)
{
    Console.WriteLine("This number is greater= {0}",n1);
}else if(n2>n1 && n2 > n3)
{
    Console.WriteLine("This number is greater= {0}", n2);
}
else if(n3>n1 && n3 > n2)
{
    Console.WriteLine("This number is greater= {0}", n3);
}
Console.ReadKey();*/

/*
Console.WriteLine("Enter any number");
int num = int.Parse(Console.ReadLine());
int[] arrayNum=new int[8] {1,2,3,5,6,7,8,9 };
for (int i = 0; i <8 ; i++)
{
    if (num == arrayNum[i])
    { 
        Console.WriteLine("This number is present in array "+ i);
        break;
    }
    else if(num != arrayNum[i])
    {
        Console.WriteLine("This number is not present in array ");
        break;
    }
}
Console.ReadKey();*/

int max = 0;
int[] arrayMax = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
for(int i = 0; i < arrayMax.Length; i++)
{
    if (arrayMax[i] > max)
    {
        max = arrayMax[i];
    }
}
    Console.WriteLine(max);
    Console.ReadKey();