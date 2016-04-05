using UnityEngine;
using System.Collections;

public class MeteorExplosion : MonoBehaviour
{
	public void Start ()
	{
		StartCoroutine (WaitForDestroy ());
	}

	IEnumerator WaitForDestroy()
	{
		yield return new WaitForSeconds (2);
		Destroy (this.gameObject);
	}
}
