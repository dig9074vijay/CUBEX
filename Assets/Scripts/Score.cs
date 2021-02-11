using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    public Text maxScore;
    // Start is called before the first frame update
    void Start()
    {
        maxScore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = player.position.z + 43;
        score.text = distance.ToString("0") ;
        if (distance > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", distance);
            maxScore.text = score.text; ;
        }
        
    }
    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
