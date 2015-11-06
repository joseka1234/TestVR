using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {


	public GameObject player;
	float x;
	float y;
	float z;

	// Use this for initialization
	void Start () {
		x = player.transform.position.x;
		y = player.transform.position.y;
		z = player.transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A))
			x--;
		if (Input.GetKey (KeyCode.D))
			x++;
		if (Input.GetKey (KeyCode.W))
			z++;
		if (Input.GetKey (KeyCode.S))
			z--;

		player.transform.position = new Vector3 (x,y,z);
	}
}
