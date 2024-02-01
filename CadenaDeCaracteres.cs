using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadenaDeCaracteres : MonoBehaviour
{
    public string data = "x: 2, y: 5, z:8";
    public Vector3 position;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < data.Length; i++) 
        {
            if (data[i] == 'x')
            {
                int x = (int)char.GetNumericValue(data [i+2]);
                position = new Vector3(x, position.y, position.z);
            }
            
            if (data[i] == 'y')
            {
                int y = (int)char.GetNumericValue(data [i+2]);
                position = new Vector3(position.x, y, position.z);
            }
            
            if (data[i] == 'z')
            {
                int z = (int)char.GetNumericValue(data [i+2]);
                position = new Vector3(position.x, position.y, z);
            }
        }

        FileSystem.Instance.CreateFile("Posiciones", ".save", position);

        Instantiate(prefab, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
