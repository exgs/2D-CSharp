using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class Shooter : Obstacle
public class Shooter : MonoBehaviour
{
    void Start()
    {
        Debug.Log("타워");
    }

	float timeCount = 0;
	public GameObject prefab;
    void Update()
    {
		// base.Update();
        timeCount += (float)Time.deltaTime;
		if (timeCount > 3)
		{
			Debug.Log("돌을 던져라");
			Instantiate(prefab, transform.position, Quaternion.identity);	
			timeCount = 0.0f;
		}
    }
}
