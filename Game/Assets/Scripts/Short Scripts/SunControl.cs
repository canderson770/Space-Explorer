using UnityEngine;
using System.Collections;

public class SunControl : MonoBehaviour
{
	public float sunSpeed = -0.01f;

	void Update ()
	{
		transform.Translate (0, sunSpeed, 0);
	}
}
