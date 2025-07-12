using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public GameObject gameOverPanel;   // Arrastra aquí tu GameOverPanel
    public Text scoreText;             // Arrastra aquí tu Text de Score
    public Text highScoreText;         // Arrastra aquí tu Text de High Score
    public Button retryButton;         // Arrastra aquí tu botón Retry

    void Awake()
    {
        // ─── Singleton ───
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // ─── Forzar orientación Landscape y bloquear Portrait ───
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
    }

    void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }

    void Start()
    {
        // Aseguramos que el panel de Game Over empiece oculto
        gameOverPanel.SetActive(false);

        // Configuramos el listener del botón Retry
        retryButton.onClick.RemoveAllListeners();
        retryButton.onClick.AddListener(RestartGame);
    }

    /// <summary>
    /// Llama a este método desde tu BirdScript pasando el score final.
    /// </summary>
    public void GameOver(int finalScore)
    {
        // Pausamos el juego
        Time.timeScale = 0f;

        // Mostramos el panel
        gameOverPanel.SetActive(true);

        // Mostramos el score
        scoreText.text = "Score: " + finalScore;

        // Guardamos y mostramos el High Score
        int hs = PlayerPrefs.GetInt("HighScore", 0);
        if (finalScore > hs)
        {
            hs = finalScore;
            PlayerPrefs.SetInt("HighScore", hs);
            PlayerPrefs.Save();
        }
        highScoreText.text = "High Score: " + hs;
    }

    void RestartGame()
    {
        // Reactivamos el tiempo y recargamos la escena
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
