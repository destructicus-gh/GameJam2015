using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {

    public float speed;
    public float turnSpeed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
           
	if (Input.GetKey(KeyCode.W)){
			
			Vector3 newPosition = this.gameObject.transform.position;
            newPosition.z += (speed * Time.deltaTime);
			this.gameObject.transform.position = newPosition;
			
		}
		if (Input.GetKey(KeyCode.S)){
			
			Vector3 newPosition = this.gameObject.transform.position;
            newPosition.z -= (speed * Time.deltaTime);
			this.gameObject.transform.position = newPosition;
			
		}
		if (Input.GetKey(KeyCode.A)){
			
            this.gameObject.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
			
		}
		if (Input.GetKey(KeyCode.D)){

            this.gameObject.transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
			
		}
		
	}
	
}
