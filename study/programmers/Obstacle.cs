using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		// localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
		// localPosition = transform.localPosition;
		localPosition = transform.position;
		Debug.Log(gameObject.name + " : " + localPosition);
        newXposition = localPosition.x;
    }

	void OnCollisionEnter(Collision collision) // 부딪치면 호출됨, 충돌한 대상을 매개변수로 받는다.
	{
		Debug.Log(collision.gameObject.name);
		Vector3 direction = transform.position - collision.gameObject.transform.position;
		direction = direction.normalized * 1000;
		collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
	}

	void OnTriggerEnter(Collider other) // 부딪히진 않지만, 영역을 넘어가면 trigger 발생
	{
		
	}
	float newXposition;
	Vector3 localPosition;
	bool derection = false;
    // Update is called once per frame
    void Update()
    {
		if (derection == false)
			newXposition -= 0.1f;
		else
			newXposition += 0.1f;
		if (newXposition < -2)
			derection = true;
		else if (newXposition > 4)
			derection = false;
        // transform.position = new Vector3(newXposition,2,0); // Global position == transform.position
		// transform.localPosition = new Vector3(newXposition, transform.localPosition.y, transform.localPosition.z);
		// Debug.Log(gameObject.name + " : " + localPosition);

		transform.localPosition = new Vector3(newXposition, localPosition.y, localPosition.z);
    }
}
