using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCameraImage : MonoBehaviour

{
    WebCamTexture webCamTexture;
    public string path;
    public RawImage imgDisplayForPhotoSnap;
    public int webcamIndex = 1;
    // Start is called before the first frame update
    void Start()
    {
        webCamTexture = new WebCamTexture(WebCamTexture.devices[webcamIndex].name);
        GetComponent<Renderer>().material.mainTexture = webCamTexture;
        webCamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
