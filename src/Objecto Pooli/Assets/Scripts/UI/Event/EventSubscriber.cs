using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;

public class EventSubscriber : MonoBehaviour
{
	public TextMeshProUGUI Text;
	public void Awake()
	{
		Text = GetComponent<TextMeshProUGUI>();
	}

	private void Observer_OnNotify(object sender, NotifyEventArgs e)
	{
		var name = Enum.GetName(e.Type.GetType(), e.Type);
		Debug.Log(name);
		Text.text = $"{name}\nValue: {e.Value}";
	}

	// Start is called before the first frame update
	void Start()
    {
		Observer.OnNotify += Observer_OnNotify;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
