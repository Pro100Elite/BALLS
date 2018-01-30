using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] Obj;
    public float WaveTime = 0f;
    private float BallsTime = 2f;

	//void Start () {
	//}
	

	void Update () {
        Gener();
    }

    private void Gener()
    {

        int rand = Random.Range(0, Obj.Length);
        WaveTime += Time.deltaTime;
        if (BallsTime <= 0f)
        {
            for (int y = 0; y < 2; y++)
            {
                Instantiate(Obj[rand], new Vector2(Random.Range(-10, 10), gameObject.transform.position.y + Random.Range(0f, -5f)), Obj[rand].transform.rotation);
            }
        }

        if (WaveTime < 40)
        {
            if (BallsTime <= 0f)
            {
                for (int y = 0; y < 5; y++)
                {
                    Instantiate(Obj[rand], new Vector2(Random.Range(-10, 10), gameObject.transform.position.y + Random.Range(0f, -8f)), Obj[rand].transform.rotation);
                }
                BallsTime = 5f;
            }
            else
            {
                BallsTime -= Time.deltaTime;
            }
        }

        if (WaveTime > 40 & WaveTime < 100)
        {
            if (BallsTime <= 0f)
            {
                for (int y = 0; y < 5; y++)
                {
                    Instantiate(Obj[rand], new Vector2(Random.Range(-10, 10), gameObject.transform.position.y + Random.Range(0f, -10f)), Obj[rand].transform.rotation);
                }
                BallsTime = 3f;
            }
            else
            {
                BallsTime -= Time.deltaTime;
            }
        }

        if (WaveTime > 100)
        {
            if (BallsTime <= 0f)
            {
                for (int y = 0; y < 5; y++)
                {
                    Instantiate(Obj[rand], new Vector2(Random.Range(-10, 10), gameObject.transform.position.y + Random.Range(0f, -15f)), Obj[rand].transform.rotation);
                }
                BallsTime = 2f;
            }
            else
            {
                BallsTime -= Time.deltaTime;
            }
        }
    }
}
