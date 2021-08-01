using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURLLink : MonoBehaviour
{
  
    public void OpenLink()
    {
        Application.OpenURL("https://docs.google.com/document/d/1lswnRUyXYXqxwsrUTIThSms5hSlua_5NJwI5DkIEmfg/edit?usp=sharing");
    }
   
}
