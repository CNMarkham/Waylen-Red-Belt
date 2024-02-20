using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blind : MonoBehaviour
{
    public Image image;
    public float alpha=1f;
    
    // Start is called before the first frame update
    void Start()
    {
        image = GameObject.Find("Canvas/Image").GetComponent<Image>();
        //make player blind
        //make colour a 288
        image.color = new Color(1, 1, 1, 1);

}

    // Update is called once per frame
    void Update()
    {
        alpha = image.color.a;
        //make colour a decrease by teeny tiny umpalumpa small amount
        image.color = new Color(1, 1, 1, alpha - 0.0004f);


        //detroy if colourrrrrrrrrrrrrrrrrrrrrrrrrrrr a reaches 00000000000
        if (image.color.a <= (0))
        {
            Destroy(gameObject);
        }
    }
}
