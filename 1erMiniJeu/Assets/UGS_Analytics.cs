using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Unity.Services.Core.Analytics;
public class UGS_Analytics : MonoBehaviour
{ 
async void Start()
   {
try
       {
await UnityServices.InitializeAsync();
LevelCompletedCustomEvent();
       }
catch (ConsentCheckException e)
       {
Debug.Log(e.ToString());
       }
   }
private void LevelCompletedCustomEvent()
   {
Dictionary<string, object> parameters = new Dictionary<string, object>()
{
    { "levelName", 1}
};
// The ‘myEvent’ event will get queued up and sent every minute
AnalyticsService.Instance.CustomData("levelCompleted", parameters); 
AnalyticsService.Instance.Flush();
   }
}

    
  