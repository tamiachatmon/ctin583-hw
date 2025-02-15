using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
       // GetComponent<T> is a Unity method that lets you retrieve a component of a specified type atttached to a GameObject.  
          it's considered a generic method because it lets you get a component of any type when you call the function.
       
    * In generics, there is a particular convention we follow in defining generics. What letter do we use to represent a placeholder type or generic? In generics, what are the naming conventions used if we have more than one parameter? 
      // In generics you use 'T' as the placeholder type for a single generic. When defining multiple parameters you continue the                    alphabetical order (T, U, V, etc.)
   
    * What does the generic variable do? Why does it end up as the return type and argument type for a method? 
      //The generic variable serves a placeholder that works for any data type that can be determined at the time the program runs.
         it ends up as the both the argument type and return type because doing so enables the method to be more easily reused and safe
    
    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
      //Generics can be useful for things like dictionaries and lists. For example, you can use generics for an inventory 
      system to keep track of weapoons, potions, etc. 
    
    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
      // Using generics arrays are better for performance while non=generic arrays can cause slower performance because they tend to have          higher memory usage rates, particulary if the array has many value types that are being frequently accessed
    
    * What does it mean to instantiate? 
       //instantiate means to create a new instance of a game object at runtime


   // */

void Start()
{
     BarbieWorld<string> barbieWorld = new BarbieWorld<string?();
      barbieWorld.BarbieCareer("Singer");
}

public class BarbieWorld<T>
{
    T item; 
    /* TODO: Problem 2: BARBIE'S CAREERS: Barbie wears many hats. She is a photographer,
    singer, athlete, painter, musician, rockstar, and much more.
    What is the function below trying to accomplish?

    //the function below is trying to make it so the method can take a new career type and change it to the current career
    
    How are we using the T variable in this case?

    //the T variable is being used as a generic placeholder for the type of Barbie's career
    
    Please instantiate an item of this class in  
    your BarbieWalletBalance.cs file in your
    Start() or Update() functions. */
    
    public void BarbieCareers(T newCareer) 
    {
        currentCareer = newCareer;
    }
}

   
