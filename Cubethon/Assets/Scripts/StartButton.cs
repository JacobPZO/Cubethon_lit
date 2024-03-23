using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameManager gameManager;

    private void OnClick()
    {
        gameManager.CompleteLevel();
    }
}
