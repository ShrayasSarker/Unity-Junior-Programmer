using UnityEngine;
using UnityEngine.UI;   // Needed for UI Text
using TMPro;           // If you’re using TextMeshPro

public class CountdownTimer : MonoBehaviour
{
    [Header("Timer Settings")]
    public float startTime = 60f;     // Countdown start time in seconds
    private float currentTime;

    [Header("UI Reference")]
    public Text timerText;            // For legacy UI Text
    public TextMeshProUGUI timerTMP;  // For TMP (optional)

    [Header("Game Over")]
    public GameObject gameOverPanel;  // Assign your GameOver UI

    private bool isGameOver = false;
    public Button restartButton;
    private GameManagerX gameManagerX;

    void Start()
    {
        currentTime = startTime;
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    void Update()
    {
        if (isGameOver) return;

        // Decrease time
        currentTime -= Time.deltaTime;

        // Clamp to zero (avoid negative display)
        if (currentTime <= 0)
        {
            currentTime = 0;
            TriggerGameOver();
        }

        // Display whole numbers only
        int displayTime = Mathf.RoundToInt(currentTime);

        if (timerText != null) 
            timerText.text = "Time: " + displayTime;

        if (timerTMP != null) 
            timerTMP.text = "Time: " + displayTime;
    }

    void TriggerGameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over!");
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
            restartButton.gameObject.SetActive(true);
            gameManagerX.isGameActive = false;
        // You can also pause the game here if needed
        // Time.timeScale = 0f;
    }
}
