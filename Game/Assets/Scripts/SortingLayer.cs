using UnityEngine;
using System.Collections;

public class SortingLayer : MonoBehaviour
{

	void Start ()
	{
		GetComponent<ParticleSystem> ().GetComponent<Renderer> ().sortingLayerName = "BG FX";
	}

}
