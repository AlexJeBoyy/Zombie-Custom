using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadCharacter()
    {
        SceneManager.LoadScene("CharacterCustomization");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
