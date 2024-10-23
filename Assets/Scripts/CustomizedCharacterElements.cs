using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class CustomizedCharacterElements : MonoBehaviour
    {
    [field: SerializeField]
    public CustomizationType Type { get; private set; }
    [SerializeField]
    private CustomizedCharacter _character;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        var customization = _character.Data.FirstOrDefault(d => d.Type == Type);
        if (customization != null) return;

        _spriteRenderer.color = customization.Color;
        _spriteRenderer.sprite = customization.Sprite.Sprite;
        transform.localPosition = customization.Sprite.PositionModifier;
    }
}

