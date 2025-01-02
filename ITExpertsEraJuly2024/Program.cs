// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ITExpertsEraJuly2024;
using System.Runtime.ExceptionServices;

Console.WriteLine("Welcome to ITExpertsERa");

//Console.Write("This is a good classs.");
//Console.Write("This is a July 2024 batch");

// first code.. 

//int firstNumber = 10;

//int secondNumber = 20;

//int sum = firstNumber + secondNumber;

//Console.WriteLine(sum);

//int subtract = firstNumber - secondNumber;

//Console.WriteLine(subtract);

//int multiply = firstNumber * secondNumber;

//Console.WriteLine(multiply);

//int divide = firstNumber / secondNumber;

//Console.WriteLine(divide);

// second program | get value from the user. 


//Console.WriteLine("Please enter your first number");

//int first = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter your second number");

//int second = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter your operation");

//string operation = Console.ReadLine(); // Sum, Subtract, Multiply, Divide, sdfsfsfs

//int result = 0; 

//if (operation == "Sum")
//{
//    result = first + second;
//}
//else if (operation == "Subtract")
//{
//    result = first - second;
//}
//else if (operation == "Multiply")
//{
//    result = first * second;
//}
//else if (operation == "Divide")
//{
//    result  = first / second;
//}
//else
//{
//    Console.WriteLine("You have entered wrong operation");
//}




//Console.WriteLine("Result of the two number is " + result);


// check if number is odd or even 


//Console.WriteLine("Please enter your number");

//int number = Convert.ToInt32( Console.ReadLine());


//if (number % 2  == 0)
//{
//    Console.WriteLine(" Number is even");
//}
//else
//{
//    Console.WriteLine("Number is odd");
//}

///////////////////////////////////////////////////////// 25 July 2024 //////////////////////////////////////////


// number should be even and greater than 100

//Console.WriteLine("Please enter your number");

//int number  = Convert.ToInt32(Console.ReadLine());

//if (number % 2 == 0 && number > 100 ) // && to check multiple condition.
//{
//    Console.WriteLine(" Your number is greater than 100 and even number");
//}
//else
//{
//    Console.WriteLine(" Your number is either smaller than 100 or odd number");

//}

// number should be either greater than 100 or even number

//using ITExpertsEraJuly2024;
//using System.Security.Cryptography.X509Certificates;
///
//Console.WriteLine("Please enter your number");

//int number = Convert.ToInt32(Console.ReadLine());

//if (number % 2 == 0 || number > 100) // || to check any one condition condition., !=
//{
//    Console.WriteLine(" Your number is either even number or greater than 100");
//}
//else
//{
//    Console.WriteLine(" Your number is either not even number or not greater than 100");

//}

////////////////////////////////// 30th July 2024 | Data Types //////////////////////////////////////////
///

//int varInt = 1212121;

//string varString = "This2232323232";

//bool varBool = true;

//char varChar = 's';

//DateTime varDateTie = DateTime.Now;

//// Other data types

//byte varByte = 255;
//sbyte varSByte = -128;

//int varInt2 = 25;
//uint varInt3 = 25u;

//object varObj = DateTime.Now;

//Console.WriteLine(varInt);
//Console.WriteLine(varString);
//Console.WriteLine(varBool);
//Console.WriteLine(varChar);
//Console.WriteLine(varDateTie);


//int varInt4 = default(int);

//Console.WriteLine("Default value " + varInt4);

//////////////////////////////////////////////////// Array ////////////////////////////////////////////
/////

//// Array Declaration
//int[] arrayInt = new int[5];

//// Array Initialization, Insert value into array. 

//arrayInt[0] = 10;
//arrayInt[1] = 20;
//arrayInt[2] = 232230; 
//arrayInt[3] = 23;
//arrayInt[4] = 500;


//arrayInt[2] = 40;

//Console.WriteLine(arrayInt[0]);
//Console.WriteLine(arrayInt[1]);
//Console.WriteLine(arrayInt[2]);
//Console.WriteLine(arrayInt[3]);
//Console.WriteLine(arrayInt[4]);


//Console.WriteLine("----------------------------------------------------------------------");

//// for loop.. 

