﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrackIfPlayer2WithinRightBounds : MonoBehaviour 
{
	void OnTriggerStay2D(Collider2D other) 
	{
		if (other.tag == "Card" && GameModel.Instance.IsPlayer2CardHeld)
		{
//			other.GetComponent<Rigidbody2D> ().position = GameModel.Instance.Path3ListReversed[0];
			GameModel.Instance.HasPlayer2SelectedPath1 = false;
			GameModel.Instance.HasPlayer2SelectedPath2 = false;
			GameModel.Instance.HasPlayer2SelectedPath3 = true;
//			Debug.Log ("Path 3 Reverse Selected");
//			GameModel.Instance.IsPlayer2CardReleased = false;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Card" && GameModel.Instance.IsPlayer2CardHeld) {
			GameModel.Instance.HasPlayer2SelectedPath3 = false;
		}
	}
}
