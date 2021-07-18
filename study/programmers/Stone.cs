using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
	Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Ball").transform.localPosition;
    }

    // Update is called once per frame
    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);
		transform.Rotate(new Vector3(0,0,5));
    }

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Ball")
		{
			Debug.Log("Restart: " + other.gameObject.name);
			GameObject.Find("GameManager").SendMessage("RestartGame");
		}
	}
}
