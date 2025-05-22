using UnityEngine;

public class TestesChao : MonoBehaviour
{
    
    public GameObject refPlayer;
    public Transform spawnpoint;
    public GameObject refPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
          if(Input.GetKeyDown(KeyCode.Z)){

              refPlayer.SetActive(true);

        }

         if(Input.GetMouseButtonDown(2)){

              Destroy(refPlayer);

         }

         if(Input.GetMouseButtonDown(1)){

            Instantiate(refPrefab, spawnpoint);
            ScoreManager.triangleCount++;
         }

    }
}
