﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MoveObjects
{
    private Vector3 _startPosition = Vector3.zero;

    private void Awake()
    {
        _startPosition = transform.position;
    }

    public void Init()
    {
        transform.position = _startPosition;
    }

    override public void GameUpdate()
    {
        base.GameUpdate();
    }
}
