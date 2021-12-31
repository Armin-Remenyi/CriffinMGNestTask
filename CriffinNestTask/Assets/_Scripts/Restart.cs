using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    void Start()
    {
        UnlockMouse();
    }
    
    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void RestartGame()
    {
        Debug.Log("Restart");
        //SceneManager.LoadScene("MachineGunNest");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
