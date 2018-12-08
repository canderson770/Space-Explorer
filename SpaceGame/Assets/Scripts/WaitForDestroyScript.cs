using UnityEngine;
using System.Collections;

public class WaitForDestroyScript : MonoBehaviour
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
