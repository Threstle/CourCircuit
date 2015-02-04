using UnityEngine;
using System.Collections;

public class CanonScript : MonoBehaviour {

	public GameObject bullet;
	public float force;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
						shoot ();
	}

	public void shoot(){
		GameObject bulletInstance = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
		bulletInstance.rigidbody2D.AddForce (-Vector2.right * force);
		Debug.Log (bulletInstance);
	}
}
