using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class firebase_script : MonoBehaviour
{
    DatabaseReference reference;
    public GameObject TrainingTable;
    string speed;
    int rot;
    // Start is called before the first frame update
    void Start()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://unity-2a83d.firebaseio.com/");
        //Console.WriteLine("connected");

        // Get the root reference location of the database.
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        TrainingTable = GameObject.Find("TrainingTable");
    }
    // Update is called once per frame

    void Update()
    {
        FirebaseDatabase.DefaultInstance.GetReference("rotation").ValueChanged += HandleValueChanged;

    }
    public void HandleValueChanged(object sender, ValueChangedEventArgs e)
     {
         if (e.Snapshot.Exists)
         {
             speed = e.Snapshot.GetValue(true).ToString();
            rot = int.Parse(speed);
            //.Child("rotation").GetValue(true);
             TrainingTable.transform.Rotate(new Vector3(0, rot , 0));
         }
     }


    /* LoadData()
    {
         
    }*/

}
