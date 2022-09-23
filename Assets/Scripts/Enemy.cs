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
        health--;

        healthBarFill.fillAmount ;
    }
}
