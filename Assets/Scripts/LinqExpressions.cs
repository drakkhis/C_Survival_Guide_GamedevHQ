using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Experimental.Rendering;

[System.Serializable]
public class Item
{
    public string name;
    public int ID;
    public int buff;


}

public class LinqExpressions : MonoBehaviour
{
    public Item[] Items;

    // Start is called before the first frame update
    void Start()
    {
        var isInInventory = Items.Any(i => i.ID == 3);
        Debug.Log(isInInventory);
        var highBuffs = Items.Where(i => i.buff > 20);
        foreach(Item i in highBuffs)
        {
            Debug.Log(i.name);
        }
        var buffAverage = Items.Average(n => n.buff);
        Debug.Log("Average of all Buffs is: " + buffAverage);
    }

}
