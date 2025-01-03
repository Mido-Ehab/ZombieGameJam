using UnityEditor;
using UnityEngine;

public class picture_puzzle : MonoBehaviour
{
    public GameObject box1;
    public GameObject box4;
    box1 b1;
    box4 b4;
    public bool iswin = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        b1 = box1.GetComponent<box1>();
        b4 = box4.GetComponent<box4>();
    }

    // Update is called once per frame
    void Update()
    {
        if (b1.right && b1.down && b4.left && b4.up)
        {
            iswin = true;
        }
    }
}
