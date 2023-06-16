using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WizardsCode.EnviroExtensions
{
    public class TimeController : MonoBehaviour
    {
        public float targetTime = 12f; // The desired target time in hours

        private void OnTriggerEnter(Collider other)
        {
            // Access the EnviroSkyMgr instance
            EnviroSkyMgr enviroSkyMgr = EnviroSkyMgr.instance;

            // Set the desired target time
            enviroSkyMgr.SetTimeOfDay(targetTime);

            // Optional: Uncomment the following line if you want to apply the time change immediately
            // enviroSkyMgr.SetTimeProgress(0f);
        }
    }
}
