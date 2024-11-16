using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public TextMeshProUGUI mylabel;
    public Sprite F1;
    public Sprite F2;
    public Sprite F3;
    public Sprite F4;
    public Sprite F5;
    public Button Hamster;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
    }

    // Update is called once per frame
    public void BPr()
    {
        num += 1;
        mylabel.GetComponent<TextMeshProUGUI>().text = $"{num}";
        if (num == 100) 
        {
            Hamster.GetComponent<Image>().sprite = F1;
        }
        if (num == 200)
        {
            Hamster.GetComponent<Image>().sprite = F2;
        }
        if (num == 300)
        {

            Hamster.GetComponent<Image>().sprite = F3;
        }
        if (num == 400)
        {
            Hamster.GetComponent<Image>().sprite = F4;
        }
        if (num == 500)
        {

            Hamster.GetComponent<Image>().sprite = F5;
        }
    }
}
