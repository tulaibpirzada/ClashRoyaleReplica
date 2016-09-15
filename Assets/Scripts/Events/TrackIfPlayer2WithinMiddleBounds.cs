﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrackIfPlayer2WithinMiddleBounds : MonoBehaviour 
{
	void OnTriggerStay2D(Collider2D other) 
	{
		if (GameModel.Instance.IsPlayer2CardReleased)
		{
			other.GetComponent<Rigidbody2D> ().position = GameModel.Instance.Path2ListReversed[0];
			GameModel.Instance.HasPlayer2SelectedPath1 = false;
			GameModel.Instance.HasPlayer2SelectedPath2 = true;
			GameModel.Instance.HasPlayer2SelectedPath3 = false;
			Debug.Log ("Path 2 Reverse Selected");
			GameModel.Instance.IsPlayer2CardReleased = false;
		}
	}
	
}
