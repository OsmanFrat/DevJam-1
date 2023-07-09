using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int motivation = 3; 
    public int currentMotivation; 
    private GameObject player;
    public Transform respawn;
    public GameObject threeMotivationPanel;
    public GameObject twoMotivationPanel;
    public GameObject oneMotivationPanel;
    public GameObject zeroMotivationPanel;   
    public bool paused;
    public GameObject pausePanel;
    public Vector3 finishSpot = new Vector3(115f,176f,0f);

    private void Start()
    {
        Time.timeScale = 1;
        paused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        threeMotivationPanel.SetActive(true);
        currentMotivation = motivation;
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ChangePaused();
        } 
   
        if (player.transform.position.y < -4f)
        {
            TakeDamage(1);
            player.transform.position = respawn.transform.position;
        }
        if(currentMotivation == 2)
        {
            threeMotivationPanel.SetActive(false);
            twoMotivationPanel.SetActive(true);
        }
        else if(currentMotivation == 1)
        {
            twoMotivationPanel.SetActive(false);
            oneMotivationPanel.SetActive(true);
        }
        else if(currentMotivation == 0)
        {
            oneMotivationPanel.SetActive(false);
            zeroMotivationPanel.SetActive(true);
            Die();
        }
    }

    private void TakeDamage(int damageAmount)
    {
        currentMotivation -= damageAmount; 
        Debug.Log(currentMotivation);
        if (currentMotivation <= 0)
        {
            Die();
        }
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
    public void Die()
    {
        SceneManager.LoadScene("DeathScene");
        Debug.Log("Player Died.");
    }

       public void Continue()
    {
        pausePanel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    void ChangePaused()
    {
        
        if (!paused)
        {
            paused = true;
            pausePanel.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //savedVolume = AudioListener.volume;
            //AudioListener.volume = 0;
            Time.timeScale = 0;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            paused = false;
            pausePanel.SetActive(false);
            //AudioListener.volume = savedVolume;
            Time.timeScale = 1;

        }
    }

}
