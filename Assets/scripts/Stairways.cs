using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairways : Collidable

public string[] sceneNames;    

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        { 

        // Teleport the player
        string sceneName = sceneNames

        }
    }
}
