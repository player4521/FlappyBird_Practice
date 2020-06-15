using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MoveObjects
{
    [SerializeField]
    private GameObject _pipeTop = null;

    private float _defaultPipePositionY = 0.0f;
    private float _defaultBasePositionY = 0.0f;

    private bool _bCheck = false;

    private void Start()
    {
        _defaultPipePositionY = _pipeTop.transform.localPosition.y;
        _defaultBasePositionY = transform.position.y;
    }

    public void SetHeight(float value)
    {
        Vector3 result = _pipeTop.transform.localPosition;
        result.y = value + _defaultPipePositionY;

        _pipeTop.transform.localPosition = result;
    }

    public void SetPositionY(float value)
    {
        Vector3 result = transform.position;
        result.y = value + _defaultPipePositionY;

        transform.position = result;
    }

    override public void GameUpdate()
    {
        base.GameUpdate();
    }

    override protected void FinishEndPosition()
    {
        Manager.Instance.Remove(this);
    }

    /// <summary>
    /// Bird 와 위치를 검사하는 처리
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool IsNeedInvokeScoreCheck(Vector3 target)
    {
        if (!_bCheck)
        {
            if (transform.position.x <= target.x)
            {
                _bCheck = true;
                return true;
            }
        }
        return false;
    }
}
