using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private bool isMoving;
    private Vector2 input;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal"); // 상하좌우키를 입력 받음, return -1, 1
            input.y = Input.GetAxisRaw("Vertical");
            if (input.x != 0)
                input.y = 0;
            if (input != Vector2.zero)
			{
                var targetPos = transform.position; // Vector2 or Vector3
                targetPos.x += input.x;
                targetPos.y += input.y;
                StartCoroutine(Move(targetPos));
			}
        }
    }

    IEnumerator Move(Vector3 targetPos)
	{
        isMoving = true;
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
		{
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
		}
        transform.position = targetPos;
        isMoving = false;
    }
}