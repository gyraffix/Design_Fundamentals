using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;



public class OpenDoor : MonoBehaviour
{
    public Transform door;
    private Animator animator;
    public float openSpeed;
    private float startY;
    public float maxY;
    public bool open = false;
    public Camera camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startY = door.position.y;
        animator = door.gameObject.GetComponentInChildren<Animator>();
    }

    public void Open()
    {
        open = true;
        door.GetComponentInChildren<Light>().enabled = true;
        if (camera != null) {
            camera.gameObject.active = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (open && door.position.y < startY + maxY)
        {
            door.Translate(Vector3.up * openSpeed * Time.deltaTime);
        }
        else if (open && door.position.y >= maxY)
        {
            animator.enabled = true;
            
            open = false;
            animator.SetTrigger("Open");
            if (camera != null)
            {
                camera.gameObject.active = false;
            }
        }
        
    }
}
