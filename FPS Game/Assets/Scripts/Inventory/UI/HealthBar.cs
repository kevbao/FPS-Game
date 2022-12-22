using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fill;
    public float maxHp;
    public float curHp;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        fill.fillAmount = curHp;

    }
    public void SetMaxHealth(float health)
    {
        fill.fillAmount = maxHp;
        //Image.fillMethod
    }
    public void SetHealth(float health)
    {
        fill.fillAmount = health;
        //fill.color = gradient.Evaluate(1f);

    }
}
