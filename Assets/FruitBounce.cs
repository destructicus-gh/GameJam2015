using UnityEngine;
using System.Collections;

public class FruitBounce : MonoBehaviour {
    public AnimationCurve bounce;
    float place = 0f;
    public float initialY;
	// Use this for initialization
	void Start () {
        initialY = transform.localPosition.y;
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = new Vector3(transform.localPosition.x, initialY+ bounce.Evaluate(place += Time.deltaTime), transform.localPosition.z);
        if (place > 1) place = 0;
	}
}
