// 1 - Singleton 
//using Design_Patterns.Singleton;

//Singleton s1 = Singleton.GetInstance();
//Singleton s2 = Singleton.GetInstance();
//s1.Name = "abderrahim";
//Console.WriteLine(s1.Name);
//Console.WriteLine(s2.Name);
//Console.ReadLine();

// 2 - Prototype Pattern :

//using Design_Patterns.Prototype;

//Person p1 = new Person(1, "abderrahim", 20);
//p1.MethodA();
//Person p2 = p1.Clone();
//p2.MethodA();
//Person p3 = p1.Clone();
//p3.MethodA();
//Console.ReadLine();

// 3  - Proxy Pattern :
//using Design_Patterns.Proxy;

//IHome proxy = new Proxy("Home","hchc");
//proxy.Display();



// 4 - state pattern
//using Design_Patterns.State;

//MusicPlayer musicPlayer = new MusicPlayer();
//while(musicPlayer != null)
//{
//string action = Console.ReadLine();
// if(action == "stop")
//  {
//     musicPlayer.Stop();
//  }else if(action == "play")
//  {
//     musicPlayer.Play();
//  }
// else
//  {
//    musicPlayer.Pause();
//  }
//}

//Console.ReadLine();


// 5 - abstract factory pattern:

//using Design_Patterns.Abstract;

//Client student = new Client(new ElegantClothesFactory());
//student.Display();



// 6 - Builder Pattern :
//using Design_Patterns.Builder;
//IClubBuilder realMadrid = new RealMadrid();
//Director director = new Director(realMadrid);
//director.ConstractClub();
//Club club = director.GetClub();
//club.Print();
















