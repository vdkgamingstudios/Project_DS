using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            if(SaveScript.RaceStart == true)
            {
                // pass the input to the car!
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
                float v = CrossPlatformInputManager.GetAxis("Vertical");

                if(v < 0 && h != 0)
                {
                    SaveScript.BrakeSlide = true;
                }
                if(v >= 0)
                {
                    SaveScript.BrakeSlide = false;
                }

#if !MOBILE_INPUT
                float handbrake = CrossPlatformInputManager.GetAxis("Jump");
                m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
            }
        }
    }
}
