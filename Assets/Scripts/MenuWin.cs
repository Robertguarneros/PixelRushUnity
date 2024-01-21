using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuWin : MonoBehaviour
{
    [SerializeField] private GameObject WinMenu;
    // Start is called before the first frame update
    public void Restart()
   {
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    WinMenu.SetActive(false);
   }
}
