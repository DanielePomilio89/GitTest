using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeMesh : MonoBehaviour {
    public SkinnedMeshRenderer SkinnedMR;
    public MeshFilter meshF;
    Mesh staticMesh;

	void Start () {
        staticMesh = new Mesh();
        meshF.mesh = staticMesh;
    }

    private void OnGUI()
    {
        if (GUILayout.Button("GetStaticMesh"))
            getSnapshot();
    }

    void getSnapshot() {
        SkinnedMR.BakeMesh(staticMesh);
    }
}
aaaa