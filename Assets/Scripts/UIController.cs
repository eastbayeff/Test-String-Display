using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Item mainHand;
    public Item offHand;

    public Text descriptionText;
    public Text nameText;

    private bool usingMainHand = true;

    public void Swap()
    {
        if (usingMainHand)
        {
            nameText.text = offHand.data.itemName;
            descriptionText.text = Regex.Unescape(offHand.data.itemDescription);
            usingMainHand = false;
        }
        else
        {
            nameText.text = mainHand.data.itemName;
            descriptionText.text = Regex.Unescape(mainHand.data.itemDescription);
            usingMainHand = true;
        }
    }
}
