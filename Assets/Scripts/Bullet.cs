using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Hide", 1);
    }
    void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
