using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomizableCharacter : MonoBehaviour
{
    [SerializeField]
    private CustomizedCharacter _character;

    [ContextMenu("Randomize all")]
    public void Randomize()
    {
        var elements = GetComponentsInChildren<CustomizableElement>();
        foreach (var element in elements)
        {
            element.Randomize();
        }
    }
    public void StoreCustomizationInformation()
    {
        var elements = GetComponentsInChildren<CustomizableElement>();
        _character.Data.Clear();
        foreach (var element in elements)
        {
            _character.Data.Add(element.GetCustomizationData());
        }
        SceneManager.LoadScene("Done");
    }
    public void LoadCustomization()
    {
        var elements = GetComponentsInChildren<CustomizableElement>();
        //_character.Data.Clear();
        foreach (var element in elements)
        {
            _character.Data.Add(element.GetCustomizationData());
        }
        SceneManager.LoadScene("CharacterCustomization");
        //SceneManager.LoadScene("Menu");
    }
}
