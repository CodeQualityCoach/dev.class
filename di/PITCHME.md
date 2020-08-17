# Dependency Injection
---
@title[DI to a 5yo]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt00.jpeg)
@snapend

@snap[east span-40 text-08]
"When you go and get things out of the refrigerator for yourself, you can cause problems. You might leave the door open, you might get something Mommy or Daddy doesn't want you to have. You might even be looking for something we don't even have or which has expired." ~[StackOverflow](http://bit.ly/1mBlD78)
@snapend
+++

@title[DI to a 5yo]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt00.jpeg)
@snapend

@snap[east span-40 text-08]
What you should be doing is stating a need, "I need something to drink with lunch," and then we will make sure you have something [proper] when you sit down to eat. ~[StackOverflow](http://bit.ly/1mBlD78)
@snapend
---

@title[This is a Dependency]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt01.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[S-R-P]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt02.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[The Dark Ages]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt03.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
+++

@title[Without Dependency Injection]
@snap[west span-40 text-08]
@snapend

@snap[east span-40 text-08]
    MessageService service = new MessageService();
    service.Show("Hello World");
@snapend
+++

@title[Refactoring to Interfaces]
@snap[west span-40 text-08]

    IMessageService service = new MessageService();
    service.Show("Hello World");@snapend

@snap[east span-40 text-08]
@snapend
+++

@title[Inject Message Service]
@snap[west span-40 text-08]

    public MainWindow(IMessageService service)
    {
        _messageService = service;
    }

    _messageService.Show("hello world");

@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Let is Run for...]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt04.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Clean Code Winner]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt05.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Get It Done]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt06.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Inversion of Control]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt07.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Inject Dependencies]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt08.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Injection Magic]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt09.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
+++

@title[Injection Methods]
@snap[west span-40 text-08]
@ul
- Constructor Injection
 	- constructor parameter
 	- required dependencies

- Property Injection
 	- property setter
 	- optional parameter

- Method Injection
	- method parameter
	- "it depends"/dynamic parameter
@ulend
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[The Bauhaus]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt10.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[The Inventory]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt11.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
+++

@title[Create Injection Container]
@snap[west span-40 text-08]

    // lets register all required components
    var containerBuilder = new ContainerBuiler();
    containerBuilder.Register<IMessageService, MessageService>();
    containerBuilder.Register<MainWindow, MainWindow>();
    
    // lets create the container
    var container = containerBuilder.Build();

    // lets get the window
    var window = container.Resolve<MainWindow>();
    windows.Show();

@snapend

@snap[east span-40 text-08]
@snapend
+++

@title[When I'm Gone]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt12.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[The Highlander]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt13.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[The Minions]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt14.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Kitty, Kitty, Kitty]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt15.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Per Request]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt16.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Container Scopes]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt17.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[AOP]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt18.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[The Story so far]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt19.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[SRP DI School]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt20.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Hogwards Wizards]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt21.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[Lifetime Sematory]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt22.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

@title[The End]
@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt23.jpeg)
@snapend

@snap[east span-40 text-08]
@snapend
---

