using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gothamsounds : MonoBehaviour
{
    public AudioSource src;
    public AudioClip rook, bishop, knight, queen;



    public void rook_move()
    {
        src.clip = rook;
        src.Play();
    }

    public void bishop_move()
    {
        src.clip = bishop;
        src.Play();
    }

    public void knight_move()
    {
        src.clip = knight;
        src.Play();
    }

    public void queen_move()
    {
        src.clip = queen;
        src.Play();
    }

}
