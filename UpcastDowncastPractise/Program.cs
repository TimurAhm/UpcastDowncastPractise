using UpcastDowncastPractise;

Human human = new Human()
{
    name = "Василий 950",
    sex = "Male",
    age = 950,
};


//Alkash alkash = (Alkash)human;
Alkash alkash = new Alkash()
{
    name = "Витек 3000",
    age = 3000,
    sex = "Male"
};


Alkash UniversalAlkash = new Alkash()
{
    name = "УНИВЕРСАЛЬЫНЙ АЛКАШ",
    age = 99999,
    sex = "SigmaMale"
};



//UniversalAlkash.SayHello();
//UniversalAlkash.HelloFromZapoy();
//Human alkash1 = new Alkash()
//{ 
//    name = "Наталья",
//    age = 30,
//    sex = "Female"
//};


Human cast = alkash; //Upcast


Alkash downcast = cast as Alkash; // Downcast с сахаром as. Он так же проверяет как и is, но если проверка не пройдет, он вернет не исключение, а null

if (downcast != null)
{
    downcast.HelloFromZapoy();
}
//или
if (cast is Alkash downcast1) // Downcast с сахаром is (доступно с вижуалки 2017), до этого все делалось через bool --> (bool IsAlkash = cast is Alkash; \n if(IsAlkash) { Alkash downcast = (Alkash)cast }; )
{
    downcast1.HelloFromZapoy();
}




//upcast.HelloFromZapoy();

//human.SayHello();
//alkash.HelloFromZapoy();

