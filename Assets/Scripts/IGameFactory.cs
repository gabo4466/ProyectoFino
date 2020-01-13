using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Solia ser una interface, muy tarde para cambiarle el nombre.
public abstract class IGameFactory : MonoBehaviour
{
    protected IPintor pintor;
    public abstract void makeGame(int size);
    protected abstract void assignNeighbour();
    public abstract Casilla findBox(int x,int y);

}
