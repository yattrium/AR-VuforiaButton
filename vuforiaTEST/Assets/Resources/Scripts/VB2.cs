using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vuforia;

public class VB2 : MonoBehaviour
{

    public static string order = "";

     GameObject vbBtn1Object; //первая кнопка ЗЕЛЕНАЯ
     GameObject vbBtn2Object; //вторая кнопка КРАСНАЯ
     GameObject vbBtn3Object;// третья кнопка ЖЕЛТАЯ
     GameObject vbBtn4Object;// четвертая кнопка СИНЯЯ
     GameObject vbBtn5Object;// пятая кнопка ФИОЛЕТОВАЯ

    public Animator animObject;

    void Start()
    {
        vbBtn1Object = GameObject.Find("VirtualButton1");
        vbBtn2Object = GameObject.Find("VirtualButton2");
        vbBtn3Object = GameObject.Find("VirtualButton3");
        vbBtn4Object = GameObject.Find("VirtualButton4");
        vbBtn5Object = GameObject.Find("VirtualButton5");

        vbBtn1Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        vbBtn1Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButton1Pressed);

        vbBtn2Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        vbBtn2Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButton2Pressed);

        vbBtn3Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        vbBtn3Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButton3Pressed);

        vbBtn4Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        vbBtn4Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButton4Pressed);

        vbBtn5Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        vbBtn5Object.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButton5Pressed);

        animObject.GetComponent<Animator>();
    }
    public void OnButton1Pressed(VirtualButtonBehaviour vb)
    {
        animObject.Play("kick");
        order += "1";
    }

    public void OnButton2Pressed(VirtualButtonBehaviour vb)
    {
        animObject.Play("BAM");
        order += "2";
    }
    public void OnButton3Pressed(VirtualButtonBehaviour vb)
    {
        animObject.Play("smack");
        order += "3";
    }
    public void OnButton4Pressed(VirtualButtonBehaviour vb)
    {
        animObject.Play("sliceunder");
        order += "4";
    }
    public void OnButton5Pressed(VirtualButtonBehaviour vb)
    {
        animObject.Play("spin");
        order += "5";
    }
    
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (Game2.hasLost == true)
        {
            animObject.Play("falling");
            order = "";
        }

        if (Game2.hasWon == true)
        {
            order = "";
        }
    }

}
