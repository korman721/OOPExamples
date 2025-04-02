using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private Coin _coin;

    public bool IsEmpty
    {
        get
        {
            if (_coin == null)
                return true;

            if (_coin.gameObject == null)
                return true;

            return false;
        }
    }
    public Vector3 Position => transform.position;

    public void Occupy(Coin coin)
    {
        _coin = coin;
    }
}
