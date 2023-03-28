using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<RigidBody>();
        Physics.gravity *= gravityModifier; }
    }

    // Update is called once per frame
    void Update()
{
    if (Input.GeyKeyDown(KeyCode.Space))
    {
        playerRb.AddForce(vector3.up * jumpForce, ForceMode.Impulse);
    }
}
       
      
       
        


