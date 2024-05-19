using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI furnitureName;
    [SerializeField] private TextMeshProUGUI furnitureHeight;
    [SerializeField] private TextMeshProUGUI furnitureWidth;
    [SerializeField] private TextMeshProUGUI furnitureDepth;
    [SerializeField] private Image furnitureImg;
    [SerializeField] private fornitures[] arrayFurniture;
    private int activeFurniture;
    [SerializeField] private TextMeshProUGUI color1;
    [SerializeField] private TextMeshProUGUI color2;
    [SerializeField] private TextMeshProUGUI color3;


    private void Start()
    {
        updateUI();
    }


    public void nextFurniture()
    {
        if(activeFurniture == arrayFurniture.Length -1)
        {
            activeFurniture = 0;
        }
        else
        {
            activeFurniture++;
        }
        updateUI();
    }

    public void previousFurniture()
    {
        if (activeFurniture == 0)
        {
            activeFurniture = arrayFurniture.Length - 1;
        }
        else
        {
            activeFurniture--;
        }
        updateUI();
    }

    public void updateUI()
    {
        furnitureName.text = arrayFurniture[activeFurniture].fornitureName;
        furnitureHeight.text = arrayFurniture[activeFurniture].height;
        furnitureWidth.text = arrayFurniture[activeFurniture].width;
        furnitureDepth.text = arrayFurniture[activeFurniture].depth;
        color1.text = arrayFurniture[activeFurniture].colors[0];
        color2.text = arrayFurniture[activeFurniture].colors[1];
        color3.text = arrayFurniture[activeFurniture].colors[2];
        furnitureImg.sprite = arrayFurniture[activeFurniture].furnitureImg;
    }



}
