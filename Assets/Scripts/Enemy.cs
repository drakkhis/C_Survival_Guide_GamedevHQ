using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy.asset", menuName = "Enemy")]
public class Enemy : ScriptableObject
{
    public string enemyName;
    public int enemyHealth;
    public float enemySpeed;
    public GameObject mesh;
}
