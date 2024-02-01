using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSystem : MonoBehaviour
{
    public static FileSystem Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }

        else
        {
            Instance = this;
        }
    }

    public void CreateFile(string _name, string _extension)
    {
        string path = Application.dataPath + "/" + _name + _extension;
        
        if (!File.Exists(path)) 
        {
            string content = "Login date"+ System.DateTime.Now + "\n";
            File.AppendAllText(path, content);
        }

        else
        {
            Debug.Log("Atención!! Estas tratando de crear un archivo con el mismo nombre ["+ _name + _extension+"], verifica tu información");
        }

    }
    
    public void CreateFile(string _name, string _extension, Vector3 _vec)
    {
        string path = Application.dataPath + "/" + _name + _extension;
        
        if (!File.Exists(path)) 
        {
            string content = _vec.ToString() + "\n" ;
            Debug.Log("Se almacenó la información" + content);
            File.AppendAllText(path, content);
        }

        else
        {
            Debug.Log("Atención!! Estas tratando de crear un archivo con el mismo nombre ["+ _name + _extension+"], verifica tu información");
        }

    }

    private void Start()
    {
        CreateFile("26Ene2024", ".save");

    }
}
