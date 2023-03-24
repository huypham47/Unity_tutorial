using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public PlayerCtrl instance;

    public DamageReceive damageReceive;
    public PlayerStatus playerStatus;

    private void Awake()
    {
        PlayerCtrl.instance = this;

        this.damageReceive = GetComponent<DamageReceive>();
        this.playerStatus = GetComponent<PlayerStatus>();
    }
}
