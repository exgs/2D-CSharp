using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

	void RestartGame()
	{
		Application.LoadLevel("ball2");
	}

	GameObject []obstacles;
	void DestroyObstacles()
	{
		obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
		foreach (GameObject temp in obstacles)
		{
			Destroy(temp);
		}
	}

	public int coinCount = 0;
	public Text coinText;
	void GetCoin()
	{
		coinCount++;
		coinText.text = "먹은 코인 갯수: " + coinCount;
		Debug.Log("먹은 동전 갯수: " + coinCount);
	}
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
