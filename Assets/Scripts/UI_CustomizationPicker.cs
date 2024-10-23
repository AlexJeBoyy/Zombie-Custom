using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_CustomizationPicker : MonoBehaviour
{
    [SerializeField]
    private CustomizableElement _customizableElement;

    [SerializeField]
    private Button _previousSpriteButton;

    [SerializeField]
    private Button _nextSpriteButton;

    [SerializeField]
    private Button _previousColorButton;

    [SerializeField]
    private Button _nextColorButton;

    [SerializeField]
    private TMP_Text _spriteID;

    [SerializeField]
    private Image _colorIcon;

    private void Start()
    {
        UpdateSpriteID();
        

        _previousSpriteButton.onClick.AddListener(() =>
            {
                _customizableElement.PreviousSprite();
                UpdateSpriteID();
            });
        _nextSpriteButton.onClick.AddListener(() =>
        {
            _customizableElement.NextSprite();
            UpdateSpriteID();
        });

        if (_colorIcon != null)
        {
            UpdateColorIcon();

            _previousColorButton.onClick.AddListener(() =>
            {
                _customizableElement.PreviousColor();
                UpdateColorIcon();
            });
            _nextColorButton.onClick.AddListener(() =>
            {
                _customizableElement.NextColor();
                UpdateColorIcon();
            });
        }
    }
    private void UpdateSpriteID()
    {
        _spriteID.SetText(_customizableElement.SpriteIndex.ToString().PadLeft(2, '0'));
    }
    private void UpdateColorIcon()
    {
        _colorIcon.color = _customizableElement.CurrentColor;
    }
}
