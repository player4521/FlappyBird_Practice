using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour, IGameObject
{
    [SerializeField]
    private float _startPositionX = 0.0f;
    [SerializeField]
    private float _endPositionX = 0.0f;

    virtual public void GameUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 result = transform.position;
        result.x -= Manager.Instance.Speed;
        if (result.x < _endPositionX)
        {
            FinishEndPosition();
        }
        else
        {
            transform.position = result;
        }
    }

    virtual protected void FinishEndPosition()
    {
        Vector3 result = transform.position;
        result.x = _startPositionX;
        transform.position = result;
    }
}
