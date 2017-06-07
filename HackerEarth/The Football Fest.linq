<Query Kind="Expression" />


Stack Stack = new Stack();
int T,ID,i,j,Passes;
Console.WriteLine("Enter The Number Of TestCases");
T = Convert.ToInt32(Console.ReadLine());
for(i =0; i<T;i++){
	Console.WriteLine("Enter The Number Of Passes");
	Passes = Convert.ToInt32(Console.ReadLine());
	for(j=0;j<Passes;j++){
	Console.WriteLine("What Kind Of Pass Is Player Making?");
	String choise = Console.ReadLine();
	if(choise == "P"){
		Console.WriteLine("Enter The Id Of The Player");
		ID = Convert.ToInt32(Console.ReadLine());
		Stack.Push(ID); 
	}
	else if(choise == "B"){
		Stack.Pop(); 
	}
  }
  	Console.WriteLine("Player " + Stack.Peek());
 }
