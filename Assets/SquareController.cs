using UnityEngine;
using System.Collections;

public class SquareController : MonoBehaviour {

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    // Use this for initialization
    void Start()
    {
        Shoot(new Vector3(0, 0,0));
    }

    void OnCllisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
