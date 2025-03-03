using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{

    public Transform orientation;
    public Transform playerCam;
    private Rigidbody rb;

    public float dashForce;
    public float dashUpwardForce;

    public KeyCode dashKey = KeyCode.LeftShift;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(dashKey)){
            Dashing();
        }
    }

    private void Dashing(){
        Vector3 forceToApply = orientation.forward * dashForce + orientation.up * dashUpwardForce;

        rb.AddForce(forceToApply, ForceMode.Impulse);
    }
}
