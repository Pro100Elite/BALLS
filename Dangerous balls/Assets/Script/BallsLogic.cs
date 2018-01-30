using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsLogic : MonoBehaviour {

    public Vector3 value = new Vector3 (0, 2f, 0);
    public GameObject DeadEf;
    private ScoreSystem Sc;
    private Spawner Sp;

    void Update () {
        Sc = FindObjectOfType<ScoreSystem>();
        Sp = FindObjectOfType<Spawner>();
        Dead();
        SpeedBall();
    }

    void OnMouseDown()
    {

        switch(tag)
        {
            case "+5":
                Destroy(gameObject);
                GameObject Ef = Instantiate(DeadEf, gameObject.transform.position, Quaternion.identity) as GameObject;
                Destroy(Ef, 1.5f);
                Sc.score += 5f;
                break;

            case "-15":
                Destroy(gameObject);
                GameObject Ef1 = Instantiate(DeadEf, gameObject.transform.position, Quaternion.identity) as GameObject;
                Destroy(Ef1, 1.5f);
                Sc.score -= 15f;
                break;
        }
    }

    void Dead()
    {
        if(transform.position.y > 7)
        {
            Destroy(gameObject);
            if (gameObject.tag == "+5")
            {
                Sc.score -= 5f;
            }
        }
    }

    void SpeedBall()
    {
        transform.Translate(value * Time.deltaTime);
        if (Sp.WaveTime > 22 & Sp.WaveTime < 80)
        {
            value = new Vector3(0, 3f, 0);
        }
        if (Sp.WaveTime > 80)
        {
            value = new Vector3(0, 4f, 0);
        }
    }
}


