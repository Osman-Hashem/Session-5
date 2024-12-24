using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    // Access Modifiers : C# KeyWords Indiciate Accessibility Scope 
    // 1- Private
    // 2- Private Protected
    // 3- Protected
    // 4- internal 
    // 5- internal Protected
    // 6- Public 


    // What Can Write Inside The Namespace ?
    // 1- Class
    // 2- Struct 
    // 3- Interface
    // 4- Enum


    // Access Modifiers Inside The NameSpce : 
    // 1- Internal : Inside The Same Project
    // 2- Public   : Everywhere 

    // Default Access Modifier Inside The Namespace "Internal"


    // What Can Write Inside The Class Or Struct ?
    // 1- Attributes [Filed - Member Varible]
    // 2- Properties [Full Property - Automatic Proprety - Special Proprety(Indexer)]
    // 3- Methods - Functions
    // 4- Event 


    // Access Modifier Inside The Class :

    // 1- Private
    // 2- Private Protected
    // 3- Protected
    // 4- internal 
    // 5- internal Protected
    // 6- Public 




    // Access Modifier Inside The Struct :

    // 1- Privat   : Inside The Same Class
    // 2- Internal : Inside The Same Project 
    // 3- Public   : Everywhere 


    // Default Access Modifier Inside The Class OR Struct "Private"



    // What Can Write Inside The Interface :
    // 1- Signature Of Methods [Return Type - Name - Parameter]
    // 2- Signature Of Property 
    // 3- Default Implemented Methods [C# 8.0 .NET Core 3.1]


    // All Access Modifiers Except "Private"


    // Default Access Modifier Inside The Interface : "Public"







    internal class TypeA
    {
        void Fun01()
        {
            TypeA typeA = new TypeA();

            TypeB typeB = new TypeB(); // Valid 

            //typeB.X = 12; // InValid : Private
                          
            //typeB.Y = 13; // Valid 
            
            //typeB.Z = 14; // Valid 
        
        
        }
    }
}
