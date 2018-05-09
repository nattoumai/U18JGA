using UnityEngine;  
using System.Collections;  

public class monochorome : MonoBehaviour {  

	[SerializeField]  
	Material mat;  // かけたい効果のマテリアル  

	void OnRenderImage ( RenderTexture src, RenderTexture dest ) {  
		Graphics.Blit(src, dest, mat);  
	}  
}  