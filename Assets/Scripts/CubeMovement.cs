using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    bool moving;
    Vector3 direction;
    GameObject lastPush;
    public float speed;
    public Vector3 startPos;
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    public void StartMoving(GameObject obj)
    {
            moving = true;
            direction = obj.transform.up * -1;

    }
    public void Reset()
    {
        transform.position = (startPos);
        moving = false;
    }
    private void OnCollisionEnter(Collision collision)
    {

        //=======- Code in this block was written by ChatGPT -=================
        //=====================================================================
        foreach (ContactPoint contact in collision.contacts)
        {
            Vector3 normal = contact.normal;

            float dot = Vector3.Dot(direction, normal);

            if (dot > 0.9f)
            {
                //=============================================================
                if (collision.gameObject.tag.Equals("Wall"))
                {
                    moving = false;
                }
                
            }

        }
        if (collision.gameObject.tag.Equals("Goal"))
        {

            collision.gameObject.GetComponent<OpenDoor>().Open();
            Destroy(gameObject);
        }

    }

    


    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            rb.AddForce(direction * speed * Time.deltaTime);
        }
    }
}
