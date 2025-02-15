using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbieBank : MonoBehaviour
{

    // Start is called before the first frame update

    /* TODO: Problem 3: BARBIE'S BANK
    Convert the following function to a generic if needed. 
    Then, write a private generic function named BarbieBank. 
    BarbieBank should take in the parameters: numOfPennies, cashAmount, and numOfCreditCards
    Have the function return a new generic array with the correct parameters. 
    */

    private Object[] BarbieBank<T1, T2, T3>(T1 numOfPennies, T2 cashAmount, T3 numOfCreditCards)
    {
        return new Object[] { numOfPennies, cashAmount, numOfCreditCards };
    }

    void Start()
    {
        int[] biggerWallet = BarbieWallet(500, 600);
        Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1]);

        GetMoney(500, 600);
    }

    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes. 
            //protected means the field is only accessible within the class and not outside it. With inheritance, 
            the protected field can be accessed by a class that inherits from where its defined.
            
        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour. 
            //Monobehaviour is the base class that scripts use and is used to add life cycle functions. 
            Unity scripts inherit from it because it allows the ript to be attached to game objects in the editor
            Some functios that come from it include Start(), Update() and Awake().
    
        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
            //Multiple inheritance is the ability to inherit from more than one base class. 
            C# does not allow multiple inheritance as it can lead to complications in maintaining code. 
            
        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
            //protected means the field can only be accessed within the class, virtual means the method can be overriden in a 
            derived class and void means it's not returning a value
            It's needed when you have a method that you want to be accessible to subclasses but you need the subclasses to be able to custoize the behavior. 
            Virtual makes it so they can override the method.

            
        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
            //When a constructor in a parent class is called, it initializes the base class part of the object before the derived class constructor runs. 
            We control which base class constructor is called by using the base keyword.
     */ 
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }


    
