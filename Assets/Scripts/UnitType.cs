using UnityEngine;

public class UnitType : MonoBehaviour
{
    public string className;

    public void Start()
    {
        SpawnSound();
    }
    public virtual void SpawnSound()
    {
        Debug.Log("sound of the unit dying");
    }
   
}
