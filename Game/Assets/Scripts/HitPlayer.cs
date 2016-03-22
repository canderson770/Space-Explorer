using UnityEngine;
using System.Collections;

public class HitPlayer : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D hit) 
	{
		if (hit.gameObject.name == "player")
			this.gameObject.SetActive (false);
	}
}
