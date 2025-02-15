using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 5: BARBIES HOUSE
Barbie's House needs to inherit everything from the BarbieWorld class in your
BarbieWorld.cs file. Please modify the BarbieHouse class to inherit from
BarbieWorld and write at least three methods within BarbieHouse representing 
furniture, pets, household items, food, etc. within her house. 
*/ 
public class BarbieHouse : BarbieWorld
{

    public List<string> Furniture {get; set;}
    public List<string> Pets {get; set;}
    public List<string> Food {get; set;}


    public BarbiesBelongings ()
        {
            Furniture = new List<string>();
            Pets = new List<string>();
            Food = new List<string>();
        }


    public void ListFurniture()
        {
            Furniture.Add("Chair");
            Furniture.Add("Bed");
        }

     public void ListPets()
        {
            Pets.Add("Dog");
            Pets.Add("Cat");
        }
        
 public void ListFood()
        {
            Food.Add("Pizza");
            Food.Add("Cake");
        }
public class Program
{
    public static void Main()
    {
        
        BarbieHouse barbieHouse = new BarbieHouse();

    
        barbieHouse.ListFurniture();  
        barbieHouse.ListPets();       
        barbieHouse.ListFood();      
    }
}















    
}
