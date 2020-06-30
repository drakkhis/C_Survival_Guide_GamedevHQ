using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Linq;

public class PoolManager : MonoSingleton<PoolManager>
{
    [SerializeField]
    private List<GameObject> _bulletPool;
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private GameObject _clip;
    public override void Init()
    {
        base.Init();
        _bullet = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Bullet.prefab", typeof(GameObject));
        _clip = transform.Find("Clip").gameObject;
        FillClip(5);

    }

    GameObject FillClip(int clipSize)
    {
        GameObject bullet = default;
        for (int i = 0;i<clipSize;i++)
        {
            bullet = Instantiate(_bullet);
            bullet.transform.parent = _clip.transform;
            _bulletPool.Add(bullet);
            bullet.SetActive(false);
        }
        return bullet;
    }

    public GameObject RequestBullet()
    {
        var bullet = _bulletPool.Where(b => b.activeInHierarchy == false).FirstOrDefault();
        if (bullet != null)
        {
            bullet.SetActive(true);
            return bullet;
        }
        else
        {
            var bullet2 = FillClip(1);
            bullet2.SetActive(true);
            return bullet2;
        }
    }
}
