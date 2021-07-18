using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Vector3 initRotation = transform.eulerAngles;
		Debug.Log(initRotation.x + " " + initRotation.y + " " + initRotation.z);
		Vector3 localRotation = transform.localEulerAngles;
		Debug.Log(localRotation.x + " " + localRotation.y + " " + localRotation.z);

    }

    // Update is called once per frame
    void Update()
    {
        // 사용자입력 받기
		// Debug.Log("GetAxis: " + Input.GetAxis("Horizontal"));
		// Vector3 Rotation = transform.localEulerAngles;
		Vector3 initRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
		Vector3 localRotation = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z);

		float zRotation = transform.localEulerAngles.z;
		zRotation += Input.GetAxis("Horizontal");
		// Debug.Log(initRotation.x + " " + initRotation.y + " " + initRotation.z);
		transform.eulerAngles = (new Vector3(initRotation.x, initRotation.y, zRotation));

		if (Input.touchCount > 0 || Input.GetMouseButton(0)) // 0번 마우스 왼쪽버튼
		{
			Debug.Log("mouse down: " + Input.mousePosition);
			if (Input.mousePosition.x < Screen.width / 2)
			{
				transform.localEulerAngles = (new Vector3(initRotation.x, initRotation.y, zRotation + 1));
			}
			else
			{
				transform.localEulerAngles = (new Vector3(initRotation.x, initRotation.y, zRotation - 1));
			}
		}
    }
}
