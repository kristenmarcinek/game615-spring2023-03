using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyController : MonoBehaviour
{
    private float time = 0.0f;
    public float jumpTime = 0.5f;
    public float jumpHeight = 0.5f;
    public static float hp = 10f;
    public TextMeshProUGUI healthText;
    public GameObject enemy;
    public static GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + hp.ToString();

        enemy.transform.LookAt(player.transform);

        time += jumpTime;

        if (time >= jumpTime)
        {
            time = time - jumpTime;

            enemy.transform.position += Vector3.up * jumpHeight;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            hp -= 1f;
            //other.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
