using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
	public Rigidbody rb;
	public float stret =4500; 
	public float back =1500;
	public float left =2225;
	public float right =2225;
	public float jump =600;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	// streert fun
    	if (Input.GetKey("w")){
    	rb.AddForce(0,0,stret * Time.deltaTime);}
    	// back fun 
    	if (Input.GetKey("s")){
    	rb.AddForce(0,0,-back * Time.deltaTime);}
		// left fun most have negetive value to go left in - X POSiton
    	if(Input.GetKey("a")){
    	rb.AddForce(-left* Time.deltaTime,0,0 );}
    	// Right fun
    	if(Input.GetKey("d")){
    	rb.AddForce(right* Time.deltaTime,0,0 );}
    	// jump fun
    	if (Input.GetKey("space")){
    	rb.AddForce(0,jump * Time.deltaTime,0);}
        
    }
    	
}
