using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class DoTweenDeathText : MonoBehaviour
{
    public Text LastWord;
    public RectTransform exitButton;
    private void Start() 
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;            
        Sequence seq = DOTween.Sequence();

        seq.Append(LastWord.DOText("You lost your all motivation. You don't want to try anymore. And you close the game...", 8f)
        .SetDelay(1f));
        seq.Append(exitButton.DOScale(Vector3.zero, 5f).From());
    }
    private void OnEnable() 
    {

    }
    
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
