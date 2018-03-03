using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public static InputManager _IM;



    void Start()
    {
        if(_IM != null)
        {
            Destroy(this);
        }
        else
        {
            _IM = this;
        }

        if(_IM == null)
            Debug.Log("Not working");

        var PPM = PlayerPrefsManager._PPM;

        keycode_MoveLeft    = (KeyCode) System.Enum.Parse(typeof(KeyCode),PPM.GetKey(PPM.prefsKey_MoveLeft, KeyCode.A.ToString()));
        keycode_MoveRight   = (KeyCode) System.Enum.Parse(typeof(KeyCode),PPM.GetKey(PPM.prefsKey_MoveRight, KeyCode.D.ToString()));
        keycode_MoveForward = (KeyCode) System.Enum.Parse(typeof(KeyCode),PPM.GetKey(PPM.prefsKey_MoveForward, KeyCode.W.ToString()));
        keycode_MoveBack    = (KeyCode) System.Enum.Parse(typeof(KeyCode),PPM.GetKey(PPM.prefsKey_MoveBack, KeyCode.S.ToString()));
        keycode_MoveJump    = (KeyCode) System.Enum.Parse(typeof(KeyCode),PPM.GetKey(PPM.prefsKey_MoveJump, KeyCode.Space.ToString()));
        keycode_MoveSprint  = (KeyCode) System.Enum.Parse(typeof(KeyCode),PPM.GetKey(PPM.prefsKey_MoveSprint, KeyCode.LeftShift.ToString()));
        keycode_MoveSneak   = (KeyCode) System.Enum.Parse(typeof(KeyCode),PPM.GetKey(PPM.prefsKey_MoveSneak, KeyCode.LeftControl.ToString()));
        keycode_MoveDash    = (KeyCode) System.Enum.Parse(typeof(KeyCode),PPM.GetKey(PPM.prefsKey_MoveDash, KeyCode.Z.ToString()));
        keycode_RotateCameraLeft = (KeyCode) System.Enum.Parse(typeof(KeyCode), PPM.GetKey(PPM.prefsKey_RotateCameraLeft, KeyCode.LeftArrow.ToString()));
        keycode_RotateCameraLeft = (KeyCode) System.Enum.Parse(typeof(KeyCode), PPM.GetKey(PPM.prefsKey_RotateCameraRight, KeyCode.RightArrow.ToString()));
        keycode_RotateCameraLeft = (KeyCode) System.Enum.Parse(typeof(KeyCode), PPM.GetKey(PPM.prefsKey_RotateCameraUp, KeyCode.UpArrow.ToString()));
        keycode_RotateCameraLeft = (KeyCode) System.Enum.Parse(typeof(KeyCode), PPM.GetKey(PPM.prefsKey_RotateCameraDown, KeyCode.DownArrow.ToString()));
    }

    public KeyCode keycode_MoveLeft;
    public KeyCode keycode_MoveRight;
    public KeyCode keycode_MoveForward;
    public KeyCode keycode_MoveBack;
    public KeyCode keycode_MoveJump;
    public KeyCode keycode_MoveSprint;
    public KeyCode keycode_MoveSneak;
    public KeyCode keycode_MoveDash;
    public KeyCode keycode_RotateCameraLeft;
    public KeyCode keycode_RotateCameraRight;
    public KeyCode keycode_RotateCameraUp;
    public KeyCode keycode_RotateCameraDown;
}