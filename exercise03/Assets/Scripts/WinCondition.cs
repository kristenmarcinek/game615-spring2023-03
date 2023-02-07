using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinCondition : MonoBehaviour
{
    public float timer = 30;
    public static float points = 0;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI loseText;

    // Start is called before the first frame update
    void Start()
    {
        loseText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        timerText.text = timer.ToString();

        if (timer <= 0)
        {
            loseText.gameObject.SetActive(true);
        }

        if (EnemyController.hp <= 0)
        {
            loseText.gameObject.SetActive(true);
        }
    }
}
