using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSpot : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        SceneManager.LoadScene("WonScene");
    }
}
