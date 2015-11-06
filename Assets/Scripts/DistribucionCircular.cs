using UnityEngine;
using System.Collections;

public class DistribucionCircular : MonoBehaviour {

	public GameObject cubo0;
	public GameObject cubo1;
	public GameObject cubo2;
	public GameObject cubo3;
	public GameObject cubo4;
	public GameObject cubo5;

		
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 aux = Vector3.zero;
		if (Input.GetKeyDown(KeyCode.Space)) {
			aux = cubo0.transform.position;
			cubo0.transform.position = cubo1.transform.position;
			cubo1.transform.position = cubo2.transform.position;
			cubo2.transform.position = cubo3.transform.position;
			cubo3.transform.position = cubo4.transform.position;
			cubo4.transform.position = cubo5.transform.position;
			cubo5.transform.position = aux;


		}
	}
}
