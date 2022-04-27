using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int score;
    public Text Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Scoretext.text = score.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score ++;
        Scoretext.text = score.ToString();
    }
    
}
