using UnityEngine;

public class VibrateFingersScript : MonoBehaviour
{
    private SensoHandExample LeftHandScript;
    private SensoHandExample RightHandScript;
    private SensoHandExample HandScript;        //  Hand script container

    private ushort duration = 400;
    private byte  strength = 2;

    void Start()
    {
        RightHandScript = GameObject.FindGameObjectWithTag("RH_Container").GetComponent<SensoHandExample>();
        LeftHandScript = GameObject.FindGameObjectWithTag("LH_Container").GetComponent<SensoHandExample>();
        HandScript = LeftHandScript;

        Debug.Log("start script");

    }

    private void Update()
    {
        //LeftHandScript.VibrateFinger(Senso.EFingerType.Thumb, duration, strength);
        //LeftHandScript.VibrateFinger(Senso.EFingerType.Little, duration, strength);
        //LeftHandScript.VibrateFinger(Senso.EFingerType.Middle, duration, strength);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("RH"))   // or LH
        {
            HandScript = RightHandScript;
        }
        else
        {
            HandScript = LeftHandScript;
        }

        switch (collision.gameObject.name)
        {
            case "Bone.004_end":
                {
                    Debug.Log("collision Thumb");
                    HandScript.VibrateFinger(Senso.EFingerType.Thumb, duration, strength);
                    break;
                }
            case "Bone.008_end":
                {
                    Debug.Log("collision Index");
                    HandScript.VibrateFinger(Senso.EFingerType.Index, duration, strength);
                    break;
                }
            case "Bone.017_end":
                {
                    Debug.Log("collision Middle");
                    HandScript.VibrateFinger(Senso.EFingerType.Middle, duration, strength);
                    break;
                }
            case "Bone.015_end":
                {
                    Debug.Log("collision Third");
                    HandScript.VibrateFinger(Senso.EFingerType.Third, duration, strength);
                    break;
                }
            case "Bone.020_end":
                {
                    Debug.Log("collision Little");
                    HandScript.VibrateFinger(Senso.EFingerType.Little, duration, strength);
                    break;
                }
        }
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("RH"))   // or LH
        {
            HandScript = RightHandScript;
        }
        else
        {
            HandScript = LeftHandScript;
        }

        switch (collision.gameObject.name)
        {
            case "Bone.004_end":
                {
                    Debug.Log("collision Thumb");
                    HandScript.VibrateFinger(Senso.EFingerType.Thumb, duration, strength);
                    break;
                }
            case "Bone.008_end":
                {
                    Debug.Log("collision Index");
                    HandScript.VibrateFinger(Senso.EFingerType.Index, duration, strength);
                    break;
                }
            case "Bone.017_end":
                {
                    Debug.Log("collision Middle");
                    HandScript.VibrateFinger(Senso.EFingerType.Middle, duration, strength);
                    break;
                }
            case "Bone.015_end":
                {
                    Debug.Log("collision Third");
                    HandScript.VibrateFinger(Senso.EFingerType.Third, duration, strength);
                    break;
                }
            case "Bone.020_end":
                {
                    Debug.Log("collision Little");
                    HandScript.VibrateFinger(Senso.EFingerType.Little, duration, strength);
                    break;
                }
        }
    }
}




