using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drunking : MonoBehaviour
{
   [SerializeField] private Sprite spr, spr1, spr2, spr3;
    public GameObject img;

    // Start is called before the first frame update
    void Start()
    {
        img = GameObject.Find("ClassImage");
        spr = img.GetComponent<SpriteRenderer>().sprite;
        spr1 = Resources.Load<Sprite>("not");
        spr2 = Resources.Load<Sprite>("drink");
        spr3 = Resources.Load<Sprite>("drunk");

        //условие для замены спрайта

        /* if (GameManager.sliderAlcohol.value < 20) {
             img.GetComponent<SpriteRenderer>().sprite = spr1;
         }
         if (GameManager.sliderAlcohol.value < 50) {
                 img.GetComponent <SpriteRenderer> ().sprite = spr2;
             }
             else img.GetComponent<SpriteRenderer>().sprite = spr3;*/
    }
}
