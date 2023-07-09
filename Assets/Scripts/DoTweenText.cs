using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class DoTweenText : MonoBehaviour
{
    public Text LastWord;
    public RectTransform exitButton;
    public AudioClip catSound;
    private AudioSource audioSource;
    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Sequence seq = DOTween.Sequence();
        
        seq.Append(LastWord.DOText("You got a paper cat! You should be happy. You feel very motivated. :3", 7f)
        .SetDelay(1f));
        seq.Append(exitButton.DOScale(Vector3.zero, 4f).From());   
    }


    public void Exit()
    {
        audioSource.PlayOneShot(catSound); 
        Application.Quit();
        Debug.Log("Quit!");
    }
}
