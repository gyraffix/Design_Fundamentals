using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class ResetPuzzle : PlayerActivatable
{
    public bool test = false;
    public List<GameObject> boxes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    override protected void OnActivate()
    {
        foreach (GameObject obj in boxes)
        {
            if (obj != null)
            {
                test = true;
                obj.GetComponent<CubeMovement>().Reset();
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
