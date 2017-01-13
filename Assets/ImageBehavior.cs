using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageBehavior : MonoBehaviour {
    public WWW w;

    // Use this for initialization
    void Start()
    {
        // w = new WWW("file:///c:/Users/Peter/Desktop/pic.jpg");
        w = new WWW("file:///sdcard/Download/pic.jpg");

    }
    // Update is called once per frame
    void Update()
    {
        if (w.isDone)
        {
            Debug.Log("J'essaie de changer l'image");
            GameObject basket = GameObject.FindGameObjectWithTag("Player") as GameObject;
            Debug.Log(basket.name);
            Texture2D texture = w.texture;
            // Texture2D texture = Resources.Load<Texture2D>("pic");
            Debug.Log(texture.name);
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

            basket.GetComponent<SpriteRenderer>().sprite = sprite;

        }
    }
}
