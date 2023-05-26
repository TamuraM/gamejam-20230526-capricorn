using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    int _count;
    public int Count { get { return _count; } }
    [SerializeField] Text _coinText;

    // Start is called before the first frame update
    void Start()
    {
        _count = 0;
        _coinText.text = $"{_count}";
    }

    public void CoinCount()
    {
        _count++;
        _coinText.text = $"{_count}";
    }
}
