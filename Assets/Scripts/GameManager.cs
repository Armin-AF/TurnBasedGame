using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton pattern for easy global access
    public static GameManager Instance;

    void Awake()
    {
        // Ensure only one instance exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Debug.Log("Game Manager Initialized");
    }

    void Update()
    {
        // Placeholder for future game logic
    }
}