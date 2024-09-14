using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasObjelerim : MonoBehaviour
{
    public Slider benim_slider;
    public Image benim_image;
    // public Text benim_text;
    // Text text;
    // Start is called before the first frame update
    void Start()
    {

        // benim_image.fillAmount = .5f;

        // text = GetComponentInChildren<Text>();
        // text.text = "Samlare";
        // benim_text.text = "Selamlar";
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.D))
        // {
        //     benim_image.fillAmount -= .1f;
        // }
    }
    public void ReduceHealth(float health)
    {
        benim_image.fillAmount -= health;
    }
    public void Write(string value)
    {
        print(value);
    }
    public void SliderDeneme()
    {
        print(benim_slider.value);
    }
}
