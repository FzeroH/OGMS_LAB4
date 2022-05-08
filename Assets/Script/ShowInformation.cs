using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInformation : MonoBehaviour
{
    public GameObject information;
	// Start is called before the first frame update
	void OnEnable()
	{
		Lean.Touch.LeanTouch.OnFingerTap += HandleFingerTap;
	}

	void OnDisable()
	{
		Lean.Touch.LeanTouch.OnFingerTap -= HandleFingerTap;
	}

	void HandleFingerTap(Lean.Touch.LeanFinger finger)
	{
		Debug.Log("You just tapped the screen with finger " + finger.Index + " at " + finger.ScreenPosition);
	}
}
