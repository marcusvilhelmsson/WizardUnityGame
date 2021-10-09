using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coolDown : MonoBehaviour
{
    public Image fillImg;
    float timeAmt = 0.5f;
    float time;
    public bool cooldown;

    // Start is called before the first frame update
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
    }
    private void Update()
    {
        if (time > 0 && cooldown == true)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time/timeAmt;
        }
        if (fillImg.fillAmount == 0)
        {
            fillImg.fillAmount = 1;
            time = timeAmt;
            cooldown = false;

        }
    } 

}
