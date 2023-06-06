using System;
Console.Write("Enter 1-number : ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter 2-nunmber : ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Yig'indi {number1+number2}");
System.Console.WriteLine($"Ayrirma {number1-number2}");
System.Console.WriteLine($"Ko'paytma {number1*number2}");
System.Console.WriteLine($"Bo'linma {number1/number2}");
System.Console.WriteLine($"Qoldiq {number1%number2}");

System.Console.WriteLine($"1-son 2-dan katta :{number1>number2}");
System.Console.WriteLine($"1-son 2-dan kichik :{number1<number2}");
System.Console.WriteLine($"1-son 2-dan katta yoki teng :{number1>=number2}");
System.Console.WriteLine($"1-son 2-dan kichik yoki teng :{number1<=number2}");
System.Console.WriteLine($"1-son 2-ga teng :{number1==number2}");
System.Console.WriteLine($"1-son 2-ga teng emas :{number1!=number2}");