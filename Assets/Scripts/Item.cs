using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string _itemName = "Sword";
    public string _itemDescription = "This is a Sword.";
    public Sprite _icon;
    public int _attackSrength;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name:  " +_itemName);
        Debug.Log("Description: " + _itemDescription);
        Debug.Log("Attack Strength: " + _attackSrength);

    }
}
