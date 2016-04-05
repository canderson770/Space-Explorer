using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinTextControl : MonoBehaviour
{
	Text coinText;

	public void Start()
	{
		coinText = GetComponent<Text> ();
	}

	void Update ()
	{
		coinText.text = StaticVars.coins.ToString().PadLeft(2, '0');
	}

}
