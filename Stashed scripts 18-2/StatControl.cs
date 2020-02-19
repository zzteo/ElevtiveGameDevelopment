using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatControl : MonoBehaviour
{
    //private BaseAI ai = null;
    public float HP {  get; private set; }
    public float R { get; private set; }
    public float SPD { get; private set; }
    public float DMG { get; private set; }

    public HealthScript healthScript;
    
    
//adjust total resource value and set it.
    public void SetHealth(float newHealth)
    {
        R = newHealth;
    }

    public void SetNewMode(Vector3 newMode)
    {

        HP = R * newMode.x;
        SPD = R * newMode.y;
        DMG = R * newMode.z;
    }
    
//    public void SetAI(BaseAI _ai) {
//        ai = _ai;
//        ai.Stats = this;
//    }
    
}