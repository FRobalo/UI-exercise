using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinCounterText;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        slider.maxValue = player.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = player.health;
        coinCounterText.text = player.coins.ToString();
    }
}
