using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points: " + WinCondition.points.ToString();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Collectible"))
        {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            WinCondition.points += 1;
        }
    }
}