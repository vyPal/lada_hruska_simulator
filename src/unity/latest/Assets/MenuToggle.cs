using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToggle : MonoBehaviour
{
	public string SceneName;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		//uses the p button to pause and unpause the game
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(SceneName);
		}
	}
}
