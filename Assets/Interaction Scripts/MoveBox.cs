using UnityEngine;

public class MoveBox : PlayerActivatable
{
    public CubeMovement cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame

    override protected void OnActivate()
    {
        cube.StartMoving(gameObject);
    }


}
