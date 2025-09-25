using Unity.VisualScripting;
using UnityEngine;



public class OpenDoor : MonoBehaviour
{
    public Transform Door;
    public float openSpeed;
    private float startY;
    public float maxY;
    bool open = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startY = Door.position.y;
    }

    public void Open()
    {
        open = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (open && Door.position.y < startY + maxY)
        {
            Door.Translate(Vector3.up * openSpeed * Time.deltaTime);
        }
        else if (open && Door.position.y >= maxY) open = false;
        
    }
}
