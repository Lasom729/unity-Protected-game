using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public static UI instance;

    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI killCountText;
   
    private int killCount;
    private float playTime;
    
    private void Awake()
    {
        instance = this;
        Time.timeScale = 1;
    }

    private void Update()
    {
        playTime += Time.deltaTime;
        timerText.text = playTime.ToString("F2") + "s";
    }

    public void EnableGameOverUI()
    {
        Time.timeScale = .5f;
        gameOverUI.SetActive(true);
    }

    public void RestartLevel()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }

    public void AddKillCount()
    {
        killCount++;
        killCountText.text = killCount.ToString();
    }
}

