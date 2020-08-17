# Dependency Injection
	
---

@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt00.jpeg)
@snapend

@snap[east span-40 text-08]
When you go and get things out of the refrigerator for yourself, you can cause problems. You might leave the door open, you might get something Mommy or Daddy doesn't want you to have. You might even be looking for something we don't even have or which has expired.
@snapend
---

@snap[west span-40 text-08]
![Story of Dependency Injection](di/2019-08-06_Comic_The-Story-Of-DI_pt00.jpeg)
@snapend

@snap[east span-40 text-08]
What you should be doing is stating a need, "I need something to drink with lunch," and then we will make sure you have something [proper] when you sit down to eat.
@snapend

---

## How to explain dependency injection to a 5-year old?

 StackOverflow (http://bit.ly/1mBlD78)



---
## Without Dependency Injection


    MessageService service = new MessageService();
    service.Show("Hello World");

---
## Refactoring to Interfaces

    IMessageService service = new MessageService();
    service.Show("Hello World");

---
## Inject Message Service

    public MainWindow(IMessageService service)
    {
        _messageService = service;
    }

    _messageService.Show("hello world");

---
## And Create Injection Container

    // lets register all required components
    var containerBuilder = new ContainerBuiler();
    containerBuilder.Register<IMessageService, MessageService>();
    containerBuilder.Register<MainWindow, MainWindow>();
    
    // lets create the container
    var container = containerBuilder.Build();

    // lets get the window
    var window = container.Resolve<MainWindow>();
    windows.Show();

---
## Injection Methods

* Constructor Injection
 * constructor parameter
 * required dependencies

* Property Injection
 * properties/setter
 * optional parameter
 * null-object pattern

---
## You should know ...

* what Dependency Injection is
* what a DI Container is
* what the difference between 
 * Constructor Injection and 
 * Property Injection is
* what inversion of control means
* when to use Dependency Injection
