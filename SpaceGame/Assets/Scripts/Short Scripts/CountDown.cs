using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
	Text countdown;

	void Start()
	{
		countdown = GetComponent<Text> ();
        countdown.text = "3";
	}

	public void Two ()
	{
		countdown.text = "2";
	}
	
	public void One ()
	{
		countdown.text = "1";
	}

	public void Go ()
	{
		countdown.text = "Go";
	}
}
