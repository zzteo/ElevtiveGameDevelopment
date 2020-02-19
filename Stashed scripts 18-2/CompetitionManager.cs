using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompetitionManager : MonoBehaviour
{
    public GameObject unitAvatarPrefab = null;
    public GameObject PlayerStats = null;
    public Transform[] SpawnPoints = null;

    public BaseAI[] ais;
//    public int HP = 0;
//    public int Speed = 0;
//    public int Damage = 1;
//    
//    public int R = 100;

    private List<UnitController> unitAvatars = new List<UnitController>();

    // Start is called before the first frame update
    void Start()
    {
        BaseAI[] aiArray = new BaseAI[] {
            new PlayerScript() 
        };

        for (int i = 0; i < aiArray.Length; i++)
        {
            
            
            GameObject unitAvatar = Instantiate(unitAvatarPrefab, SpawnPoints[i].position, SpawnPoints[i].rotation);
            
            UnitController unitController = unitAvatar.GetComponent<UnitController>();
            StatControl statsController = unitAvatar.GetComponent<StatControl>();
            unitController.SetAI(aiArray[i]);
            unitAvatars.Add(unitController);
            
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
//        if (Input.GetKeyDown(KeyCode.Space)) {
//            foreach (var pirateShip in pirateShips) {
//                pirateShip.StartBattle();
//            }
//        }
        
    }
}
