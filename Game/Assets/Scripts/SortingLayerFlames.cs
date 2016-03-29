using UnityEngine;
using System.Collections;

public class SortingLayerFlames : MonoBehaviour
{

	void Start ()
	{
		GetComponent<ParticleSystem> ().GetComponent<Renderer> ().sortingLayerName = "Player";
	}

}
