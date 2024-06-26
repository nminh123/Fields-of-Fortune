using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantPos : MonoBehaviour
{
    public List<Vector2Int> plantPos;

    private void Awake()
    {
        plantPos = new List<Vector2Int>();
    }

    private void Pos()
    {
        plantPos.Add(new Vector2Int(-8,1));
        plantPos.Add(new Vector2Int(-7,1));
        plantPos.Add(new Vector2Int(-6,1));
        plantPos.Add(new Vector2Int(-5,1));
        plantPos.Add(new Vector2Int(-4,1));
        plantPos.Add(new Vector2Int(-3,1));
        plantPos.Add(new Vector2Int(-2,1));
        
        plantPos.Add(new Vector2Int(-8,0));
        plantPos.Add(new Vector2Int(-7,0));
        plantPos.Add(new Vector2Int(-6,0));
        plantPos.Add(new Vector2Int(-5,0));
        plantPos.Add(new Vector2Int(-4,0));
        plantPos.Add(new Vector2Int(-3,0));
        plantPos.Add(new Vector2Int(-2,0));
        
        plantPos.Add(new Vector2Int(-8,-1));
        plantPos.Add(new Vector2Int(-7,-1));
        plantPos.Add(new Vector2Int(-6,-1));
        plantPos.Add(new Vector2Int(-5,-1));
        plantPos.Add(new Vector2Int(-4,-1));
        plantPos.Add(new Vector2Int(-3,-1));
        plantPos.Add(new Vector2Int(-2,-1));
        
        plantPos.Add(new Vector2Int(-8,-2));
        plantPos.Add(new Vector2Int(-7,-2));
        plantPos.Add(new Vector2Int(-6,-2));
        plantPos.Add(new Vector2Int(-5,-2));
        plantPos.Add(new Vector2Int(-4,-2));
        plantPos.Add(new Vector2Int(-3,-2));
        plantPos.Add(new Vector2Int(-2,-2));
        
        plantPos.Add(new Vector2Int(-8,-3));
        plantPos.Add(new Vector2Int(-7,-3));
        plantPos.Add(new Vector2Int(-6,-3));
        plantPos.Add(new Vector2Int(-5,-3));
        plantPos.Add(new Vector2Int(-4,-3));
        plantPos.Add(new Vector2Int(-3,-3));
        plantPos.Add(new Vector2Int(-2,-3));
        
        plantPos.Add(new Vector2Int(-8,-4));
        plantPos.Add(new Vector2Int(-7,-4));
        plantPos.Add(new Vector2Int(-6,-4));
        plantPos.Add(new Vector2Int(-5,-4));
        plantPos.Add(new Vector2Int(-4,-4));
        plantPos.Add(new Vector2Int(-3,-4));
        plantPos.Add(new Vector2Int(-2,-4));
    }
}
