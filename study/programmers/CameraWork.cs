using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    // Start is called before the first frame update
	GameObject ball;
	GameObject[] coins;
    void Start()
    {
        ball = GameObject.Find("Ball");
		coins = GameObject.FindGameObjectsWithTag("Coin");
		foreach (GameObject temp in coins)
		{
			Debug.Log(temp.name);
		}
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Ball position: " + ball.transform.position.z);
		transform.position = new Vector3(0, ball.transform.position.y + 5, ball.transform.position.z - 10);
    }
}
