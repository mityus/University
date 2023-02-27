using UnityEngine;
using Random = UnityEngine.Random;

public class RandomingNumbers : MonoBehaviour
{
    private int _randomNumber = 7;

    private void Update()
    {
        Randomize();
    }

    private void Randomize()
    {
        _randomNumber = Random.Range(0, 100);
        
        Debug.Log(_randomNumber);

        if (_randomNumber == 3) Debug.Log("Checking conditions");
    }

}
