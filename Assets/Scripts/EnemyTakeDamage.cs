using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    [SerializeField] private GameObject boolshit;
    private void OnMouseDown()
   {
      gameObject.tag = "target";
      EVENT.ZvonokSobitie(1);
      gameObject.tag = "no";
        Instantiate(boolshit, transform.position, Quaternion.identity);
    }
}
