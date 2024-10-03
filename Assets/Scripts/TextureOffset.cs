using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOffset : MonoBehaviour
{
    public float scrollSpeed;


    // Scroll main texture based on time

    [SerializeField]
   private  Renderer rend;
    [SerializeField]
    private float offset;

    void Awake()
    {
        rend = this.gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        offset = Time.time * scrollSpeed;
        //rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        rend.material.mainTextureOffset = new Vector2(0, offset);
    }
}
