using UnityEngine;
using System.Collections;

public class DestroySelf : MonoBehaviour {
	
	public float		time = 1f;
	
	// Use this for initialization
	void Start () {
		Invoke("SelfDestroy", time);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void	SelfDestroy()
	{
		Destroy(this.gameObject);
	}
}
