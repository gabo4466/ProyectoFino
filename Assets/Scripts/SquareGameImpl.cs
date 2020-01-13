using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SquareGameImpl : IGameFactory
{
    //Lista de las casillas.
    private List<Casilla> lista = new List<Casilla>();
     
    
    
    void Start()
    {
        //pintor = new SquarePintorUnity();//pintorGObj.AddComponent<SquarePintorUnity>();
        
        makeGame(8);
        
    }
    
    public override void makeGame( int size ){
        
        for( int i=size ; i>0 ; i-- ){
            
            for( int j=0 ; j<size ; j++ ){
                
                SquareBox boxCreation = new SquareBox();
                boxCreation.setX(j);
                boxCreation.setY(i);
                Debug.Log(boxCreation);
                lista.Add( boxCreation );
            }
        }
        //assignNeighbour();
        //pintor.pintarBoxes( lista );
    }
    protected override void assignNeighbour(){

        foreach( SquareBox b in lista ){
            Debug.Log(b);
            for( int k=0 ; k<4 ; k++ ){
                
                if( k == 0 ){
                    b.setNeighbour( findBox( b.getX() , b.getY()+1 ) );
                }
                else if( k == 1 ){
                    b.setNeighbour( findBox( b.getX() , b.getY()-1 ) );
                }
                else if( k == 2 ){
                    b.setNeighbour( findBox( b.getX()+1 , b.getY() ) );
                }
                else if( k == 3 ){
                    b.setNeighbour( findBox( b.getX()-1 , b.getY() ) );
                }
            }
        }
    }
    public override Casilla findBox( int x,int y ){

        foreach( Casilla b in lista ){
            
            if( ( b.getX() == x ) && ( b.getY() == y ) ){
                
                return b;
            }

        }
        
        return null;
    }

}
