
using Unity.Netcode;
using UnityEngine;

public class NetworkStarter : MonoBehaviour
{
    public bool autoServer;
    public bool autoClient;

    private void Start()
    {
        var net = GetComponent<NetworkManager>();
        if (autoServer)net.StartHost();
        if (autoClient)net.StartClient();
    }
}
