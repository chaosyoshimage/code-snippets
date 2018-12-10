using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthDisplay : MonoBehaviour
{

    private Transform childText;
    private TextMesh healthText;

    // Use this for initialization
    void Start()
    {

        childText = transform.GetChild(0);
        healthText = childText.GetComponent<TextMesh>();
        healthText.text = "Welcome!\n" +
            "\n" +
            "Touch Scroll To Start\n" +
            "\n" +
            "Use Books to Summon";
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.hasGameStarted && !GameController.isGameOever)
        healthText.text = "Boss Health : " + GameController.bossHealth.ToString();

        if (GameController.playerHealth <= 0)
            healthText.text = "You don' goofed >:(";


    }
}
