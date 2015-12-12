using UnityEngine;
using System.Collections;

public class GeneratorController : MonoBehaviour {
    public CharacterControl hebro;
    public Transform contains;
    public GameObject prefab;

    bool enabled = true;
	// Use this for initialization
	void Start () {
	    GameObject newOne = Instantiate(prefab, transform.parent.position + Vector3.up, transform.parent.rotation) as GameObject;
        contains = newOne.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        print(other.gameObject);
        if (other.gameObject == hebro.gameObject)
        {
            for (int i = 0; i < hebro.transform.childCount; i++)
            {
                if (hebro.transform.GetChild(i).name == contains.name)
                {
                    return;
                }
                if (hebro.transform.GetChild(i).CompareTag("grabbable"))
                {
                    Destroy(hebro.transform.GetChild(i).gameObject);
               
                }
            }
            hebro.giveTransform(contains);
            enabled = false;
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        if (enabled)
        enabled = true;
        
        GameObject newOne = Instantiate(prefab, transform.parent.position + Vector3.up, transform.parent.rotation) as GameObject;
        contains = newOne.transform;
        //ExecuteAfterTime(.5f);
        
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        //Destroy(contains);
        
        // Code to execute after the delay
    }


}
