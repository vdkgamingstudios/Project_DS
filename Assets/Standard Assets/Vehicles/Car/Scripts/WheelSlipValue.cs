using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSlipValue : MonoBehaviour
{
    WheelCollider WheelC;
    public float RoadForwardStiffness = 3f;
    public float TerrainForwardStiffness = 0.6f;
    public float RoadSidewaysStiffness = 1.1f;
    public float TerrainSidewaysStiffness = 0.2f;
    private bool Changed = false;

    // Start is called before the first frame update
    void Start()
    {
        WheelC = GetComponent<WheelCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //Road Checking
        if(SaveScript.OnTheRoad == true)
        {
            if (Changed == false)
            {
                Changed = true;
                //Forward friction
                WheelFrictionCurve fFriction = WheelC.forwardFriction;
                fFriction.stiffness = RoadForwardStiffness;
                WheelC.forwardFriction = fFriction;

                //Sideways friction
                WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
                sFriction.stiffness = RoadSidewaysStiffness;
                WheelC.sidewaysFriction = sFriction;
            }
        }

        //Terrain Checking
        if (SaveScript.OnTheTerrain == true)
        {
            if (Changed == true)
            {
                Changed = false;
                //Forward friction
                WheelFrictionCurve fFriction = WheelC.forwardFriction;
                fFriction.stiffness = TerrainForwardStiffness;
                WheelC.forwardFriction = fFriction;

                //Sideways friction
                WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
                sFriction.stiffness = TerrainSidewaysStiffness;
                WheelC.sidewaysFriction = sFriction;
            }
        }
    }
}
