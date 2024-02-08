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
        
   

//  System.Console.Write("Введите трёхзначное число");
//  int number = Convert.ToInt32(Console.ReadLine());

//  if( number > 99 && number < 1000)
//  {
//   int leftDig = number / 100;
//   int rightDig = number % 10;
//   //System.Console.WriteLine(leftDig + "" + rightDig);
//   //System.Console.WriteLine($"{leftDig}+{rightDig}");
//   int newNumber = leftDig * 10 + rightDig;
//   System.Console.WriteLine(newNumber);
//  }
//  else
//  {
//         System.Console.WriteLine("Wrong number");
//  }

// System.Console.Write("Введите трёхзначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// if( number > 99 && number < 1000)
//  {
//     int a = (number / 10) % 10;
//     int b = number / 100;
    

//     int res = 0;
//     int i = 0;

//     while(i < b)
//     {
//      res = a * a;
//      i++;
//     }
//  System.Console.WriteLine(res);

//  }
//  else
// {
//         System.Console.WriteLine("Wrong number");
//  }


 
 //System.Console.WriteLine(Math.Pow(6, 10));
 
 
//  System.Console.Write("Введите первое число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите второе число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber % secondNumber ==0 ){
//     System.Console.WriteLine("Да");
// }
// else{
//     System.Console.WriteLine("Нет" + firstNumber % secondNumber);
// }

// System.Console.Write("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// // int res = number % 1000 / 100;
// //  System.Console.WriteLine(res);
//  while(number > 999)
//     {
//     number /= 10;
//     }

// System.Console.WriteLine(number % 10);

// int n = 3456;
// n = n / 100;
//  System.Console.WriteLine(n);

 System.Console.Write("Введите число");
 int number = Convert.ToInt32(Console.ReadLine());
 int numberOld = number;//наше первоначальное число, цифры которого мы хотим записать
 
//  int figure = 0;
//  System.Console.WriteLine("Справа налево" + "  ");
//  while(number > 0)
//  {
//   figure = number % 10;
//   System.Console.Write(figure + ",");
//   number = number / 10; 
//  }



System.Console.Write("Слева направо" + "  ");    
int degree = 0;
while(number > 10)
{
    number = number/ 10;
    degree++; //это порядок нашего числа
}
   
   for(; degree >= 0; degree--)
{
  int degreeVariable= Convert.ToInt32(Math.Pow(10, degree));//здесь пришлось попотеть, потому что возведение в степеь подразумевает double, а не int, а double, в свою очередь не дает целочисленного деления
  int res = numberOld / degreeVariable;
  numberOld = numberOld - res * degreeVariable;
  System.Console.Write(res + "," );
}



