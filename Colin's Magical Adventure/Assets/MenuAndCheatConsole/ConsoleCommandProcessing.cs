using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleCommandProcessing : MonoBehaviour {

    private GameObject player;
    //private RespawnManager respMana;
    private RigidbodyFirstPersonController rigi;
    private List<string> commandList;

    // Use this for initialization
    public void processing(string commandString)
    {
        /*player = GameObject.FindGameObjectWithTag("Player");
        respMana = player.GetComponent<RespawnManager>();
        rigi = GameObject.FindGameObjectWithTag("Player").GetComponent< RigidbodyFirstPersonController>();

        List<string> commandList = new List<string>();
        //Parse string command into list
        commandList = commandString.Split(' ').ToList();

        //Teleportation command
        if (commandList[0] == "tp")
        {
            if (commandList.Count == 4)
            {
                float x, y, z;
                bool resX, resY, resZ;
                resX = float.TryParse(commandList[1], out x);
                resY = float.TryParse(commandList[2], out y);
                resZ = float.TryParse(commandList[3], out z);
                if(resX && resY && resZ)
                    Teleportation(x, y, z);
                else
                    Debug.Log("Erreur");
            }
            else
            {
                switch (commandList[1])
                {
                    case "checkpoint":
                        //if(commandList[2] <= GameObject.FindGameObjectsWithTag("CheckPoint").)
                        if (commandList[2] != null)
                            Teleportation("CheckPoint" + commandList[2]);
                        else
                            Teleportation("CheckPoint1");
                        break;
                    case "startpoint":
                        Teleportation("StartPoint");
                        break;
                    default:
                        Debug.Log("Erreur");
                        break;
                }
            } 
        }
        //Teleportation command
        else if (commandList[0] == "respawn")
        {
            Teleportation(respMana.LevelState.ToString());
        }
        //Item Command
        else if (commandList[0] == "item" && commandList.Count == 2)
        {
            switch (commandList[1])
            {
                case "key":
                    Debug.Log("Item Clef");
                    break;
                default:
                    Debug.Log("Erreur");
                    break;
            }
        }
        //Speed change command
        else if ((commandList[0] == "speedmultiplier") && commandList.Count == 2)
        {

            if (commandList[1] == "reset")
            {
                Debug.Log("Vitesse réinitialisée");
                SpeedMultiplier(1);
            }
            else
            {
                float number;
                bool res;
                //Try to parse into float
                res = float.TryParse(commandList[1], out number);
                if (res)
                {
                    Debug.Log("Vitesse multipliée par " + number.ToString());
                    SpeedMultiplier(number);
                }
                else
                    Debug.Log("Erreur");
            }
        }
        else if ((commandList[0] == "jumpmultiplier") && commandList.Count == 2)
        {

            if (commandList[1] == "reset")
            {
                Debug.Log("Force de saut réinitialisée");
                JumpMultiplier(1);
            }
            else
            {
                float number;
                bool res;
                //Try to parse into float
                res = float.TryParse(commandList[1], out number);
                if (res)
                {
                    Debug.Log("Force de saut multipliée par " + number.ToString());
                    JumpMultiplier(number);
                }
                else
                    Debug.Log("Erreur");
            }
        }
        else if (commandList[0] == "unlockall")
        {
            GameObject[] objects= GameObject.FindGameObjectsWithTag("Enigma");
            foreach (GameObject objet in objects)
                objet.GetComponent<Enigma>().Unlocked = true;
            Debug.Log("Toutes les énigmes ont été débloquées");
        }
        else if (commandList[0] == "lockall")
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Enigma");
            foreach (GameObject objet in objects)
            {
                objet.GetComponent<Enigma>().Unlocked = false;
                objet.GetComponentInChildren<NumericDisplayManager>().ChangeColorChain(Color.white);
                objet.GetComponentInChildren<Text>().text = "XXXX";
            }
            Debug.Log("Toutes les énigmes ont été bloquées");
        }
        else if (commandList[0] == "key")
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("ObjectSpawner");
            foreach (GameObject objet in objects)
            {
                if (!(objet.transform.childCount > 1)){
                    objet.GetComponent<SpawnItem>().Start();
                }
            }
            Debug.Log("Toutes les clefs sont disponibles");
        }
        else
            Debug.Log("Erreur");*/
    }

    //Use RespawnManager.cs method
    /*public void Teleportation(string place)
    {
        respMana.Respawn(player, place);
    }
    public void Teleportation(float x, float y, float z)
    {
        respMana.Respawn(player, x, y, z);
    }

    //Change Multiplier value into RigidbodyFirstPersonController.cs
    public void SpeedMultiplier(float number)
    {
        rigi.movementSettings.SpeedMultiplier = number;
    }
    public void JumpMultiplier(float number)
    {
        rigi.movementSettings.JumpMultiplier = number;
    }*/
}
