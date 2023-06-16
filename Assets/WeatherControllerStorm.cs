using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WizardsCode.EnviroExtensions
{
    public class WeatherControllerStorm : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {

            EnviroSkyMgr.instance.ChangeWeather(7);
        }



    }
}
