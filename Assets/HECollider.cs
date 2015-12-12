using UnityEngine;
using System.Collections;

public class HECollider : MonoBehaviour {

    public CharacterControl control;
    public bool isF;

	// Use this for initialization
	void Start () {
        print(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);
        if (!other.CompareTag("scenery")) return;
        if (isF)
        {
        control.isFBlocked = true;
        }
        else
        {
            control.isBBlocked = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("scenery")) return;

        if (isF)
        {
            control.isFBlocked = false;
        }
        else
        {
            control.isBBlocked = false;
        }
    }
}
