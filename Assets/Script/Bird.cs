using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour,IGameObject {

	[SerializeField]
	private Rigidbody2D _rigidbody = null;

	[SerializeField]
	private float _jumpValue = 1.0f;

	void Start () {
		
	}
	public void GameUpdate()
	{
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
			_rigidbody.AddForce(new Vector2(0, _jumpValue));
		}
	}

}
