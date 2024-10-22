using UnityEngine;

public class CustomizationRandomizer : MonoBehaviour
{
    [ContextMenu("Randomize all")]
    public void Randomize()
    {
        var elements = GetComponentsInChildren<CustomizableElement>();
        foreach (var element in elements)
        {
            element.Randomize();
        }
    }
}
