using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour
{
	RectTransform thisTransform;

	// Use this for initialization
	void Start ()
	{
		thisTransform = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.localScale = new Vector3(StaticVars.playerhealth, 1, 1);
	}
}
