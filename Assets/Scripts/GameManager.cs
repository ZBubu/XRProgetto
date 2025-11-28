using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    [SerializeField]
    private GameObject cilindro;

    private int score=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DestroyUpdateScore()
    {
        score+=1;
        PlayerPrefs.SetInt("scoreValue", score);
        scoreText.text = score+ "";
        Destroy(cilindro);
    }
}
