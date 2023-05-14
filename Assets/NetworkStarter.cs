
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;

public class NetworkStarter : MonoBehaviour
{
    public bool autoServer;
    public bool autoClient;

    private void Start()
    {
        var transport = GetComponent<UnityTransport>();
        transport.ConnectionData.Address = "localhost";
        transport.ConnectionData.Port = 7777;
        
        
        var net = GetComponent<NetworkManager>();
        if (autoServer)net.StartHost();
        if (autoClient)net.StartClient();

    }
}
