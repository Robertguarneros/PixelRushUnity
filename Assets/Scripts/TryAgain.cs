using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TryAgain : MonoBehaviour
{
    [SerializeField] private GameObject DeadMenu;
    // Start is called before the first frame update
    public void Restart()
   {
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    DeadMenu.SetActive(false);
   }
   public void Quit()
   {
    Debug.Log("Game Closed");
    Application.Quit();
   }
}
