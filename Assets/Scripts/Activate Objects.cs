using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObjects : MonoBehaviour
{
    public List<GameObject> toActivateObjects;
    public List<GameObject> toDeactivateObjects;
    public List<MonoBehaviour> toActivateScripts;


    public void Activate()
    {
        foreach (GameObject obj in toActivateObjects)
        {
            obj.SetActive(true);
        }

        foreach (GameObject obj in toDeactivateObjects)
        {
            obj.SetActive(false);
        }

        foreach (MonoBehaviour obj in toActivateScripts)
        {
            obj.enabled = true;
        }
        
    }
}
