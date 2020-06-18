using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager thismanager;
    public Text txt_score;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        thismanager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        score += 1;
        txt_score.text = "Score: " + score;
    }
}
