using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    public int colCount = 0;
    public PlayerMovement movement;

    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {
            movement.StopPlayer();
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collision.collider.tag == "GameWall")
        {
            movement.StopPlayer();
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    public void StopPlayer()
    {
        movement.enabled = false; //stops movement
    }
    
}





