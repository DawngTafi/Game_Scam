using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance;

    // Lưu sprite avatar theo thứ tự người chơi
    public Sprite[] avatarSprites;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Giữ đối tượng này khi chuyển scene
        }
        else
        {
            Destroy(gameObject); // Tránh tạo nhiều instance
        }
    }
}
