using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody rb;

    private void OnTriggerEnter()
    {
        rb.AddForce(0, 0, 0, ForceMode.VelocityChange);//stops movement  
        gameManager.CompleteLevel();
    }
}
