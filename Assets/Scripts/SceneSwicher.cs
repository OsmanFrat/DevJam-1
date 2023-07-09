using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwicher : MonoBehaviour
{

    public AudioClip catSound;
    private AudioSource audioSource;
    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }
    public void Play()
    {
        SceneManager.LoadScene("NormalLvl");
    }

    public void PlayCatSound()
    {
        audioSource.PlayOneShot(catSound); 
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
