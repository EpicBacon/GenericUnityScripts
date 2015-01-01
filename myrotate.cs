using UnityEngine;
using System.Collections;

public class myrotate : MonoBehaviour {
	
    void Update() {
        //transform.Rotate(Vector3.right * Time.deltaTime);
        transform.Rotate(Vector3.up * Time.deltaTime * 50f, Space.World);
    
	}
	
}