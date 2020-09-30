using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButtonBehaviour : MonoBehaviour
{
    // text mesh pro object:
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTestButtonPressed()
    {
        Debug.Log("Test button pressed."); 

        LivesLabel.rectTransform.anchoredPosition = new Vector2(528.0f, -121.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -200.0f);
    }

}
