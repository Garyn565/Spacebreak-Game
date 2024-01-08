using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    void Start()
    {
        // Assuming you want to use a Button component on the GameObject
        Button exitButton = GetComponent<Button>();

        // Add an onClick listener that calls the ExitGame method
        exitButton.onClick.AddListener(ExitGame);
    }

    void ExitGame()
    {
        // Quit the application when the button is clicked
        Application.Quit();

        // Note: Application.Quit() does not work in the Unity Editor
        // It only works in a built application (standalone, mobile, etc.)
    }
}