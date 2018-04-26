using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenHandler : MonoBehaviour {

    //public GvrBasePointerRaycaster raycaster;
    public Camera camera;
    public float thrust;

    public Rigidbody rb;
    public AudioSource paddle;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")){

            float camX = camera.transform.forward.x;
            float camZ = camera.transform.forward.z;
            Vector3 power = new Vector3(camX * thrust, 0, camZ * thrust);
            rb.AddRelativeForce(power, ForceMode.Impulse);
            paddle.Play();
            Debug.Log(rb.velocity);
        }
    }

}
