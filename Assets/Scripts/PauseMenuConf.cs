using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenuConf : MonoBehaviour
{
    [SerializeField] private GameObject PauseBtn;
    [SerializeField] private GameObject PauseMenu;

   public void Pause()
   {
    Time.timeScale = 0f;
    PauseBtn.SetActive(false);
    PauseMenu.SetActive(true);
   }

   public void Resume()
   {
    Time.timeScale = 1f;
    PauseBtn.SetActive(true);
    PauseMenu.SetActive(false);
   }
   public void Restart()
   {
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    PauseBtn.SetActive(true);
    PauseMenu.SetActive(false);
   }
   
   public void Quit()
   {
    Debug.Log("Game Closed");
    Application.Quit();
   }
}
