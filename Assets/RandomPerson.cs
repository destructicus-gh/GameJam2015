using UnityEngine;
using System.Collections;

public class RandomPerson : MonoBehaviour {
    public Material[] Hair;
    public Material[] Skin;
    public Material[] Clothes;

    public bool genderStereotype;
    



	// Use this for initialization
	void Start () {
        init();

    }
    void init(){
        //Face
        transform.GetChild(0).gameObject.renderer.material = Skin[Random.Range(0, Skin.Length)];
        //Hair
        int hairColor = Random.Range(0, Hair.Length);
        transform.GetChild(3).gameObject.renderer.material = Hair[hairColor];
        transform.GetChild(4).gameObject.renderer.material = Hair[hairColor];
        transform.GetChild(5).gameObject.renderer.material = Hair[hairColor];

        genderStereotype = Random.Range(0, 2) == 1;

        transform.GetChild(4).gameObject.SetActive(genderStereotype);
        transform.GetChild(5).gameObject.SetActive(!genderStereotype);


        transform.GetChild(1).gameObject.renderer.material = Clothes[Random.Range(0, Clothes.Length)];
        transform.GetChild(2).gameObject.renderer.material = Clothes[Random.Range(0, Clothes.Length)];



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
