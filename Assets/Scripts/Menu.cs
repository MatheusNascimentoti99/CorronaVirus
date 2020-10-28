using UnityEngine;

public class Menu : MonoBehaviour
{
    public static Menu menu;

    void Awake()
    {
        if (menu == null)
        {
            menu = this;
        }
        else if (menu != this)
        {
            Destroy(gameObject);
        }
    }
    public void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void StartLevel()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void ContinueLevel()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
