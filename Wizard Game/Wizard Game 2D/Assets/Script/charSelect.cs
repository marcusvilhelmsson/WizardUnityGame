using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charSelect : MonoBehaviour
{
    public Animator backgroundAnim;
    public Image im;
    public CanvasGroup CanvasGroup;
    public Rigidbody2D BottomButtons;
    public Rigidbody2D ArrowLeft;
    public Rigidbody2D ArrowRight;
    public float speed = 10f;
    // Start is called before the first frame update

    private void Awake()
    {
        CanvasGroup = GetComponent<CanvasGroup>();
    }
    public void Start()
    {
        backgroundAnim.SetBool("FadeOut", true);

    }
    // Update is called once per frame
    public void Update()
    {

    }

}