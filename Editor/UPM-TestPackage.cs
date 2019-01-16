using UnityEngine;
using UnityEditor;

public class UPMTestPackage : Editor {
    [MenuItem("UPM TestPackage/Print message")]
    static void Print() {
        Debug.Log("Looks like the UPM-TestPackage was installed correctly.");
    }
}