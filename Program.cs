// int q =  int.Parse(Console.ReadLine());
// int r = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine(r);
// Console.WriteLine(q);

    // Console.WriteLine("Введите первое число");
    // int number1 = Convert.ToInt32(Console.ReadLine());

    // Console.WriteLine("Введите второе число");
    // int number2 = Convert.ToInt32(Console.ReadLine());

    // if(number2 * number2 == number1)
    // {
    //     System.Console.Write("Yes");
    // }
    // else
    // {
    //     System.Console.Write("No");
    // }

    // Console.WriteLine("Введите число");
    // int n = Convert.ToInt32(Console.ReadLine());
    // int i = -n;
    // while(i <= n)
    // {
    //     System.Console.Write(i + "  ");
    //     i++;
    // }
    // for(i = -n; i <=n; i++)
    // {
    //     System.Console.Write(i + "  ");
    // }
        
    Console.WriteLine("Введите трёхзначное число");
    int n = Convert.ToInt32(Console.ReadLine());
c
    if (n > 99  && n < 1000) 
    {
        int left = n / 100;
        int right = n % 10;
        System.Console.Write(left + right);
    }
    else
    {
        System.Console.Write("Wrong number"); 
    }