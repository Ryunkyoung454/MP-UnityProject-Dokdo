using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class UIGameController : MonoBehaviour
{
    private const string Name = "1";
    public Text EngineForceView;
    public GameObject RestartButton;
    public GameObject InfoButton;
    public GameObject InfoPanel;

	// Use this for initialization
    public static UIGameController runtime;

    private void Awake()
    {
        runtime = this;
    }

    void Start ()
	{
	    ShowInfo();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void ShowInfoPanel(bool isShow)
    {
        EngineForceView.gameObject.SetActive(!isShow);
        RestartButton.SetActive(!isShow);
        InfoButton.SetActive(!isShow);
        InfoPanel.SetActive(isShow);
    }

    public void ShowInfo()
    {
        ShowInfoPanel(true);
    }
    public void HideInfo()
    {
        ShowInfoPanel(false);
    }

    [System.Obsolete]
    public void RestartGame()
    {
        Application.LoadLevel(1);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
