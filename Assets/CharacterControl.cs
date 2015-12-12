using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {

    public bool isFBlocked;
    public bool isBBlocked;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
           
	if (Input.GetKeyUp(KeyCode.W))
    {
        if (!isFBlocked)
            this.gameObject.transform.Translate(Vector3.forward);
    }
    if (Input.GetKeyUp(KeyCode.S))
    {
        if (!isBBlocked)
            this.gameObject.transform.Translate(Vector3.back);
    }
        
		if (Input.GetKeyUp(KeyCode.A)){
			
            this.gameObject.transform.Rotate(Vector3.up, 90);
			
		}
		if (Input.GetKeyUp(KeyCode.D)){

            this.gameObject.transform.Rotate(Vector3.up, -90);
			
		}
		
	}

	
}
