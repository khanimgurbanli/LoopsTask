// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");//------------------KITABBB

#region Task 1
//positive = 0 and negative = 0
//positive = 1 and negative = -1
//positive = 2 and negative = -2
//positive = 3 and negative = -
//for (int i = 0; i < 100; i++)
//    Console.WriteLine($"positive = {i} and negative = -{i} ");
#endregion

#region Task 2
//Kullanıcıdan aldığınız metinsel değeri tersten ekrana yazdırınız örnek murat -> tarum
//Console.WriteLine("Please, enter your text");
//string myText = Console.ReadLine();
//string reverseText = "";

//for (int i = myText.Length - 1; i >= 0; i--)
//    reverseText += myText[i];

//Console.Write($"{myText} -> {reverseText}");
#endregion

#region Task 3
//10 ile 20 arasındaki sayıları
//# 10 eşittir 2 * 5
//# 11 asal sayıdır
//# 12 eşittir 2 * 6
//# 13 asal sayıdır
//# 14 eşittir 2 * 7
//# 15 eşittir 3 * 5
//# 16 eşittir 2 * 8
//# 17 asal sayıdır
//# 18 eşittir 2 * 9
//# 19 asal sayıdır
//# 20 eşittir 2 * 10


//bool IsPrime = true;

//for (int i = 10; i < 20; i++)
//{
//    IsPrime = true;
//    for (int j = 2; j < 9; j++)
//    {
//        if (i % j == 0)
//        {
//            Console.WriteLine($"{i}={i/j} * {j} ");
//            IsPrime = false;
//            break;
//        }
//    }
//    if (IsPrime)
//    {
//        Console.WriteLine($"{i} is prime ");
//    }
//}



#endregion

//#region Task 4
//int lenth = 0;
//int input = 0;
//int i = 0;
//Console.WriteLine("Please,enter number");
//while (true)
//{
//    string num=Console.ReadLine();
//    int[] numbers = { int.Parse(num) };
//cont:

//    Console.WriteLine("Would you continue to entered number? Continue -> 'Y' & Exist -> 'N'");
//    var check = Console.ReadLine();

//    if (check.ToUpper() == "Y" && check.ToUpper() != "N")
//    {
//        Array.Resize(ref numbers, i++);
//        input = int.Parse(Console.ReadLine());
//        numbers[i] = input;

//        goto cont;
//    }
//    else
//    {
//        int temp = 0;
//        int curr = 0;
//        //sort
//        for (int f = 0; f< numbers.Length; f++)
//        {
//            for (int j = i+i; j < numbers.Length; j++)
//            {
//                if (numbers[i] > numbers[j])
//                {
//                    temp = numbers[i];
//                    numbers[i] = numbers[j];
//                    numbers[j] = temp;
//                }
//            }
//        }
//        //tek cut
//        foreach (var item in numbers)
//        {
//            if (item/2!=0)
//            {
//                Console.WriteLine(numbers[0] - numbers[numbers.Length - 1]);
//            }
//        }
//        break;
//    }
//}

//#endregion

#region Task 1

#endregion