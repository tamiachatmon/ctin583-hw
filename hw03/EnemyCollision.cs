using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(AlternateWeapons)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // TODO: Problem 7: Why did I not include the words public or private here? 
        //if you don't specify it as public or private, it will default to be a public method. 
        //Making it private just makes it inaccessible from other classes which you may not want since you didn't declare it as private. 
    
    // What does it mean when I only write void (Movement)? What does void mean? 
        // void means no value is being returned so the function takes no paremeters
    
    void Movement ()
    {
        // TODO: Problem 8: Please explain what the next 4 lines mean.
        // What is Input.GetAxis, transform.Translate, and transform.Rotate? 
        
        //Input.GetAxis is a function used to get the value of the axis identified in the parenthesis i.e. the vertical axis
        //transform.Translate is used to move the transform value in the direction and distance specified
        //transform.Rotate roates the GameObject as specified
        
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime; //this is getting input from the player and determining how much they should move along the vertical axis
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime; //getting input from the player and determining how much to move rotate them
        
        transform.Translate(Vector3.forward * forwardMovement); //this is moving the player forward by the value of forwardMovement defined above
        transform.Rotate(Vector3.up * turnMovement); //rotating player by value of turnMovement

    
    }
    
    
    void Shoot ()
    {
        // TODO: Problem 9: Looking at this code, is this code using Unity's Old or New 
        // Input System? Please describe what Instantiate is doing in this if statement.
            //this is the old input system because it used GetButtonDown instead of Input Actions
            //in this statement, instantiate is creating the bullet prefab from a specific position and rotation when the correct button is pressed
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }

    /* TODO: Problem 10: In our game, we want our enemy to alternate weapons every couple of frames.
    However, also would like our enemy to lose access to their weapons when they are frozen/disabled.
    First, let's define a public class named Weapon. In the class, define 3 int variables for arrow, sword, and rocket.

    public class Weapon
    {
        public int arrow;
        public int sword;
        public int rocket;
        public int currentWeapon;
        
    }

    IEnumerator AlternateWeapons ()
    
    {
        int[] weapons = { arrow, sword, rocket };
       
       while (true)
        {
            foreach (int weapon in weapons)
            {
                currentWeapon = weapon; 
                yield return new WaitForSeconds(5f);
            }

        }
    }
    
    

    Outside of our Weapon class, we would want to define an IEnumerator function. 
    Then in our class, write a for loop that loops between the arrow, sword, and rocket. 
    Use the WaitForSeconds function to tell it to switch weapons every 5 seconds. 

    Remember to call your Coroutine.
    */ 
}
