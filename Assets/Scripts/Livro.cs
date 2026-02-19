using UnityEngine;

public class Livro : MonoBehaviour

{
  public GameObject prefab;
  int mana =10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()  {


           if (Input.GetKeyDown(KeyCode.Space) && (mana>0)) {
Instantiate (prefab,transform.position,Quaternion.identity);
mana-- ;
Debug.Log ("Mana restante:" + mana);

           }

    if (Input.GetKeyDown(KeyCode.Space) && (mana==0)); {
    Debug.Log ("Sem Mana! Beba uma poção (R)");

}

    if (Input.GetKeyDown(KeyCode.R) && (mana==0)); {

    Debug.Log("Mana restaurada");
    mana +10;
}



    }
}
