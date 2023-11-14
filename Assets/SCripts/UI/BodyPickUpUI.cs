using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BodyPickUpUI : MonoBehaviour
{
    private TextMeshProUGUI counterText;
    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
    }
    public void UpdateCounterText(PlayerInventory playerInventory)
    {
        counterText.text = "Body Parts Collectd:"  + playerInventory.NumberOfBodyParts.ToString();
    }

}