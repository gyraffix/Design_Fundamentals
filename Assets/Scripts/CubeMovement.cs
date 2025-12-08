using JetBrains.Annotations;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    bool moving;
    Vector3 direction;
    public float speed;
    public Vector3 startPos;
    public GameObject scrapeSFX;

    Rigidbody rb;
    Animator animator;
    ParticleSystem smoke;
    ParticleSystem dust;
    GameObject dustParent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        smoke = gameObject.GetComponentInChildren<ParticleSystem>();
    }

    public void StartMoving(GameObject obj)
    {
            moving = true;
            scrapeSFX.SetActive(true);
            direction = obj.transform.up * -1;

    }
    public void Reset()
    {
        transform.position = (startPos);
        moving = false;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Wall"))
        {
            moving = false;
            scrapeSFX.SetActive(false);
            Debug.Log("Stop moving");
            transform.Translate(-direction * 0.1f);
        }

        if (collision.gameObject.tag.Equals("Goal"))
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            collision.gameObject.GetComponent<OpenDoor>().Open();
            animator.SetTrigger("Shrink");
            smoke.transform.localScale = Vector3.one * 5;
            smoke.Play();
            Destroy(gameObject, 0.66f);

        }

    }

    


    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            rb.linearVelocity = (direction * speed);
        }
        else { rb.linearVelocity = Vector3.zero; }
    }
}
