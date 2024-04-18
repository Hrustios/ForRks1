using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerMove : MonoBehaviour
{
    //переменные тачпад контроллера и задний курок private SteamVR_Action_Vector2 touchpad = null;
    private SteamVR_Action_Boolean m_Boolean = null;
    private CharacterController controller = null;
    //скорость перемещения игрока
    public float speed = 1f;
    //переменная для проверки, когда именно нужно перемещать игрока
    private bool checkWalk = false;

    private void Awake()
    {
        touchpad = SteamVR_Actions._default.Touchpad; //vector2 - trackpad позиция
        m_Boolean = SteamVR_Actions._default.TouchClick; //boolean - trackpad нажатие
        controller = GetComponent<CharacterController>();
    }
        private void Update() { 
    //если нажали на левом контроллере задний курок if (m_Boolean.GetStateDown(SteamVR_Input_Sources. RightHand))
    if (m_Boolean.GetStateUp(SteamVR_Input_Sources.RightHand))
    {
        //"включаем" переменную
        checkWalk =true;
    }
    //если отпустили на левом контроллере задний курок
    if (m_Boolean.GetStateUp(SteamVR_Input_Sources.RightHand))
    {
    //"выключаем" переменную
    checkWalk =false;
    }
        //если водим рукой по тачпаду контроллера
        if (touchpad.axis.magnitude > 0.1f)
        {
            //и нажат задний курок
            if (checkWalk)
            {
                // Vector3 direction = Player.instance.hmdTransform.TransformDirection (Vector3.forward);
                //то перемещаем игрока в том же направлении, в котором и водим по тачпаду
                Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(touchpad.axis.x, 0, touchpad.axis.y));
                controller.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
            }
        }
}