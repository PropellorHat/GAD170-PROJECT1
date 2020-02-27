using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public float spinSpeed = 100f;
    public int scoreToAdd;
    static int score;

    private Text scoreText;
    public PlayerController playerScript;

    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("scoreText").GetComponent<Text>();
        score = 0;
    }
    void Update()
    {
        this.transform.Rotate(0f, Time.deltaTime * this.spinSpeed, 0f);
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerScript.GainXP(scoreToAdd);
            score += scoreToAdd;
            Destroy(this.gameObject);
        }
    }
}