//for (int i = 0; i < arrayInt.Length; i++)
//{
//    Console.WriteLine(arrayInt[i]);
//}

//Console.WriteLine("----------------------------------------------------------------------");

//for (int i = 2; i <= 20; i=i+2)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("----------------------------------------------------------------------");

//int sum = 0;

//for (int i = 1; i <=10; i++)
//{
//    sum += i; //1, 3, 6, 10, 15
//    Console.WriteLine(i);
//}

//Console.WriteLine(sum);

// 

//int count = 0; 

//for (int i = 2; i <= 20; i = i + 2)
//{
//    count++;
//    Console.WriteLine("2 * " + count + " = " + i);
//}

//for (int i = 1; i < 10; i++)
//{
//    Console.WriteLine("outer loop " + i);
//    for (int j = 0; j < i; j++)
//    {
//        Console.WriteLine("inner loop " + j);
//    }
//}

///////////////////////////////////////////////////////// 06th August ///////////////////////////////////////////////////////////////

//string[] fruits = new string[5] {"Mango", "Apple", "Grapes", "Pineapple", "Guava" };

//// foreach 

//foreach (string fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}

// while loop 

//int i = 1; 
//while (i< 11)
//{
//    Console.WriteLine(i);
//    i++;
//}

// do while loop 

//int i = 1;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i < 11);


//Console.WriteLine("Please enter your number");

//int number = Convert.ToInt32(Console.ReadLine());

//if (number == 1)
//{
//    Console.WriteLine("Monday");
//}
//else if (number == 2)
//{
//    Console.WriteLine("Tuesday");
//}

// Switch Case

//switch (number)
//{
//    case 1:
//        {
//            Console.WriteLine("Today is Monday");
//            break;
//        }
//    case 2:
//        {
//            Console.WriteLine("Today is Tuesday");
//            break;
//        }
//    case 3:
//        {
//            Console.WriteLine("Today is Wednesday");
//            break;
//        }
//    case 4:
//        {
//            Console.WriteLine("Today is Thursday");
//            break;
//        }
//    case 5:
//        {
//            Console.WriteLine("Today is Friday");
//            break;
//        }
//    case 7:
//        {
//            Console.WriteLine("Today is Saturday");
//            break;
//        }
//    case 8:
//        {
//            Console.WriteLine("Today is Sunday");
//            break;
//        }

//    default:
//        {
//            Console.WriteLine("You have entered wrong value");
//            break;

//        }
//}

/////////////////////////////////////// 13th August ////////////////////////////////////////////////////////
///

//// creating a car class object.
//Car objHonda = new Car();

//// set property using object.
//objHonda.BrandName = "Honda";
//objHonda.CarName = "Honda City";
//objHonda.NoOfSeats = 4;


///////////call method using object
/////

//objHonda.PrintBrandName();
//Console.WriteLine("Car Name " + objHonda.CarName);
//Console.WriteLine("Car No of Seats " + objHonda.NoOfSeats);

//int resultspeed = objHonda.Accelerator(10);

//Console.WriteLine("Current Speed : " + resultspeed);

//int resultspeed2 = objHonda.Brake(50);

//Console.WriteLine("Current Speed : " + resultspeed2);

//int resultspeed3 = objHonda.Clutch(15);

//Console.WriteLine("Current Speed : " + resultspeed3);


// homework 

// hyundai , tata, ford

// perfect number

//Console.WriteLine("Please enter your range ?");

//int range = Convert.ToInt32(Console.ReadLine());



//for (int i = 2; i <= range; i++) // loop through each digit
//{
//    int sum = 0; 

//    for (int j = 2; j <= i/2; j++)
//    {
//        if (i % j == 0)
//        {
//            sum += j;
//        }
//    }

//    if (i == sum + 1)
//    {
//        Console.WriteLine(i + " is a perfect number ");
//    }
//}


//////////////////////////////////////////////////////// 15 August 2024 //////////////////////////////////////////////////////
///

MathsOperation objMO = new MathsOperation();

//objMO.Sum(10, 100);

//int result = objMO.Subtract(100, 50);

//Console.WriteLine("Subtraction of two number is " + result);

//int result2 = objMO.SumArray(new int[] { 10, 20, 30, 40, 50 });

