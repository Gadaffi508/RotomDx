using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;

public class GameManager : MonoBehaviour
{
    public Text Text;
    PlayerHealth plHealth;
    private void Start()
    {
        plHealth = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerHealth>();
    }
    private void FixedUpdate()
    {
        Text.text=" Health : " + plHealth.health.ToString();
    }
}
