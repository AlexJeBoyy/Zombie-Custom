using UnityEngine;
using System;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
public class UI_Customization : MonoBehaviour
{
    private List<UI_CustomizationPicker> _pickers;
    
    void Start()
    {
        _pickers = GetComponentsInChildren<UI_CustomizationPicker>().ToList();
    }

    public void UpdatePickersState()
    {
        _pickers.ForEach(pickers =>
        {
            pickers.UpdateSpriteID();
            pickers.UpdateColorIcon();
        });
    }
}
