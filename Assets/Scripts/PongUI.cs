using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PongUI : MonoBehaviour
{
    public int pointsLeftAmount, pointsRightAmount;
    public TextMeshProUGUI pointsLeft, pointsRight;

    public void Start()
    {
        UpdatePoints();
    }

    public void UpdatePoints()
    {
        pointsLeft.text = $"{pointsRightAmount}";
        pointsRight.text = $"{pointsRightAmount}";
    }

    public void AddPointsToLeft()
    {
        pointsLeftAmount++;
        UpdatePoints();
    }
     public void AddPointsToRight()
    {
        pointsRightAmount++;
        UpdatePoints();
    }
}
