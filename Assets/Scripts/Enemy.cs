using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int currentHealthpoints;
    public int maximumHealthpoints;
    public int goldToGive;
    public Image healthBarFill;
    public Animation anim;

    public void Damage()
    {
        currentHealthpoints--;

        healthBarFill.fillAmount = (float) currentHealthpoints/ (float) maximumHealthpoints;

        anim.Stop();
        anim.Play();

        if (currentHealthpoints <= 0) Defeated();
    }

    public void Defeated()
    {
        GameManager.instance.AddGold(goldToGive);
        EnemyManager.instance.DefeatEnemy(gameObject);
    }
}
