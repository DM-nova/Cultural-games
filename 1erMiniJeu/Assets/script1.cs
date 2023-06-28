using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class script1 : MonoBehaviour
{   
   
    string filename ="";

    [System.Serializable]
    public class Player
    {
        public int NumeroDeJoueur;
        public int TempsDeReponse;
    }

    [ System.Serializable]
    public class PlayerList
    {
        public Player[] player;
    }
    public PlayerList myPlayerList = new PlayerList();
    void Start()
    { 
        
        filename = Application.dataPath + "/test.csv";
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            WriteCSV();
    }

    public void WriteCSV()
    {
        if(myPlayerList.player.Length > 0)
        {
            TextWriter tw = new StreamWriter (filename, false);
            tw.WriteLine("NumeroDeJoueur, TempsDeReponse");
            tw.Close();

            tw = new StreamWriter(filename, true);

            for(int i =0; i < myPlayerList.player.Length; i++)
            {
                tw.WriteLine(myPlayerList.player[i].NumeroDeJoueur + "," + myPlayerList.player[i].TempsDeReponse);

            }
            tw.Close();
        }
    }
}
