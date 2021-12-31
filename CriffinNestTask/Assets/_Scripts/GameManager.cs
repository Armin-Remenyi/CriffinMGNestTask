using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOver, Restart;

    // Start is called before the first frame update
    void Start()
    {

        GameOver.gameObject.SetActive(false);
        Restart.gameObject.SetActive(false);
    }
}