//Console.WriteLine("Sum of the array is " + result2);

///// praram keyword
///// 

//objMO.SumParamArray("test", 30,34,5,6,34,56,56,45,45, 24);


//objMO.Sum(10, 20, 30);

//////////////////////////////////////////////////////////// 22nd August 2024 ///////////////////////////////////////////
///

//PropertyExample objPE = new PropertyExample();

//objPE.Color = "Red";


//Console.WriteLine(objPE.Color);
//Console.WriteLine(objPE.Name);

//ConstructorExample CE0 = new ConstructorExample();
////ConstructorExample CE = new ConstructorExample(true);
////ConstructorExample CE2 = new ConstructorExample(false);

//CE0.name = "Rakesh";
//CE0.noOfStudents = 3500;


//ConstructorExample CE4 = new ConstructorExample(CE0);

//Console.WriteLine(CE4.name);
//Console.WriteLine(CE4.noOfStudents);

//StaticExample.varStatic = 200;
//StaticExample.varStatic = 400;
//StaticExample.varStatic = 600;

//StaticExample objSE; 

//objSE = new StaticExample(); // object no. 1

//StaticExample.varStatic = 200;

//Console.WriteLine(objSE.i); // 10

//objSE.i = 200;

//Console.WriteLine(objSE.i); // 200

//StaticExample objSE2 = new StaticExample(); // object no. 2 

//Console.WriteLine(objSE2.i);

//StaticExample objSE3 = new StaticExample();

//objSE3 = objSE;

//Console.WriteLine(objSE3.i); // 200

////objSE = null; 


//Console.WriteLine(objSE3.i); // 200

////Console.WriteLine(objSE.i); // error..


//StaticExample.varStatic = 200; 

//Console.WriteLine("static variable " + StaticExample.varStatic);

//// non static method.

//objSE.NonStaticMethod();

//StaticExample.StaticMethod();

//ConstructorExample.gender = "Female";

//ConstructorExample objCE = new ConstructorExample(true);
//ConstructorExample objCE2 = new ConstructorExample();
//ConstructorExample objCE3 = new ConstructorExample();

///////////////////////////////////// 03 September 2024 /////////////////////////

//Parent objParent = new Parent();

//objParent.ParentMethod();

//Child objChild = new Child();

//objChild.ParentMethod();
//objChild.ChildMethod();

//GrandChild objGrandChild = new GrandChild();

//objGrandChild.ParentMethod();
//objGrandChild.ChildMethod();
//objGrandChild.GrandChildMethod();


//B objB = new B();

//objB.MehtodA();

/////////////////////////////////////// 11 September 2024 /////////////////////////////////////////////

//ChildMethodHiding objChild = new ChildMethodHiding();

//objChild.Method1();

//MethodHidingExample objParent;
//objParent = new ChildMethodHiding();



//objParent.Method1();

//AccessModifierExample objAME = new AccessModifierExample();

//objAME.varPublicInt = 10;

//objAME.varInternalString = "Shrikant";

//objAME.varProtectedInternal = 200; 


//////////////////////////////////////////////// 17 September 2024 /////////////////////////

//Honda objHonda = new Honda();

//objHonda.TestMethod();
//objHonda.TestClassMethod();
////objHonda.Method1();

//objHonda.HelloMethod();

//ICar carObj = new Honda();

//carObj.Method1();


//ITest testObj = new Honda();

//testObj.Method1();
//testObj.TestMethod();

//////////////////////////////////////////////// 30th September 2024 /////////////////////

//ChildAbstract objCA = new ChildAbstract();

//objCA.Method1();
//objCA.Method2();
//objCA.Method3();


//CollectionExample.ArrayListOperation();

///////////////////////////  15th October 2024 /////////////////////////////

//ExceptionHandleExample objEHE = new ExceptionHandleExample();

//objEHE.TestMethod(-20);

OutVsRefExample objOVR = new OutVsRefExample();


int sum, subtract, multiply, divide;

objOVR.Sum(100, 200, out sum, out subtract, out divide, out multiply);

Console.WriteLine("Sum is " + sum);

int value1 = 200;
int value2 = 3000;
int result = 0; 

objOVR.Subtract(ref value1, ref value2, ref result);




Console.ReadLine();



