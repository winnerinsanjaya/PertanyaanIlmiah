using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    private int health;
    private int score;

    public TMP_Text healthText;
    public TMP_Text scoreText;


    public List<int> LevelLeft;

    public List<GameObject> Border;

    public GameObject winPanel;
    public GameObject losePanel;
    public List<GameObject> LevelCompletePanel;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        OnStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnStart()
    {
        AudioPlayer.instance.PlayBGM(1);
        health = 5;
        score = 0;

        UpdateText();
    }
    public void Wrong()
    {
        health -= 1;
        UpdateText();
    }

    public void Correct(int idx)
    {
        LevelLeft[idx] -= 1;
        score += 10;
        UpdateText();
    }

    private void UpdateText()
    {



        scoreText.text = "Score : " + score.ToString();
        healthText.text = "Health : " + health.ToString();

        if (LevelLeft[0] <= 0)
        {
            QuizManager.instance.isOnQUiz = true;
            LevelCompletePanel[0].SetActive(true);
            Border[0].SetActive(false);
        }

        if (LevelLeft[1] <= 0)
        {
            QuizManager.instance.isOnQUiz = true;
            LevelCompletePanel[1].SetActive(true);
            Border[1].SetActive(false);
        }
        if (LevelLeft[2] <= 0)
        {
            QuizManager.instance.isOnQUiz = true;
            LevelCompletePanel[2].SetActive(true);
            Border[2].SetActive(false);
        }

        if (LevelLeft[3] <= 0)
        {
            SetWin();
        }

        if (health <= 0)
        {
            SetLose();
        }
    }

    private void SetLose()
    {
        Debug.Log("Lose");
        QuizManager.instance.isOnQUiz = true;
        losePanel.SetActive(true);
    }
    private void SetWin()
    {
        Debug.Log("Win");
        QuizManager.instance.isOnQUiz = true;
        winPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        AudioPlayer.instance.PlaySFX(4);
        QuizManager.instance.isOnQUiz = false;

        LevelCompletePanel[0].SetActive(false);
        LevelCompletePanel[1].SetActive(false);
        LevelCompletePanel[2].SetActive(false);
    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void SetOnQuiz(bool isTrue)
    {
        QuizManager.instance.isOnQUiz = isTrue;
    }
}
