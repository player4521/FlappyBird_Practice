using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private static Manager _instance = null;
    public static Manager Instance { get { return _instance; } }

    [SerializeField]
    private Bird _bird = null;
    [SerializeField]
    private Ground _ground = null;
    [SerializeField]
    private Pipe _pipe = null;
    
    [SerializeField]
    private float _speed = 0.001f;


    private bool _bplay = false;

    public float speed { get { return _speed; } }

    void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _bplay = true;
    }
    void Update()
    {
        if (_bplay)
        {
            _bird.GameUpdate();
            _ground.GameUpdate();
            _pipe.GameUpdate();
        }
    }
}
