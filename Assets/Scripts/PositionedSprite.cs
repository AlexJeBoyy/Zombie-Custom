using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[SerializeField]
public class PositionedSprite : CustomizableElement
{
    [field:SerializeField]
    public Sprite Sprite { get;private set; }
    [field: SerializeField]
    public Vector3 PositionModifier { get; set; }
}
