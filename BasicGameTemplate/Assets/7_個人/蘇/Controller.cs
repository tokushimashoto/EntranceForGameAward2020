using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    //Xbox_One_Controller
    private int Xbox_One_Controller = 0;
    //PS4_Controller
    private int PS4_Controller = 0;
    // Start is called before the first frame update
    void Start()
    {
        float Ps4LTrigger = -1;
        float Ps4RTrigger = -1;
    }

    void Update()
    {
        ///////////1.Mouse
        //MouseScrollWheel
        float MouseScrollWheel = Input.GetAxis("MouseScrollWheel");
        //MouseScrollWheel
        if (Mathf.Abs(MouseScrollWheel) > 0.05f || Mathf.Abs(MouseScrollWheel) > 0.05f)
        {
            print("MouseScrollWheel:" + MouseScrollWheel);
        }       
        //MouseLeftClick
        if (Input.GetButtonDown("MouseLeftClick"))
        {
            print("MouseLeftClick");
        }
        //MouseRightClick
        if (Input.GetButtonDown("MouseRightClick"))
        {
            print("MouseRightClick");
        }

        ///////////2.Controller
        //GetControllerName
        string[] names = Input.GetJoystickNames();
        //Xbox_One_ControllerかXbox_One_Controllerか、判断する
        for (int x = 0; x < names.Length; x++)
        {
            //print(names[x].Length);
            if (names[x].Length == 19)
            {

                //Debug.Log(string.Format("<color=#ff0000>{0}</color>", "PS4 CONTROLLER IS CONNECTED"));
                //print("PS4 CONTROLLER IS CONNECTED");
                PS4_Controller = 1;
                Xbox_One_Controller = 0;
            }
            else
            {
                //Debug.Log(string.Format("<color=#ff0000>{0}</color>", "Xbox 360 CONTROLLER IS CONNECTED"));
                //set a controller bool to true
                PS4_Controller = 0;
                Xbox_One_Controller = 1;
            }
            //Xbox_One_Controllerの文字は33、Xbox_360_Controllerは知らない
            //if (names[x].Length == 33)
            //{
            //    print("XBOX ONE CONTROLLER IS CONNECTED");
            //    //set a controller bool to true
            //    PS4_Controller = 0;
            //    Xbox_One_Controller = 1;
            //}
        }

        if (Xbox_One_Controller == 1)
        {
            //do something
            //GetAxis(全部で７Axis)
            float LeftStickHorizontal = Input.GetAxis("LeftStickHorizontal");
            float LeftStickVertical = Input.GetAxis("LeftStickVertical");
            float LeftCrossHorizontal = Input.GetAxis("LeftCrossHorizontal");
            float LeftCrossVertical = Input.GetAxis("LeftCrossVertical");
            float RightStickHorizontal = Input.GetAxis("RightStickHorizontal");
            float RightStickVertical = Input.GetAxis("RightStickVertical");
            float LRTrigger = Input.GetAxis("LRTrigger");

            //左スティック
            if (Mathf.Abs(LeftStickHorizontal) > 0.05f || Mathf.Abs(LeftStickVertical) > 0.05f)
            {
                print("LeftStickHorizontal:" + LeftStickHorizontal);
                print("LeftStickVertical:" + LeftStickVertical);
            }
            //十字キー
            if (Mathf.Abs(LeftCrossHorizontal) > 0.05f || Mathf.Abs(LeftCrossVertical) > 0.05f)
            {
                print("LeftCrossHorizontal:" + LeftCrossHorizontal);
                print("LeftCrossVertical:" + LeftCrossVertical);
            }
            //右スティック
            if (Mathf.Abs(RightStickHorizontal) > 0.05f || Mathf.Abs(RightStickVertical) > 0.05f)
            {
                print("RightStickHorizontal:" + RightStickHorizontal);
                print("RightStickVertical:" + RightStickVertical);
            }
            //LRTrigger
            if (Mathf.Abs(LRTrigger) > 0.05f)
            {
                print("LRTrigger:" + LRTrigger);
            }
            ////////////////////////////
            //GetButton
            //ViewButton
            if (Input.GetButtonDown("ViewButton"))
            {
                print("ViewButton");
            }
            //MenuButton
            if (Input.GetButtonDown("MenuButton"))
            {
                print("MenuButton");
            }
            //ADownButton
            if (Input.GetButtonDown("ADownButton"))
            {
                print("ADownButton");
            }
            //BRightButton
            if (Input.GetButtonDown("BRightButton"))
            {
                print("BRightButton");
            }
            //XLeftButton
            if (Input.GetButtonDown("XLeftButton"))
            {
                print("XLeftButton");
            }
            //YUpButton
            if (Input.GetButtonDown("YUpButton"))
            {
                print("YUpButton");
            }
            //LButton
            if (Input.GetButtonDown("LButton"))
            {
                print("LButton");
            }
            //RButton
            if (Input.GetButtonDown("RButton"))
            {
                print("RButton");
            }
            //LeftStickDown
            if (Input.GetButtonDown("LeftStickDown"))
            {
                print("LeftStickDown");
            }
            //RightStickDown
            if (Input.GetButtonDown("RightStickDown"))
            {
                print("RightStickDown");
            }
        }
        else if (PS4_Controller == 1)
        {
            //do something
            //GetPs4Axis(全部で8Axis)
            float Ps4LeftStickHorizontal = Input.GetAxis("Ps4LeftStickHorizontal");
            float Ps4LeftStickVertical = Input.GetAxis("Ps4LeftStickVertical");
            float Ps4LeftCrossHorizontal = Input.GetAxis("Ps4LeftCrossHorizontal");
            float Ps4LeftCrossVertical = Input.GetAxis("Ps4LeftCrossVertical");
            float Ps4RightStickHorizontal = Input.GetAxis("Ps4RightStickHorizontal");
            float Ps4RightStickVertical = Input.GetAxis("Ps4RightStickVertical");
            float Ps4LTrigger = Input.GetAxis("Ps4LTrigger");
            float Ps4RTrigger = Input.GetAxis("Ps4RTrigger");

            //Ps4左スティック
            if (Mathf.Abs(Ps4LeftStickHorizontal) > 0.05f || Mathf.Abs(Ps4LeftStickVertical) > 0.05f)
            {
                print("Ps4LeftStickHorizontal:" + Ps4LeftStickHorizontal);
                print("Ps4LeftStickVertical:" + Ps4LeftStickVertical);
            }
            //Ps4十字キー
            if (Mathf.Abs(Ps4LeftCrossHorizontal) > 0.05f || Mathf.Abs(Ps4LeftCrossVertical) > 0.05f)
            {
                print("Ps4LeftCrossHorizontal:" + Ps4LeftCrossHorizontal);
                print("Ps4LeftCrossVertical:" + Ps4LeftCrossVertical);
            }
            //Ps4右スティック
            if (Mathf.Abs(Ps4RightStickHorizontal) > 0.05f || Mathf.Abs(Ps4RightStickVertical) > 0.05f)
            {
                print("Ps4RightStickHorizontal:" + Ps4RightStickHorizontal);
                print("Ps4RightStickVertical:" + Ps4RightStickVertical);
            }
            //Ps4LTrigger = 4th Axis (-1.0f to 1.0f range, unpressed is -1.0f)
            if (Ps4LTrigger > -0.95f)
            {
                print("Ps4LTrigger:" + Ps4LTrigger);
            }
            //Ps4RTrigger = 5th Axis (-1.0f to 1.0f range, unpressed is -1.0f)
            if (Ps4RTrigger > -0.95f)
            {
                print("Ps4RTrigger:" + Ps4RTrigger);
            }
            ////////////////////////////
            //GetPs4Button
            //Ps4ViewButton
            if (Input.GetButtonDown("Ps4ViewButton"))
            {
                print("Ps4ViewButton");
            }
            //Ps4MenuButton
            if (Input.GetButtonDown("Ps4MenuButton"))
            {
                print("Ps4MenuButton");
            }
            //Ps4ADownButton
            if (Input.GetButtonDown("Ps4ADownButton"))
            {
                print("Ps4ADownButton");
            }
            //Ps4BRightButton
            if (Input.GetButtonDown("Ps4BRightButton"))
            {
                print("Ps4BRightButton");
            }
            //Ps4XLeftButton
            if (Input.GetButtonDown("Ps4XLeftButton"))
            {
                print("Ps4XLeftButton");
            }
            //Ps4YUpButton
            if (Input.GetButtonDown("Ps4YUpButton"))
            {
                print("Ps4YUpButton");
            }
            //Ps4LButton
            if (Input.GetButtonDown("Ps4LButton"))
            {
                print("Ps4LButton");
            }
            //Ps4RButton
            if (Input.GetButtonDown("Ps4RButton"))
            {
                print("Ps4RButton");
            }
            //Ps4LeftStickDown
            if (Input.GetButtonDown("Ps4LeftStickDown"))
            {
                print("Ps4LeftStickDown");
            }
            //Ps4RightStickDown
            if (Input.GetButtonDown("Ps4RightStickDown"))
            {
                print("Ps4RightStickDown");
            }
            //Ps4Pad
            if (Input.GetButtonDown("Ps4Pad"))
            {
                print("Ps4Pad");
            }
        }
        else
        {
            // there is no controllers
        }
    }

}
