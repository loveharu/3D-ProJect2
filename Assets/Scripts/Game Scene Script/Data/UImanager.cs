using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Data;

public class UImanager : MonoBehaviour
{


    [SerializeField] private TMP_Text playerHp;
    [SerializeField] private TMP_Text playerMp;
    [SerializeField] private Image hpBar;
    [SerializeField] private Image mpBar;

    public TMP_Text PlayerLevel;
    public TMP_Text PlayerExp;
    
    private void Awake()
    {

    }

    private void Start()
    {
        
    }
    private void Update()
    {
        UpdatePlayerHp();
    }
    public void UpdatePlayerHp()
    {
        hpBar.fillAmount = (float)PlayerHealth.currentHealth / PlayerHealth.currentHealth;
        playerHp.text = PlayerHealth.currentHealth + "/" + PlayerHealth.maxHealth;
    }

    public void UpdatePlayerMp(PlayerStat playerStat)
    {
        //mp아직 없음
    }

    public void UpdateEnemyHp(EnemyStat enemyStat)
    {
        hpBar.fillAmount = (float)enemyStat.EnemyHealth / enemyStat.Health;
    }
}
