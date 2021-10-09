using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuManager: MonoBehaviour
{
    public Text Taptext;
    public bool textLoaded;
    public bool startFlashtext;
    private float time;
    private float timer;
    private CanvasGroup trans;
    public Animator OverlayOut;
    public Animator charPicker;
    public Animator titleAnim;

    public void Start()
    {
        textLoaded = true;
        time = 1;
        timer = time;
    }
    public void Update()
    {
        if(textLoaded == true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0 && timer >= -1)
            {
                Taptext.text = "TAP TO START";
            }
            else
            {
                Taptext.text = "";
            }
            if (timer < -1)
            {
                timer = time;
            }
        }
    }
    public void ToGame()
    {
        StartCoroutine(ToGameLoad());
    }
    IEnumerator ToGameLoad()
    {
        hudAnimate();
        OverlayOut.SetBool("FadeOut", true);
        yield return new WaitForSeconds(1.5f);
        Application.LoadLevel("GameScene");
    }
    public void LoadSelect()
    {
        StartCoroutine(ToLoadSelect());
    }
    IEnumerator ToLoadSelect()
    {
        hudAnimate();
        OverlayOut.SetBool("FadeOut", true);
        yield return new WaitForSeconds(1.5f);
        Application.LoadLevel("Selection");
    }
    public void hudAnimate()
    {
        titleAnim.SetBool("titleBool", true);
        charPicker.SetBool("charPickBool", true);
        textLoaded = false;
    }

    

 


}
