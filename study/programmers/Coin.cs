using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Ball")
		{
			Destroy(gameObject);
			GameObject.Find("GameManager").SendMessage("GetCoin");
		}
	}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(GameObject.Find("GameManager").GetComponent<GameManager>().coinCount);
    }
}
