using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WizardsCode.EnviroExtensions
{
    public class WeatherController : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {

            EnviroSkyMgr.instance.ChangeWeather(0);
        }



    }
}
