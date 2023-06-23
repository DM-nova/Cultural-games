using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    //Variables that need to be stored
      
    public int Val=0;
    int ValValue;
    [SerializeField] GameObject Butt1,Butt2;
    private void Awake()
    {
        Butt1= GameObject.FindWithTag("Cbutton1");
        Butt2= GameObject.FindWithTag("Cbutton2");
        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); 
        LoadData(); 
    }

    [System.Serializable] 
    class SaveData
    {
        //Variables that need to be stored
        public int Val;
    }

    void Start()
    {
        ValValue = Instance.Val;
        if(ValValue!=0)
           {
            Butt1.SetActive(false);
            Butt2.SetActive(true);
            }
    }

    public void WriteData()
    {
        SaveData data = new SaveData();

        //Variables that need to be stored
        data.Val = Val;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("Application.persistentDataPath: " + Application.persistentDataPath);
    }

    public void LoadData() 
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            //Variables that need to be stored
            
            Val = data.Val;
        }
    }

    public void SaveOnClick()
    {
        Instance.Val = ValValue;
        Instance.WriteData();
    }


}