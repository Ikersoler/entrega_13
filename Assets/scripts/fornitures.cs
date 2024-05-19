using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/fornitures")]
public class fornitures : ScriptableObject
{
    public string fornitureName;
    public Sprite furnitureImg;
    public string height;
    public string width;
    public string depth;
    public String[] colors;

}
