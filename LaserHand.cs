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
            base.OnPointerIn(e);//���-�� ��� ����� �����������
        }
    }
public override void OnPointerClick(PointerEventArgs e)
    {
        if (e.target.CompareTag("ButtonUI"))
        {
            e.target.GetComponent<Button>().onClick.Invoke();//����� ��� ������� ����� ��������� �� ������ ��� ������
        }
    }
public override void OnPointerOut(PointerEventArgs e)
    {
        base.OnPointerIn(e);
    }
}