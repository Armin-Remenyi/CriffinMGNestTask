using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    public Button restart;
    public Text win;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        restart.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;

        if (scoreValue >= 30)
        {
            Time.timeScale = 0;
            Win();
        }
        void Win()
        {
            win.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
        }
    }
}
