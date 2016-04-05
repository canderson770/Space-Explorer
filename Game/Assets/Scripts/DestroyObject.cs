using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour
{
	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.name == "floor") 
		{
			Destroy (this.gameObject);
		}
	}
}
