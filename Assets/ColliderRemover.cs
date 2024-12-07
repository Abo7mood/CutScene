using UnityEngine;
using UnityEditor;

public class ColliderRemover : MonoBehaviour
{
    [MenuItem("Tools/Remove Collider And Apply Prefab Changes %#p")]
    //public static void RemoveEmptyMeshColliders()
    //{
    //    var prefabGuids = AssetDatabase.FindAssets("t:Prefab");
    //    var length = prefabGuids.Length;
    //    for (var i = 0; i < length; ++i)
    //    {
    //        var guid = prefabGuids[i];
    //        var path = AssetDatabase.GUIDToAssetPath(guid);
    //        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);

    //        var colliders = prefab.GetComponentsInChildren<MeshCollider>();
    //        foreach (var collider in colliders)
    //        {
                
    //            Object.DestroyImmediate(collider, true);
    //            Debug.Log("Destroyed collider on prefab " + prefab.name);
    //        }
    //    }
    //    var gameObjects = Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[];
    //    foreach (var gameObject in gameObjects)
    //    {
    //        var colliders = gameObject.GetComponentsInChildren<MeshCollider>();
    //        foreach (var collider in colliders)
    //        {
                
    //            Object.DestroyImmediate(collider, true);
    //            Debug.Log("Destroyed collider on gameObject " + gameObject.name);
    //        }
    //    }
    //}
    public static void RemoveEmptyBoxColliders()
    {
        var prefabGuids = AssetDatabase.FindAssets("t:Prefab");
        var length = prefabGuids.Length;
        for (var i = 0; i < length; ++i)
        {
            var guid = prefabGuids[i];
            var path = AssetDatabase.GUIDToAssetPath(guid);
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);

            var colliders = prefab.GetComponentsInChildren<BoxCollider>();
            foreach (var collider in colliders)
            {

                Object.DestroyImmediate(collider, true);
                Debug.Log("Destroyed collider on prefab " + prefab.name);
            }
        }
        var gameObjects = Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[];
        foreach (var gameObject in gameObjects)
        {
            var colliders = gameObject.GetComponentsInChildren<BoxCollider>();
            foreach (var collider in colliders)
            {

                Object.DestroyImmediate(collider, true);
                Debug.Log("Destroyed collider on gameObject " + gameObject.name);
            }
        }
    }

}