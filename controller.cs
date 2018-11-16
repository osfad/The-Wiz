using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

    public Rigidbody Light;
    public Rigidbody Ice;
    public Rigidbody Grav;


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update(){

        // the Horizontal movement
        print(Input.GetAxis("Horizontal"));
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);

        // the Vertical movement
        print(Input.GetAxis("Vertical"));
        transform.Translate(Input.GetAxis("Vertical") * 0f, 0f, Time.deltaTime);


        //-----------------------------------Spells-----------------------------------\\
        // list of spells that are given directions from the unity input layout

        //lightning
        if (Input.GetButtonDown("Light"))
        {
            Solar();
        }

        // gravity pulling orb
        if (Input.GetButtonDown("Grav"))
        {
            Spells();
        }

        // ice block
        if (Input.GetButtonDown("Ice"))
        {
            Icebeam();
        }

    }

    public void Icebeam()
    {
        Ice.AddForce(transform.forward * 150);
        Ice = Instantiate(Ice);
    }

    public void Solar() {
        Light.AddForce(transform.forward * 150);
        Light = Instantiate(Light);
    }

    public void Spells(){
        Grav.AddForce(transform.forward * 150);
        Grav = Instantiate(Grav);
    }

}
