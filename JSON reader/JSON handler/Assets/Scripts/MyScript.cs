using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;


public class MyScript : MonoBehaviour {

    double myDate;
   
    public GameObject boxBody, nameTxt, cityTxt, hseTxt, yrsTxt;    
    public List<string> name_list = new List<string>();
    public List<string> cty_list = new List<string>();
    public List<string> hse_list = new List<string>();
    public List<string> yrs_list = new List<string>();
    
    string jsonData;
    int x = 10;
    int loopIncrementer = 0;
    float boxLen = 15;

    public void PerformAction()
    {
        StartCoroutine(MyCandleProgram());
    }



    // Use this for initialization
    IEnumerator MyCandleProgram()
    {
  
        // implememt WWW to get json data from any url
        string url = "http://mysafeinfo.com/api/data?list=englishmonarchs&format=json";
        WWW www = new WWW(url);
        yield return www;

        // store text in www to json string
        if (string.IsNullOrEmpty(www.error))
        {
            jsonData = www.text;
        }

        // use simpleJSON to get values stored in JSON data for different key value pair
        JSONNode jsonNode = SimpleJSON.JSON.Parse(jsonData);

        // get values at the nodes, to get values at node either use the name directly or the position number of the node
        // here instead of "Department", you can also write jsonNode[0][0] 
        Debug.Log("Department 0 " + jsonNode[0].ToString());
        Debug.Log("Department 1 " + jsonNode[1].ToString());


        // get individual values from Department 0 to 40
        
        while (loopIncrementer < 1000)
        {
            loopIncrementer++;

            name_list.Add(jsonNode[loopIncrementer]["nm"].ToString());
            cty_list.Add(jsonNode[loopIncrementer]["cty"].ToString());
            hse_list.Add(jsonNode[loopIncrementer]["hse"].ToString());
            yrs_list.Add(jsonNode[loopIncrementer]["yrs"].ToString());
           
        }
       
        // First make a System.DateTime equivalent to the UNIX Epoch.
        System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);

        // Add the number of seconds in UNIX timestamp to be converted.
        dateTime = dateTime.AddSeconds(myDate);

        // The dateTime now contains the right date/time so to format the string,
        // use the standard formatting methods of the DateTime object.
        string printDate = dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();

        // Print the date and time
        Debug.Log(printDate);

        for (int i = 0; i < 4; i++)
        {

            boxBody.transform.localScale = new Vector3(boxLen, boxLen, 0.2f);
            Instantiate(boxBody, new Vector3(i* 1.1f * boxLen, 0, 0), Quaternion.identity);
       
        }


        for (int i = 0, j = -5; i < 12; i++, j++)
        { 
            nameTxt.GetComponent<TextMesh>().text = name_list[i];
            cityTxt.GetComponent<TextMesh>().text = cty_list[i];
            hseTxt.GetComponent<TextMesh>().text = hse_list[i];
            yrsTxt.GetComponent<TextMesh>().text = yrs_list[i];
            Instantiate(nameTxt, new Vector3(-6.5f, j * 1.1f, 0), Quaternion.identity);
            Instantiate(cityTxt, new Vector3(10f, j * 1.1f, 0), Quaternion.identity);
            Instantiate(hseTxt, new Vector3(26f, j * 1.1f, 0), Quaternion.identity);
            Instantiate(yrsTxt, new Vector3(45f, j * 1.1f, 0), Quaternion.identity);
        }
    }

   
   
}
