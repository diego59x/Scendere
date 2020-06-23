using UnityEngine;

public class CreateMaps : MonoBehaviour
{
    public GameObject[] map;
    public GameObject[] wall;
    public GameObject player;
    private int dist = 0;
    private bool pause;
    int rand;
    public Pausa pausa;
    private void Start()
    {
        
        pause = pausa.GetPause();
        // Instancio el primer mapa asi para iniciar 
        Instantiate(map[0], new Vector3(0, 3.77f, dist + 5), Quaternion.identity);
        Instantiate(wall[0], new Vector3(-1.36f, 4.7f, dist + 5), Quaternion.identity);
    
    }
    void Update()
    {
        //Debug.Log(player.transform.position.z);

        
        if (player && pause == false)
        {
            // se crea el primer mapa, es redundante esto pero lo quise hacer por distancia
            // con tiempos hubiera sido mas sencillo pero no lo se usar muy bien :(
            
            // Cada vez que el jugador este a 4 metros del mapa creado se creara el siguiente mapa
            if ((player.transform.position.z) > 4 + dist)
            {
                dist += 10;
                rand = Random.Range(0, map.Length);
                int randW = Random.Range(0, wall.Length);
                // los valores en el vector3 los puse asi porque lo visualizo mas facil
                GameObject clonMp = Instantiate(map[rand], new Vector3(0, 3.77f, dist + 5), Quaternion.identity) as GameObject;
                GameObject clonWa = Instantiate(wall[randW], new Vector3(-1.36f, 4.7f, dist + 5), Quaternion.identity) as GameObject;
                // Se destruyen las instancias creadas luego de 10s
                Destroy(clonMp, 8);
                Destroy(clonWa, 8);
                
            }
  
        }    
        
        
    }
}
