using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickExample : MonoBehaviour
{
	public Button quitbutton;

	void Start()
	{
		Button btn = quitbutton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Application.Quit();
	}
}
