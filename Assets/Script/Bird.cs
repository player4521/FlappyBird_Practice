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
		// 마우스 왼클릭
        if (Input.GetKeyDown(KeyCode.Space)) {

			// jumpvalue만큼 위로 힘을 가한다
			_rigidbody.AddForce(new Vector2(0, _jumpValue));
		}
	}

	// 적에게 처음 부딫혔을 때 발생하는 함수
    private void OnCollisionEnter2D(Collision2D collision)
    {
		// 부딫혔을 경우 콘솔에 로그 출력
		Debug.Log(collision.gameObject.tag);

        switch (collision.gameObject.tag)
        {
			case "Enemy":
				Manager.Instance.IsPlay = false;
				break;
        }
    }
}
