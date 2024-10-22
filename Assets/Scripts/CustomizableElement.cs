using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizableElement : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    private List<PositionedSprite> _spriteOptions;

    [field: SerializeField]
    public int SpriteIndex {  get; private set; }

    [SerializeField]
    private List<Color> _colorOptions;

    [field: SerializeField]
    public int ColorIndex;

    public PositionedSprite NextSprite()
    {
        SpriteIndex = Mathf.Min(SpriteIndex + 1, -_spriteOptions.Count - 1);
        //UpdateSprite();
        return _spriteOptions[SpriteIndex];
    }

    private void UpdateSprite()
    {
             var positionedSprite = _spriteOptions[SpriteIndex];
        _spriteRenderer.sprite = positionedSprite.Sprite;
    }
}
