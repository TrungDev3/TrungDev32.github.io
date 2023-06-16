using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using System.Threading.Tasks;

public class StartScreenScripts : MonoBehaviour
{
    private ThirdwebSDK sdk;
    public GameObject HasNFT;
    public GameObject NoNFT;

    void Start()
    {
        sdk = new ThirdwebSDK("mumbai");
        HasNFT.SetActive(true);
        NoNFT.SetActive(false);
    }
    public async void toggleStartScreen(GameObject ConnectedState, GameObject Disconnectedstate, string address)
    {
        ConnectedState.SetActive(true);
        Disconnectedstate.SetActive(false);
       string stringBalance = await checkBalance(address);
        float floatBalance = float.Parse(stringBalance);

        if(floatBalance > 0)
        {
            HasNFT.SetActive(true);
        }
        else
        {

            NoNFT.SetActive(true);
        }
    
    }

    public async Task<string> checkBalance(string address)
    {
        Contract contract = sdk.GetContract("0xBAdA82fF7e2Cf1D3166683f0d2ef071BeAe8f27B");

        string balance = await contract.Read<string>("balance0f", address, 0);

        return balance;
    }


}
