using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ThrowItem : MonoBehaviour
{
    public float throwForce = 10f;  // The force with which the item is thrown
    public GameObject itemPrefab;   // The item to throw (stone, etc.)

    public int conterDarts=0;
    
    public GameObject BackToWork;

    public GameObject BreakTime;

    public GameObject PCZone2;
    
    void Start()
    {

    }

    void Update()
    {
        if(conterDarts<4)
        {
            if (Input.GetMouseButtonDown(0))  // Left mouse button click
            {
                ThrowDart();
            }

        }
        else
        {
            BackToWork.SetActive(true);
            BreakTime.SetActive(false);
            PCZone2.SetActive(true);

        }
        
    }

    public void ThrowDart()
    {
        Debug.Log("Throw!!");
        // Instantiate the stone at the player's position
        GameObject Dart = Instantiate(itemPrefab, transform.position,quaternion.identity);

        // Get the Rigidbody component of the stone
        Rigidbody rb = Dart.GetComponent<Rigidbody>();
        
        // Throw the stone in the direction the camera is facing
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
        conterDarts++;

    }
}
