USEFUL STUFF
Debug.Log("Print shit inside Console");
Destroy(gameObject, 3f); //Destroy target game object fater the amount of time specified
Random.Range(0, 7); //chooses a random number between te first a last one
Quaternion.Euler(x.y.z);//Stores rotation.


VARIABLES

int a = 5; //Integers
float b = 2.4f;  //Float numbers
string myName = "Cauê"; //Text values
bool switch = true;  //True or false

START VS AWAKE

Awake is called BEFORE Start. Both only are called once in the lifetime.
Awake is called even if the script is not enabled in the inspector.

FUNCTIONS/METHODS //Sameshit

void Function(){} //No return value from the function, needs to be called inside another method
//>>>>>>>>>>>>> to call it write "FunctionName();" - no quotes

int Shoot(int damage) //When calling this fucntion you need to pass it an INT value for damage variable.
{
  Debug.Log("Your shot did" + damage);
  return (damage * 2);
}
//To use the return value of this method do the following:
int a = Shoot(5);
Debug.Log (a);
//This statement passes the value for damage inside Shoot(); function, stores it in the
//variable 'a' and then Debugs it in the console.

WHILE/FOR LOOP

while(i < 3){
  Debug.Log("The value of 'i' is" + i);
  i++;
}
//While the condition is met, the loop will repeat, and u need to increment the var inside the loop.

for( i = 1, i < 5, i++)
{
  Debug.Log("The value of i is" + i);
}
//The paramenters are "Variable initialize, condition, increment". A "compact" version of While.

ARRAYS

int arr[] = (2,5,7,9); //Declares the array and set its values at once
//----------------
int arr[]; //Declaring the array
arr = new int[5]; //Definig it's size
arr[2] = 5; //Give each index a individual value
//----------------

FOREACH LOOP
// This loop takes each index of the array and stores, one by one, in the 'i' variable;
public int arr[];

foreach(int i in arr) //This means 'For each value in 'arr' store it in 'i';
{
  Debug.Log(i);
}
