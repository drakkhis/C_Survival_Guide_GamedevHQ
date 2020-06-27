using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchP1 : MonoBehaviour
{
    private int _weaponID;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _weaponID = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _weaponID = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _weaponID = 3;
        }

        switch (_weaponID)
        {
            case 1:
                Debug.Log("You selected a Gun");
                break;
            case 2:
                Debug.Log("You Selected a Knife");
                break;
            case 3:
                Debug.Log("you selected a MachineGun");
                break;
            default:
                Debug.Log("Invalid Selection");
                break;
        }


    }
}
