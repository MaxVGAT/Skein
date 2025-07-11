using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton instance for global access
    public static GameManager Instance { get; private set; }

    // Variables
    [SerializeField] private Button titleButton;

    public Texture2D customCursor;
    public Vector2 hotspot = Vector2.zero;

    private void Awake()
    {
        // Singleton pattern enforcement
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        Cursor.SetCursor(customCursor, hotspot, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PlayTitleWhisper()
    {
        if (GameManager.Instance == null) return;

        SoundManager.Instance.PlayWakeUpSequence(SoundManager.Instance.titleWhisperSFX, 1f);
        titleButton.interactable = false;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
