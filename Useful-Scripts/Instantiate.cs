using UnityEngine;
using System.Collections;

public class CsharpCourse : MonoBehavior 
{
  
  public GameObject ball; //Criando uma GameObject no Inspector para que coloquemos o prefab dentro.
  
  void Start()
  {
    Inst();
    
  }
  
  void Inst()
  {
    Instantiate(ball, transform.position, transform.rotation); 
    
    //Instanciando o objeto criado, usando posição e rotação do
    //objeto vazio que o script está atrelado.
  }
  
}
