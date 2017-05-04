using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller : MonoBehaviour {

    //Sätter publica variabler, movementspeed, mousespeed, och tilthead. 
    public float movementSpeed, mouseSpeed, tiltHead;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Rotation höger vänster
        float rotationHogerVanster = Input.GetAxis("Mouse X") * mouseSpeed;
        transform.Rotate(0,rotationHogerVanster,0);

        //Rotation kamera
        float rotationUppNer = Input.GetAxis("Mouse Y") * mouseSpeed;
        Camera.main.transform.Rotate(-rotationUppNer, 0, 0);

        //Vertical & horizontal flytt
        float speedForward = Input.GetAxis("Vertical") * movementSpeed;
        float speedSideStep = Input.GetAxis("Horizontal") * movementSpeed;
        Vector3 speed = new Vector3(speedSideStep, 0, speedForward);

        //Rotation adderad till speed.
        speed = transform.rotation * speed;

        //Sätter Character kontroll.
        CharacterController cc = GetComponent<CharacterController>();
        cc.SimpleMove(speed);


	}
}
