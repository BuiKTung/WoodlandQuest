using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed;
    private Renderer renderer;
    private Vector2 saveOffset;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x=Mathf.Repeat(Time.time*speed,1);
        Vector2 offset = new Vector2(x,0);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
