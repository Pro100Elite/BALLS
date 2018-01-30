using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {

    public float score;
    public GameObject End;
    public GameObject Win;


    public Text txt;

    void Start () {
        score = 0f;
	}
	

	void Update () {
        txt.text = score.ToString();
        if(score < 0)
        {
            End.SetActive(true);
        }
        if (score > 600)
        {
            Win.SetActive(true);
        }
    }
}
