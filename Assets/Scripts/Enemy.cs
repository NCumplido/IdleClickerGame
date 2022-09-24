using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int currentHealthpoints;
    public int maximumHealthpoints;
    public int goldToGive;
    public Image healthBarFill;

    public void Damage()
    {
        currentHealthpoints--;

        healthBarFill.fillAmount = (float) currentHealthpoints/ (float) maximumHealthpoints;

        if (currentHealthpoints <= 0) Defeated();
    }

    public void Defeated()
    {
        GameManager.instance.AddGold(goldToGive);
        EnemyManager.instance.DefeatEnemy(gameObject);
    }
}
