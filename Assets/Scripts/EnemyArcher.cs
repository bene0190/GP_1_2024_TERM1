using UnityEngine;
using Orc;
public class EnemyArcher : UnitType
{
    public int hp;

    private readonly EnemyManager EM = EnemyManager.instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();
        hp = EM.enemyArcherHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void SpawnSound()
    {
        Debug.Log("Rawr");
    }
}
