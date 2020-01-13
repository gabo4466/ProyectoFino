using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquarePintorUnity : MonoBehaviour, IPintor
{
    public GameObject BoxPrefab;
    public void pintarBoxes(List<Casilla> boxes){
        foreach(Casilla b in boxes){
            
            int x = b.getX();
            int y = b.getY();
            
            
        }
    }
}
