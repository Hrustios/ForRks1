using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;

public class LaserHand : SteamVR_Laser Pointer
{
    
public override void OnPointerIn(PointerEventArgs e)
    {  
        if (e.target.CompareTag("ButtonUI"))
        {
            base.OnPointerIn(e);//что-то что будет происходить
        }
    }
public override void OnPointerClick(PointerEventArgs e)
    {
        if (e.target.CompareTag("ButtonUI"))
        {
            e.target.GetComponent<Button>().onClick.Invoke();//можно так вызвать метод накинутый на кнопку как обычно
        }
    }
public override void OnPointerOut(PointerEventArgs e)
    {
        base.OnPointerIn(e);
    }
}