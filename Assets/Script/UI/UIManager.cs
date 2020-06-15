using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [SerializeField]
    private GameObject _title = null;
    [SerializeField]
    private GameObject _newBestScore = null;
    [SerializeField]
    private Button _startButton = null;
    [SerializeField]
    private Button _tapButton = null;
    [SerializeField]
    private NumbersRenderer _score = null;
    [SerializeField]
    private GameOverPopup _gameOverPopup = null;
    public int Score
    {
        set
        {
            _newBestScore.SetActive(Manager.Instance.isCurrentBestScore);
            _score.Value = value;
        }
    }

    public void Init()
    {
        _title.gameObject.SetActive(false);
        _startButton.gameObject.SetActive(false);
        _tapButton.gameObject.SetActive(false);
        _score.gameObject.SetActive(false);
        _gameOverPopup.gameObject.SetActive(false);
        _newBestScore.SetActive(false);
    }
    public void ShowTitle()
    {
        _title.gameObject.SetActive(true);
        _startButton.gameObject.SetActive(true);
    }

    public void StartButton()
    {
        ShowTapButton();

        _title.SetActive(false);
        _startButton.gameObject.SetActive(false);
    }

    private void ShowTapButton()
    {
        _tapButton.gameObject.SetActive(true);
    }

    public void TapButton()
    {
        ShowScore();
        Manager.Instance.IsPlay = true;

        // 탭 버튼을 누름과 동시에 사라지게함
        _tapButton.gameObject.SetActive(false);
    }

    public void ShowScore()
    {
        _score.Value = 0;
        _score.gameObject.SetActive(true);
        _newBestScore.SetActive(false);
    }

    public void InvokeGameOver()
    {
        _gameOverPopup.gameObject.SetActive(true);
        _score.gameObject.SetActive(false);
        _newBestScore.SetActive(false);
    }
}
