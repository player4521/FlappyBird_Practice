using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour,IGameObject
{
    [SerializeField]
    private float _startPositionX = 0.05f;
    [SerializeField]
    private float _endPositionX = -0.014f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GameUpdate()
    {
        Vector3 position = transform.position;
        position.x -= Manager.Instance.speed;
        if (position.x < _endPositionX)
        {
            position.x = _startPositionX;
        }
        transform.position = position;
    }
}
