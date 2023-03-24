using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceive : DamageReceive
{
    protected PlayerCtrl playerCtrl;

    private void Awake()
    {
        playerCtrl = GetComponent<PlayerCtrl>();
    }

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {
            this.playerCtrl.playerStatus.Dead();
            UIManager.instance.bnGameOver.SetActive(true);
        }
    }
}
