using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnmySpawner : MonoBehaviour
{
    public GameObject enmyPrefab;
    protected float timer = 0f;
    protected float delay = 2f;

    private void Awake()
    {
        this.enmyPrefab = GameObject.Find("EnmyPrefab");
        this.enmyPrefab.SetActive(false);
    }

    private void Update()
    {
        this.Spawn();
    }

    protected virtual void Spawn()
    {
        if (PlayerCtrl.instance.damageReceive.IsDead()) return;

        this.timer += Time.deltaTime;
        if (this.timer < this.delay) return;
        this.timer = 0;

        GameObject enmy = Instantiate(this.enmyPrefab);
        enmy.transform.position = transform.position;
        enmy.SetActive(true);
    }
}
