using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem2 : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

    private void OnTriggerEnter(Collider coin)
    {
        if (coin.tag == "coin")
        {
            ScoreNum += 10;
            Destroy(coin.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }
        else if (coin.tag == "diamond")
        {
            ScoreNum += 50;
            Destroy(coin.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }
        else if (coin.tag == "enemy")
        {
            Destroy(coin.gameObject);
            SceneManager.LoadScene("GameOver1");
        }
        else if (coin.tag == "water")
        {
            Destroy(coin.gameObject);
            SceneManager.LoadScene("GameOver1");
        }

    }

}

