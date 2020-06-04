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
    private Button _startButton = null;
    [SerializeField]
    private Button _tapButton = null;

    public void StartButton()
    {
        ShowTapButton();

        _title.SetActive(false);
        _startButton.gameObject.SetActive(false);
    }

    public void TapButton()
    {
        ShowScore();
        Manager.Instance.IsPlay = true;

        // 탭 버튼을 누름과 동시에 사라지게함
        _tapButton.gameObject.SetActive(false);
    }

    private void ShowTapButton()
    {
        _tapButton.gameObject.SetActive(true);
    }

    private void ShowScore()
    {

    }
}
