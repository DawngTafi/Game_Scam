using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameController : MonoBehaviour
{
    public Image winnerAvatar;
    public Image secondPlaceAvatar;
    public Image thirdPlaceAvatar;
    public Image fourthPlaceAvatar;

    void Start()
    {
        Sprite[] rankedAvatars = GameData.Instance.avatarSprites;

        // Gán avatar vào các vị trí tương ứng
        if (rankedAvatars.Length >= 1) winnerAvatar.sprite = rankedAvatars[0];
        if (rankedAvatars.Length >= 2) secondPlaceAvatar.sprite = rankedAvatars[3];
        if (rankedAvatars.Length >= 3) thirdPlaceAvatar.sprite = rankedAvatars[2];
        if (rankedAvatars.Length >= 4) fourthPlaceAvatar.sprite = rankedAvatars[1];
    }

    public void Load()
    {
        SceneManager.LoadScene("PlayGame");
    }

    public void Quit()
    {
        Debug.Log("Quit button clicked!");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Dừng Play Mode
#else
        Application.Quit(); // Thoát ứng dụng
#endif
    }
}
