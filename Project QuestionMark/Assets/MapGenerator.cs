using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public GameObject hexPrefab;
    public int mapLength, mapWidth;
    float zOffset = 0.882f;
    float xOffset = 0.764f;

	void Start () {
        for (int x = 0; x < mapWidth; x++)
            for (int y = 0; y < mapLength; y++)
            {
                float xPos = x * xOffset;
                if (y % 2 == 1)
                    xPos += xOffset / 2f;
                GameObject newHex = (GameObject)Instantiate(hexPrefab, new Vector3(xPos, 0, y * zOffset), Quaternion.identity);
                newHex.name = "Hex_" + x + "_" + y;
                newHex.transform.SetParent(this.transform);
            }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
