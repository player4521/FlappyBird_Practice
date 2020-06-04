using System.Collections.Generic;
using UnityEngine;

public class Manager : Singleton<Manager>
{
    [SerializeField]
    private Bird _bird = null;
    [SerializeField]
    private Ground _ground = null;
    [SerializeField]
    private Pipe _pipe = null;

    [SerializeField]
    private float _speed = 0.001f;

    [SerializeField]
    private float _creatTime = 1.5f;
    [SerializeField]
    private float _pipeRandomHeight = 0.4f;
    [SerializeField]
    private float _pipeRandomPositionY = 0.5f;

    private float _currentTime = 0.0f;

    private List<Pipe> _pipeList = new List<Pipe>();

    private bool _bplay = false;
    private int _score = 0;
    public float Speed { get { return _speed; } }
    public bool IsPlay { get { return _bplay; } set { _bplay = value; } }

    // ゲームが始まった時スクリプト要素を非活性化しても実行
    // 예) 적들의 총알을 초기화
    //void Awake()
    //{
    //    _instance = this;
    //}

    // Awake다음으로 호출, 스크립트요소가 활성화 상태여야 함
    // 예) 적들에게 총을 쏠 능력을 부여
    private void Start()
    {
        //_bplay = true;
    }
    void Update()
    {
        _bird.FreezePositionY(!_bplay);
        if (_bplay)
        {
            // 1.5초마다 파이프 생성
            _currentTime += Time.deltaTime;
            if (_creatTime < _currentTime)
            {
                _currentTime = 0;

                _pipe.SetHeight(Random.Range(0.0f, _pipeRandomHeight));
                _pipe.SetPositionY(Random.Range(0.0f, _pipeRandomPositionY));
                _pipeList.Add(GameObject.Instantiate(_pipe));
            }

            _bird.GameUpdate();
            _ground.GameUpdate();
            _pipeList.ForEach((x) =>
            {
                x.GameUpdate();
                if (x.isNeedInvokeScoreCheck(_bird.transform.position))
                {
                    InvokeScore();
                }
            });
        }
    }

    // 파이프 제거
    public void Remove(Pipe target)
    {
        _pipeList.Remove(target);
        DestroyImmediate(target.gameObject);
    }

    private void InvokeScore()
    {
        _score++;

        Debug.Log(_score);
    }
}
