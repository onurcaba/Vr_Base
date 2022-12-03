using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Obi;

public class CraneController : MonoBehaviour {

	ObiRopeCursor cursor;
	ObiRope rope;

	// Use this for initialization
	void Start () {
		cursor = GetComponentInChildren<ObiRopeCursor>();
		rope = cursor.GetComponent<ObiRope>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Keyboard.current[Key.W].IsPressed()){
			if (rope.restLength > 6.5f)
				cursor.ChangeLength(rope.restLength - 1f * Time.deltaTime);
		}

		if (Keyboard.current[Key.S].IsPressed())
		{
			cursor.ChangeLength(rope.restLength + 1f * Time.deltaTime);
		}

		if (Keyboard.current[Key.A].IsPressed())
		{
			transform.Rotate(0,Time.deltaTime*15f,0);
		}

		if (Keyboard.current[Key.D].IsPressed())
		{
			transform.Rotate(0,-Time.deltaTime*15f,0);
		}
	}
}
