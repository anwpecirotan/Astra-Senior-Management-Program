using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;
using TMPro;

public class PokeRequest : MonoBehaviour
{
    public RawImage pokeRawImage;
    public Text pokeNameUI, pokeEntryUI;
    public Text[] pokeTypeTextArray;
    public Dropdown pokemonListDropDown;

    private readonly string basePokemonURL = "https://pokeapi.co/api/v2/";
    void Start()
    {
        pokeRawImage.texture = Texture2D.blackTexture;

        pokeNameUI.text = "";
        pokeEntryUI.text = "";
        pokemonListDropDown.ClearOptions();

        foreach(Text pokeTypeText in pokeTypeTextArray)
        {
            pokeTypeText.text = "";
        }
    }
    public void _OnButtonListPokemon()
    {
        
     
            StartCoroutine((GetListPokemon(30,0)));
        
    }


    public IEnumerator GetListPokemon(int limit, int start)
    {
        print("loading");

        string pokemonURL = basePokemonURL + "pokemon?limit="+limit+"&offset="+start;
        UnityWebRequest pokeListRequest = UnityWebRequest.Get(pokemonURL);
        yield return pokeListRequest.SendWebRequest();

        if (pokeListRequest.isNetworkError || pokeListRequest.isHttpError)
        {
            Debug.LogError(pokeListRequest.error);
            yield break;
        }
        else
        {
            print("loaded");
        }
       

        JSONNode pokeListInfo = JSON.Parse(pokeListRequest.downloadHandler.text);
        JSONNode pokeLists = pokeListInfo["results"];

        string[] pokeList = new string[pokeLists.Count];

        for (int i = 0, j = pokeLists.Count - 1; i < pokeLists.Count; i++, j--)
        {
            pokeList[j] = pokeLists[i]["name"];
            pokemonListDropDown.options.Add(new Dropdown.OptionData() { text = pokeList[j] });
            print(pokeList[j]);
        }

        
    }

    

    public void _OnButtonRandomPokemon()
    {
        int randomPokemonIndex = Random.Range(1, 808);

        pokeRawImage.texture = Texture2D.blackTexture;

        pokeNameUI.text = "Loading...";
        pokeEntryUI.text = "#";

        foreach(Text pokeTypeText in pokeTypeTextArray)
        {
            pokeTypeText.text = "";
        }

        StartCoroutine(GetPokemonAtIndex(randomPokemonIndex));
    }

    IEnumerator GetPokemonAtIndex(int pokemonIndex) {
        string pokemonURL = basePokemonURL + "pokemon/" + pokemonIndex.ToString();

        //================ Get Pokemon Info =======================
        // Name, URL- Sprites, Type 1, Type 2
        UnityWebRequest pokeInfoRequest = UnityWebRequest.Get(pokemonURL);
        // >> PokeInfoRequest
        yield return pokeInfoRequest.SendWebRequest();

        if (pokeInfoRequest.isNetworkError || pokeInfoRequest.isHttpError)
        {
            Debug.LogError(pokeInfoRequest.error);
            yield break;
        }
        // >> PokeInfoRequest > pokeInfo
                               //-Name
                               //-sprites > front_default
        JSONNode pokeInfo = JSON.Parse(pokeInfoRequest.downloadHandler.text);

        string pokeName = pokeInfo["name"];
        string pokeSpriteURL = pokeInfo["sprites"]["front_default"];
        
        // >> PokeInfoRequest > pokeInfo
                                //-types > name
        JSONNode pokeTypes = pokeInfo["types"];
        string[] pokeTypesName = new string[pokeTypes.Count];

        for (int i = 0, j = pokeTypes.Count - 1; i < pokeTypes.Count; i++, j--)
        {
            pokeTypesName[j] = pokeTypes[i]["type"]["name"];
        }

        //================ Turn URL Sprites to actual Texture =======================

        UnityWebRequest pokeSpriteRequest = UnityWebRequestTexture.GetTexture(pokeSpriteURL);

        yield return pokeSpriteRequest.SendWebRequest();
        if (pokeSpriteRequest.isNetworkError || pokeSpriteRequest.isHttpError)
        {
            Debug.LogError(pokeSpriteRequest.error);
            yield break;
        }
        Texture2D pokeTexture = DownloadHandlerTexture.GetContent(pokeSpriteRequest);

        //======================= Setting UI ===============================

        pokeRawImage.texture = pokeTexture;
        pokeNameUI.text = pokeName;
        pokeEntryUI.text = "#" + pokemonIndex.ToString();
        for(int i = 0; i < pokeTypesName.Length; i++)
        {
            pokeTypeTextArray[i].text = pokeTypesName[i];
        }
    }


    public void _OnPickPokemonDropDown()
    {
        StartCoroutine(GetPokemonAtName(pokemonListDropDown.options[pokemonListDropDown.value].text));
       
    }
    IEnumerator GetPokemonAtName(string pokemonName)
    {
        string pokemonURL = basePokemonURL + "pokemon/" + pokemonName;

        //================ Get Pokemon Info =======================
        // Name, URL- Sprites, Type 1, Type 2
        UnityWebRequest pokeInfoRequest = UnityWebRequest.Get(pokemonURL);
        // >> PokeInfoRequest
        yield return pokeInfoRequest.SendWebRequest();

        if (pokeInfoRequest.isNetworkError || pokeInfoRequest.isHttpError)
        {
            Debug.LogError(pokeInfoRequest.error);
            yield break;
        }
        // >> PokeInfoRequest > pokeInfo
        //-Name
        //-sprites > front_default
        JSONNode pokeInfo = JSON.Parse(pokeInfoRequest.downloadHandler.text);
        //print(pokeInfo);
        string pokeName = pokeInfo["name"];
        string pokemonIndex = pokeInfo["order"];
        string pokeSpriteURL = pokeInfo["sprites"]["front_default"];

        // >> PokeInfoRequest > pokeInfo
        //-types > name
        JSONNode pokeTypes = pokeInfo["types"];
        print(pokeInfo["types"]);
        string[] pokeTypesName = new string[pokeTypes.Count];

        for (int i = 0, j = pokeTypes.Count - 1; i < pokeTypes.Count; i++, j--)
        {
            pokeTypesName[j] = pokeTypes[i]["type"]["name"];
         
        }

        //================ Turn URL Sprites to actual Texture =======================

        UnityWebRequest pokeSpriteRequest = UnityWebRequestTexture.GetTexture(pokeSpriteURL);

        yield return pokeSpriteRequest.SendWebRequest();
        if (pokeSpriteRequest.isNetworkError || pokeSpriteRequest.isHttpError)
        {
            Debug.LogError(pokeSpriteRequest.error);
            yield break;
        }
        Texture2D pokeTexture = DownloadHandlerTexture.GetContent(pokeSpriteRequest);

        //======================= Setting UI ===============================

        pokeRawImage.texture = pokeTexture;
        pokeNameUI.text = pokeName;
        pokeEntryUI.text = "#" + pokemonIndex;
        for (int i = 0; i < pokeTypesName.Length; i++)
        {
            pokeTypeTextArray[i].text = pokeTypesName[i];
        }
    }


    void Update()
    {
        
    }
}
