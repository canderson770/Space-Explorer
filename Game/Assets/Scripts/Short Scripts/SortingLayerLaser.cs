using UnityEngine;
using System.Collections;

public class SortingLayerLaser : MonoBehaviour
	{
		void Start ()
		{
			GetComponent<MeshRenderer> ().sortingLayerName = "Player";
		}

	}
