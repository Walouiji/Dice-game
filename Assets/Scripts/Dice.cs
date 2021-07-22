using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class Dice : MonoBehaviour
{
    private Rigidbody m_rigidbody;
    public Text m_text;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.GetComponent<Rigidbody>() != null)
		{
            m_rigidbody = gameObject.GetComponent<Rigidbody>();
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnMouseDown()
	{
        if(m_rigidbody.IsSleeping())
		{
            m_rigidbody.AddForce(Random.Range(-5, 5), 7, Random.Range(-5, 5), ForceMode.Impulse);
            m_rigidbody.AddTorque(15, 15, 15, ForceMode.Impulse);
            m_text.text = Random.Range(-5, 5).ToString();
        }

	}
}
