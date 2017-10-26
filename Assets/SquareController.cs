using UnityEngine;
using System.Collections;

public class SquareController : MonoBehaviour {

    GameObject SpherePrefab;

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    // Use this for initialization
    void Start()
    {
        Shoot(new Vector3(0, 200,2000));
    }

    void OnCllisionEnter(Collision other)
    {
        Destroy(SpherePrefab);

    }
	// Update is called once per frame
	void Update () {
	
	}
}
