using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   public void ExitButton(){
    Application.Quit();
  Debug.Log("Game closed");
    }
    public void PlayGame(){
    SceneManager.LoadScene("Game");
    }
}
