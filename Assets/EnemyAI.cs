using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
	private NavMeshAgent agent;
	public Transform destinationPoint;
	public Transform exitPoint;
	public bool isHealthy = false;
	public bool exitFlag = false;

	// Use this for initialization
	void Start ()
	{
		agent = gameObject.GetComponent<NavMeshAgent> ();
	}


	void OnTriggerEnter(Collider other){
		if (other.name == "Cheeseburger") {
			//lose heart and customer exits.
			exitFlag = true;
		} else if (other.name == "Exit") {
			Destroy (gameObject);
		} else if (other.name == "Apple") {
			isHealthy = true;
			ScoreManager.score += 10;
		} else if (other.name == "Orange") {
			ScoreManager.score += 15;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(exitFlag) {
			//play eating animation and happy. then customer exits.
			agent.SetDestination(exitPoint.position);
		} else if (!isHealthy) {
			agent.SetDestination(destinationPoint.position);
		} 
	}
}

