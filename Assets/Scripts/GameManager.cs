using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Points { get { return points; } }
    private int points;
    
    public void IncreasePoints(int pointsToIncrease)
        {
            points += pointsToIncrease;
            Debug.Log(points);
        }
}
