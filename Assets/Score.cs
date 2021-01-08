using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text txt;
    public float score;
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
    }

    void AddPoint()
    {
        txt = gameObject.GetComponent<Text>();
        score += 10f * Time.deltaTime;
        txt.text = "Score: " + (int)score;
    }
    void Update()
    {
        AddPoint();
    }
}
