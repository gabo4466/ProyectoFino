using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Casilla : MonoBehaviour
{
    protected List<Casilla> neighbours = new List<Casilla>();
    protected int x;
    protected int y;
    public void setNeighbour( Casilla b ){

        neighbours.Add( b );

    }
    public int getY(  ){

        return this.y;

    } 
    public int getX(  ){

        return this.x;

    }
    public void setX(int x){
        this.x = x;
    }
    public void setY(int y){
        this.y = y;
    }
    
}
