using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int coins = 0;
    public float health = 100;

    private void Awake()
    {
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
}
