using UnityEngine;
using System.Collections;

public class GameGenerator : MonoBehaviour {

    // Use this for initialization
    public GameObject SquarePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject square = Instantiate(SquarePrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            square.GetComponent<SquareController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
