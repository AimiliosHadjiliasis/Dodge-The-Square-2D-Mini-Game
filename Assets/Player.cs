using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;   //Initialise speed
    public float mapWidth = 5f;

    private Rigidbody2D rb; //Create a reference to the rigid body component of the player

    void Start()
    {
        //Reference the rigid body to the player when the game begins 
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Create a variable that gets the Horizontal input, can be ASDW or arrow keys 
        //can be (-1.-2.0.1 etc)
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        //Move the object:
        //We create a vector2 variable that will store the new position of the player
        //We use vector 2 since we need to add the movement to the X/Y axis
        //and then multiply with x so we can have full horizontal movment (possitive, negtive)
        //THEN:
        //we use the Mathf.Clamp function to limit the movemnt of the player 
        //by adding as parameters the new possition and the 2 limits which is the +-MapHeight
        //finally move our rigid body with the use of MovePosition function with an amount of 
        //vector2 newPosition
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);

    }
}
