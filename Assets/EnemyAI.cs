using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
	private NavMeshAgent agent;
	private Transform destinationPoint;
	private Transform exitPoint;
	public bool isHealthy = false;

	// Use this for initialization
	void Start ()
	{
		agent = gameObject.GetComponent<NavMeshAgent> ();
		destinationPoint = GameObject.FindWithTag ("Destination").transform;
		exitPoint = GameObject.FindWithTag ("Exit").transform;
	}


	void OnTriggerEnter(Collider other){
		if (other.name == "Exit") {
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isHealthy) {
			agent.SetDestination(destinationPoint.position);
		} else {
			agent.SetDestination(transform.position);
			//play eating animation and happy. then customer exits.
			agent.SetDestination(exitPoint.position);
		}
	}
}

