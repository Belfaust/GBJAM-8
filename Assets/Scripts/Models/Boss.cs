﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private int HP = 500;
    public int HitPoints { get => HP; set { int OldHP = HP; HP = value; HPCheck(); } }
    public int MaxEnergy = 100;
    public static int Energy = 0;
    public bool Cooldown = false;
    public float Speed;
    public Vector3 Dest;


    public void HPCheck()
    {
        if(HitPoints < 1)
        {
            transform.gameObject.SetActive(false);
            if(gameController.Instance.BossCount == 1)
            {
                CameraController.Instance.IndicatorOn = false;
                gameController.Instance.LevelIndex += 1;
                Instantiate(gameController.Instance.ShopHole,transform.position,Quaternion.identity);
            }
            else
            {
                gameController.Instance.BossCount -= 1;
            }
        }
    }


}
