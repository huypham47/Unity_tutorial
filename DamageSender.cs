using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    public EnmyCtrl enmyCtrl;

    private void Awake()
    {
        this.enmyCtrl = GetComponent<EnmyCtrl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        DamageReceive damageReceive = collision.GetComponent<DamageReceive>();
        damageReceive.Receive(1);

        this.enmyCtrl.despawner.Despawn();
    }
}
