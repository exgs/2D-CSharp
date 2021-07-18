using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Failzone : MonoBehaviour
{
    // Start is called before the first frame update
	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Ball")
		{
			Debug.Log("Restart: " + other.gameObject.name);
			GameObject.Find("GameManager").SendMessage("RestartGame");
		}
	}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
