namespace Ass_4
{

    //enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    //enum Seasons
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}

    //enum Permissions
    //{
    //    Read,
    //    write,
    //    Delete,
    //    Execute
    //}

    //enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}


    internal class Program
    {



        static void Main()
        {


            #region Q01 : 
            /*
            Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, 
             write a C# program that prints out all the days of the week using this enum ???
            */


            //for (int i = 0; i < Enum.GetValues(typeof(WeekDays)).Length; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion


            #region Q02 :

            /*
             Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. 
            Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. ???
             */


            //try
            //{
            //    Console.WriteLine("Enter The Season Name  : ( Spring , Summer , Autumn , Winter ) ?? ");

            //    Seasons S01 = new Seasons();

            //    if (Enum.TryParse(typeof(Seasons), Console.ReadLine(), true, out object O1))
            //    {

            //        S01 = (Seasons)O1;


            //        if (S01 == Seasons.Spring)
            //        {
            //            Console.WriteLine("Corresponding Month Range Is ( March , April , May )  ");
            //        }
            //        else if (S01 == Seasons.Summer)
            //        {
            //            Console.WriteLine("Corresponding Month Range Is ( Jun , Jul , Aug )");
            //        }
            //        else if (S01 == Seasons.Autumn)
            //        {
            //            Console.WriteLine("Corresponding Month Range Is ( Sep , Oct , Nov )");
            //        }
            //        else if (S01 == Seasons.Winter)
            //        {
            //            Console.WriteLine("Corresponding Month Range Is ( Dec , Jan , Feb )");
            //        }
            //        else
            //        {
            //            Console.WriteLine("InValid Season ");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Invalid !!!");
            //    }

            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine(E.Message);
            //}


            #endregion


            #region Q04 : 
            /*
                Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
                Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable ????
             */


            //Permissions Per01 = new Permissions();

            //Per01 |= Permissions.Read; // ==> Add

            //Console.WriteLine(Per01);

            //Per01 &= ~(Permissions.Delete); // ==> Remove 

            //Console.WriteLine(Per01);

            #endregion


            #region Q05 :
            /*
             Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            Write a C# program that takes a color name as input from the user and displays a message 
            indicating whether the input color is a primary color or not. ????
             */



            //try
            //{
            //    Console.WriteLine("Enter The Color : ");

            //Colors C01 = new Colors();

            //Enum.TryParse(typeof(Colors), Console.ReadLine(), true, out object O2);

            //C01 = (Colors)O2;


            //    if (C01 == Colors.Red || C01 == Colors.Green || C01 == Colors.Blue)
            //    {
            //        Console.WriteLine("It Is A Primary Color ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("It Is Not A Primary Color ");
            //    }
            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine(E.Message);
            //}

            #endregion

        }
    }
}
