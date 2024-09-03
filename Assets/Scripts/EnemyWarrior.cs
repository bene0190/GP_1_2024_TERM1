using UnityEngine;

public class EnemyWarrior : UnitType
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void SpawnSound()
    {
        Debug.Log("Uggghh");
    }
}
