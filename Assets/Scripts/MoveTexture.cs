using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    public Material material;
    public float width;
    public float speed;

    // Update is called once per frame
    void Update()
    {

        material.mainTextureOffset = new Vector2(Mathf.PingPong(Time.time,width), (Time.frameCount/speed));
    }
}
