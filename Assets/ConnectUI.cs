using System;
using TMPro;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;
using UnityEngine.UI;

public class ConnectUI : MonoBehaviour
{
    public NetworkManager net;
    
    public Button joinButton;
    public Button hostButton;

    public TMP_InputField ipField;
    public TMP_InputField portField;
    
    
    private void Start()
    {
        joinButton.onClick.AddListener(OnJoin);
        hostButton.onClick.AddListener(OnHost);

        ipField.text = "localhost";
        portField.text = "7777";
    }

    public void OnHost()
    {
        var transport = net.GetComponent<UnityTransport>();
        var port = portField.text;
        if (port == "") port = "7777";

        transport.ConnectionData.Port = Convert.ToUInt16(port);
        net.StartHost();
        Close();
    }

    public void OnJoin()
    {
        var transport = net.GetComponent<UnityTransport>();

        var ip = ipField.text;
        if (ip == "") ip = "127.0.0.1";
        if (ip.ToLower().Trim() == "localhost") ip = "127.0.0.1";
        
        transport.ConnectionData.Address = ip;
        transport.ConnectionData.Port = Convert.ToUInt16(portField.text);
        
        net.StartClient();
        Close();
    }

    void Close()
    {
        Camera.main.GetComponent<FreeFlyCamera>().enabled = true;
        gameObject.SetActive(false);
    }
}
