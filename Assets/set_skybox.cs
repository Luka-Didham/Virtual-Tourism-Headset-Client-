using Byn.Awrtc;
using Byn.Awrtc.Unity;
using Byn.Unity.Examples;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set_skybox : MonoBehaviour
{

/*    [SerializeField] private Material skyboxMaterial;
    [SerializeField] private RawImage recieveImage;
    [SerializeField] private Button updateSkybox;

    // Start is called before the first frame update
    void Start()
    {
        updateSkybox.onClick.AddListener(Skybox);

    }


    void Skybox()
    {
        Debug.Log("Pressed");
        //watch out: due to conversion from WebRTC to Unity format the image is flipped (top to bottom)
        //this also inverts the rotation
       *//* recieveImage.transform.localRotation = Quaternion.Euler(0, 0, frame.MetaData.Rotation * -1);
        Texture2D tex = recieveImage.texture as Texture2D;
        tex = FlipTexture(ref tex); //WebRTC makes video upside down *//*
        skyboxMaterial.mainTexture = tex;
        RenderSettings.skybox = skyboxMaterial;

    }*/




}
