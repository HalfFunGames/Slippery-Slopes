using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform Object;

    public Vector3 Displacement;
	
	// Update is called once per frame
	void Update () {
        transform.position = Object.position + Displacement;
	}
}
