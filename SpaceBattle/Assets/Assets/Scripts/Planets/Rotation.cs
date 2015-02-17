using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public float rotationSpeed = 1.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
	}
}
