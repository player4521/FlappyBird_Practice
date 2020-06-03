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

    void Awake()
    {
        _instance = this;
    }

    void Update()
    {

    }
}
