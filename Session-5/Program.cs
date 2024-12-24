namespace Session_5
{

    //enum Sesons
    //{
    //    Spring,
    //    Witer,
    //    Summer,
    //    Autumn
    //}

    //enum WeekDay
    //{
    //    Saturday,
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday
    //}

    //enum Gender
    //{
    //    M = 1,
    //    F = 2,
    //    Male = 1,
    //    Female = 2
    //}

    // Read , Write , Execute , Delete 

    //[Flags]
    //enum Premissions
    //{
    //    Read = 8,
    //    Write = 4,
    //    Execute = 2,
    //    Delete = 1
    //}

    internal class Program
    {

        //static void DoSomeCode()
        //{
        //    int X, Y, Z;
        //    X = int.Parse(Console.ReadLine());
        //    Y = int.Parse(Console.ReadLine());

        //    Z = X / Y;

        //    int[] Arr = { 1, 2, 3, 4, 5 };

        //    Arr[99] = 10; 
        //}

        //static void DoSomeCode()
        //{
        //    try
        //    {

        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine());
        //        Y = int.Parse(Console.ReadLine());

        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3, 4, 5 };

        //        Arr[99] = 10;

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally 
        //    {
        //        Console.WriteLine("Finaly");

        //        // DisConnect | Dispose > UnManged Resource 
        //    }
        //    /*
        //    catch (FormatException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    catch (IndexOutOfRangeException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    */
        //}
        //=============================================

        //static void DoSomeProtectiveCode ()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        bool Flage;
        //        do
        //        {
        //            Console.WriteLine("Enter First Number : ");
        //            Flage = int.TryParse(Console.ReadLine(), out X);

        //        }
        //        while (Flage == false);
        //        do
        //        {
        //            Console.WriteLine("Enter Second Number : ");
        //            Flage = int.TryParse(Console.ReadLine(), out Y);

        //        } while (Flage == false || Y == 0);

        //        Z = X / Y;

        //        int[] Arr = { 1, 2, 3, 4, 5 };
        //        if (99 < Arr?.Length)
        //        {
        //            Arr[99] = 10;
        //        }

        //    }
        //    catch (Exception E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }

        //}


        static void Main(string[] args)
        {

            #region Boxing And UnBoxing 
            // Boxing And UnBoxing 

            // Boxing : Casting From ValueType To ReferenceType 
            // Boxing : Casting From  ReferenceType To ValueType

            // object O1;

            // O1 => Can Refer To Instance Od "Object" Or Any Instant Of Any Type 

            //O1 = 1;
            //O1 = "Ahmed";

            //O1 = 3;                 // Cast From ValuType[Int] To ReferceType[Object] => Boxing 
            //O1 = 1.5;               // Cast From ValuType[double] To ReferceType[Object] => Boxing 
            //O1 = "A";               // Cast From ValuType[char] To ReferceType[Object] => Boxing 
            //O1 = true;              // Cast From ValuType[bool] To ReferceType[Object] => Boxing 
            //O1 = new DateTime();    // Cast From ValuType[DateTime] To ReferceType[Object] => Boxing 

            // int X = 5;

            // object O1 = /*(object)*/ X;

            // Implicit Casting 
            // Safe Casting 
            // Boxing 
            // Parent = Child => Child is Parent 
            // Animal = Dog => Dog is Animal 

            //object O1 = 3; 

            //int X = (int)O1;

            // Explicit Casting 
            // UnSafe Casting [May Threw Exception]
            // UnBoxing 
            // Dog = (Dog) Animal => Animal is Dog 
            // Child = Parent => Parent is Child  
            #endregion


            #region Nullable Types 
            // Nullable Types :
            // 
            // Value Type 
            // Reference Type 


            #region Nullable ValueTypes

            // int X = 6;

            // X = null; // Not Valid 

            // Nullable Value Type => Value Type Allow Null As Valid Value 

            // Nullable <int> : Allow Int Value Or Null As Valid Value 

            //int? Age = 20;
            //Age = null;

            // Nullable <double> : Allow Int Value Or Null As Valid Value 

            //double? Salary = 400.5; 
            //Salary = null;



            // int X = 5;

            // Y : Nullable<int>
            // Y : Allow int Value Or Null

            // int? Y = /*(int?)*/ X;

            // Implicit Casting
            // Safe Casting 

            // Console.WriteLine(Y);


            //int? X = 6;

            // X = null;

            //X = null;

            // Y : int
            // Y : Allow int Value Only

            //int Y = (int)X;

            // Explicit Casting 
            // May Threw Exception 


            // Defensive Code 

            //if (X != null) 
            //    Y = (int)X;
            //else 
            //    Y = 0;

            // Console.WriteLine(Y);

            // ===============================
            //if (X is not null) 
            //    Y = (int)X;
            //else 
            //    Y = 0;

            // Console.WriteLine(Y);

            // ===============================

            //if (X.HasValue) 
            //    Y = X.Value ;
            //else 
            //    Y = 0;

            // Console.WriteLine(Y);

            // ===============================

            // Y = X.HasValue ? X.Value : 0 ;

            // ===============================

            // Y = X is not null ? X.Value : 0 ; 

            // ===============================

            // Null coalescing Operation ??

            // Y = X ?? 0 ; // Syntax Sugar : Y = X is not null ? X.Value : 0

            // Console.WriteLine(Y); 
            #endregion

            #region Nullable Reference Type
            // Nullable Reference Type [C# 10.0 .NET 6.0]
            // 
            //string Message01 = null; // Required 

            //string? Message02 = null; // Nullable 

            //Console.WriteLine(Message01.Length);
            //Console.WriteLine(Message02); 
            #endregion




            #endregion


            #region Null Propagation Operator ?
            // Null Propagation Operator ?

            //double X = default; // 0 
            //bool C = default;
            //char C = default;

            //Console.WriteLine(C);

            //int[] Arr = default; // null
            // int[] Arr = {1,2,3,4,5,4,5};


            // Best Practice 

            //if (Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //        Console.WriteLine(Arr[i]);
            //}

            //for (int i = 0; (Arr is not null ) && i < args.Length; i++)
            //    Console.WriteLine(Arr[i]);


            //for (int i = 0; i < Arr?.Length; i++)
            //    Console.WriteLine(Arr[i]); 


            // int len = Arr is not null ? Arr.Lenght : 0 ; 

            // int? len = Arr?.lenght ; 

            // int len = Arr?.lenght is not null ? Arr.Lenght : 0;

            // int Len = Arr?.lenghr ?? -1 ; 

            // Console.WriteLine(Len); 
            #endregion


            #region Exception Handling And Protective Code 
            // DoSomeCode();
            // DoSomeProtectiveCode();
            // Console.WriteLine("Hello");

            // Exception :
            // 1- SystemException 
            //    1-1- FormatEXception
            //    1-2- IndexOutOfRangeException
            //    1-3- NullReferenceException
            //    1-4- ArithmeticException
            //      1-4-1- OverflowException
            //      1-4-2- DivideByZeroException
            // 
            // 2- ApplicationException 
            #endregion


            #region Access Modifiers 
            // Class Library :

            // Common.TypeA typeA = new TypeA(); // Invalid : TypeA Is Internal

            //  Common.TypeB typeB = new TypeB(); // Valid : TypeB Is Public 

            //typeB.X = 12;   // InValid Private 
            //typeB.Y = 12;   // InValid Internal
            //typeB.Z = 12;   // Valid  
            #endregion


            #region Enum
            // Enum : Value Types 
            // STACK 

            // int Num = 0; 

            // Sesons S01 = Sesons.Spring;
            // Console.WriteLine(S01);

            // SLR Represent Enum As Integer Value In Memory

            //Gender G01 = Gender.M;
            //Console.WriteLine(G01);

            // Gender G01 = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine() , true );
            //Gender G01;

            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object O1);

            //G01 = (Gender) O1;


            //Console.WriteLine(G01);



            //Premissions Per01 = Premissions.Read;
            //Per01 ^= Premissions.Delete; // Toggle 

            //// Per01 |= Premissions.Delete; // Add Permession
            //Console.WriteLine(Per01); // Delete , Read 
            //// Per01 ^= Premissions.Delete; // Toggle

            //Console.WriteLine(Per01); // Read 
            //Console.WriteLine(Per01); // Delete , Read 

            //Per01 &= ~(Premissions.Delete); // ~ Not Bitwise 
            //// & > Check Permissions

            //if ( ( Per01 & Premissions.Delete ) == Premissions.Delete ) 
            //{
            //    Console.WriteLine("Exists");
            //}
            //else
            //{
            //    Console.WriteLine(" Not Exists ");
            //} 
            #endregion
            //

        }
    }
}
