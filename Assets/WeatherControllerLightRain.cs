using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WizardsCode.EnviroExtensions
{
    public class WeatherControllerLightRain : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {

            EnviroSkyMgr.instance.ChangeWeather(10);
        }



    }
}
