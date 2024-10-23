using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class CustomizedCharacter : ScriptableObject
{
    [field: SerializeField]
    public List<CustomizationData> Data { get; private set; }

}
