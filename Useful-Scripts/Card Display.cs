//Para que possamos mostrar as informações de um scriptable object em nossa UI ingame, precisamos desse script,
//que vai designar qual elemento da UI (ou seja quais partes do Game Object do tipo UI criado na Unity)vão mostrar
//os dados que queremos.
//Para fazer isso precisamos criar um COMPONENT no Game Object que queremos usar para mostrar nosso Card,
//usando o caminho Game Object > Add Component > Digitar nome do script e criar OU selecionar New Script > C# > Create and Add.


public class CardDisplay : MonoBehaviour 
{
  public Card card;
  //"public" para que seja acessível por todos os métodos e mostrado no menu Inspector da Unity.
  //"Card" pois é o nome do nosso Scriptable Object criado no projeto.
  //"card" é o nome do campo que será mostrado e acessado por esse e outros scrpits.

//Usando o método "Start" pois a carta será gerada ao iniciar o jogo, no nosso caso.
void Start () 
  {
  Debug.Log(card.name);  //Isso pode exemplo acessa a variável "name" dentro do scriptable object que criamos, mostrando ela 
  //na parte do console.
  //OU PODEMOS USAR ISSO:
  card.Print();
  //Que chama o método Print que foi criado no Scriptable Object em questão.
  }
}


//Depois de fazer isso, devemos arrastar o scriptable object que queremos acessar os dados para o novo component,

//Em resumo: Inicialmente criamos o Scriptable Object chamado Card. Depois criamos o "CardDisplay", que é
//um component(um script) dentro do Game Object "Card", que tem o campo chamado "card", que como tem "public,
//na frente, podemos ver no inspector da unity.
//(Por isso escrevemos public Card card;)
//significando que publicamente, o vamos conseguir acessar dados dentro do scriptable object Card, com a keyword "card";
//Depois desse código, arrastamos o Scriptable Object para dentro do component criado "public Card card;", e agora
//conseguimos acessar os dados do Scriptable Object arrastado para o component usando "card.informacaoNecessaria;"
//Isso é feito antes de qualquer método pois assim fica disponível para todos os métodos que podemos criar depois.


//Exemplo de código limpo

public class CardDisplay : MonoBehaviour 
{

public Card card;

void Start () 
  {
  Debug.Log(card.name);
  OU
  card.Print();
  }
}



using UnityEngine.UI; //Isso server pra usar elementos de UI que constam na Unity como biblioteca também,
//podendo criar variáveis tipo Text ou Sprite e etc.


using UnityEngine.UI

public class CardDisplay : MonoBehaviour 
{

public Card card;

public Text nameText;
public Text descriptionText;

public Image artworkImage;

public Text manaText;
public Text attackText;
public Text healthText;

void Start () 
  {
  nameText.text = card.name;
  descriptionText.text = card.description;
  
  artworkImage.sprite = card.artwork;
  
  manaText.text = card.manaCost.ToString();
  attackText.text = card.attack.ToString();
  healthText.text = card.heatlh.ToString();
  }
}
//Melhor opção de código. Assim temos a biblioteca Unity Engine UI acionada, e criamos os campos
//nameText, artworkImage, manaText, etc, que é visível no Inspector do Unity. Assim, neles podemos colocar os
//Game Objects que serão alterados para mostrar na UI o que queremos mostrar.
//EX:
//nameText.text = card.name;
//(no campo "nameText" mostraremos uma variável de texto "text" que será igual "=" à informação contida 
//no Scriptable Object Card, que é acessado com a keyword "card", sendo que queremos a informação chamada "name"
//de dentro dele.)
//Como isso tudo ocorre no método Start, assim que dermos Play na Unity essas infos vão mudar.
