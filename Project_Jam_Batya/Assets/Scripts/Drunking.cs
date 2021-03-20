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
        Debug.Log(spr);
 
        if (spr = spr3) {
            img.GetComponent<SpriteRenderer>().sprite = spr1;
        }
        if (spr = spr1) {
                img.GetComponent <SpriteRenderer> ().sprite = spr2;
            }
            else img.GetComponent<SpriteRenderer>().sprite = spr3;
    }
}
