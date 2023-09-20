 # Project-3
 
 
 ! IGNORE THE "SUPERSTORE P3" FILE APPLOADED A WEEK AGO on main branch, nothing done there.The work i did is on the recent uploaded file found on the master branch.Been working on the main branch untill it started giving me unnecessary problems,so to assess for "11hours on the project", refer to main branch old commmits



 

The master branch will include the concise version whereas the dev one will serve as an integration branch for features.
Again in this repo credentials and sensetive info like .json files with content will be stored in the simple .gitignore file in this repo to prevent them from being committed accidentally.

An ASP.NET Core MVC Web Application project  named 'EcoPower_Logistics' has been uploaded to be  enhanced and improved. This project'purpose is to demonstrate the skill of adapting and using existing code instead of rewriting code over and over again.This  .NET Core MVC Web Applicatiion will then be Hosted on Cloud 

**->** for Product Repository and product controller I implement the (basic level tier 1 ) repository pattern then for the remaining repository classes advanced level tier 2 is implemented. 

On this image is the logical perspective of this web app(note, 'data layer' should be  "data layer &Repository layer" only in this class diagram).

![diagram drawio](https://github.com/Bongani-4/CMPG-323-Project-3_35016752/assets/140083292/e058a270-2d04-4060-9c33-2f68e7c76d6c)

How data access is divided is as follows:

**->** In order to connect with product data,

ProductsController requires the _productRepository.

The _orderRepository is used by OrdersController to communicate with order data.

CustomersController interacts with customer data via the _customerRepository.

As a result, the controllers are in charge of handling HTTP requests, controlling the data flow between the view classes and repository classes, and providing pertinent responses. The database's data is accessed and updated by the repository classes, on the other hand.

Since the data access logic is contained within the repository classes due to this separation, it is possible to change the data access strategy without having an impact on the controllers. Additionally, it follows the SOLID principle of single responsibility.


**current Burn down chart**

Sprint BurnDown Chart												
												
Tasks		Hours	Day 1	Day 2	Day 3	Day 4	Day 5	Day 6	Day 7	Day 8	Day 9	Day 10
"GitHub Administration	Create and Configure GitHub Repository"		0,5	0,5									
Project Progress		0,5	0,5									
Access the existing project		3		2	1							
Connect the Web App to the data source		3			1				1		1	
Create Repository Classes		3			1			2	1			
Transfer data access operations		3		2			-1	-1	1	-2	1	3
Implement repository classes		3		1			1		1			
Web API Cloud Hosting and Security		5		2	1		-2	3				1
	Actual Effort	21	20	13	9	9	11	7	3	5	3	-1
	Estimated Effort	21	18,9	16,8	14,7	12,6	10,5	8,4	6,3	4,2	2,1	0
![image](https://github.com/Bongani-4/CMPG-323--overview/assets/140083292/c720feeb-7cac-42cb-b52f-c9edf2a3a0bb)

![image](https://github.com/Bongani-4/CMPG-323--overview/assets/140083292/ca3698c9-572c-414a-a0ee-911ec1089bd9)








reference list
1. Atlassian. "Gitflow Workflow." Atlassian. https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow (Accessed September 6, 2023)
2. Gamma, E., Helm, R., Johnson, R., & Vlissides, J. (1994). Design Patterns: Elements of Reusable Object-Oriented Software. Addison-Wesley.
3. Freeman, E., Robson, E., Bates, B., & Sierra, K. (2004). Head First Design Patterns. O'Reilly Media.
4. Shalloway, A., & Trott, J. R. (2004). Design Patterns Explained: A New Perspective on Object-Oriented Design. Addison-Wesley.
5. Fowler, M. (2002). Patterns of Enterprise Application Architecture. Addison-Wesley.
6. Evans, E. (2003). Domain-Driven Design: Tackling Complexity in the Heart of Software. Addison-Wesley.
7. Smith, J., & Gass, S. (2014). Pro ASP.NET MVC 5. Apress.
8. Palermo, J., & Barden, R. (2016). ASP.NET Core Application Development: Building an application in four sprints (Developer Reference). Microsoft Press.
9. Smith, A. (2018). ASP.NET Core in Action. Manning Publications.
10. Freeman, A., & Freeman, S. (2009). Pro ASP.NET MVC Framework. Apress.
11. Chinnathambi, A. (2017). Pro .NET Design Patterns in C#: Decorator Design Pattern. Apress.
12. Esposito, D. V. (2017). Implementing the Repository and Unit of Work Patterns in an ASP.NET MVC Application. Microsoft Docs.
13. "ChatGPT. (2021). AI Language Model Developed by OpenAI."
15. Hejlsberg, A., & Rothman, S. (2017). Implementing the Singleton Pattern in C#. Microsoft Docs.
16. Alligieri, M., & Harford, J. (2018). Implementing the Factory Method Pattern in C#. Microsoft Docs.
17. Gang of Four. (n.d.). Observer Design Pattern. Retrieved from https://refactoring.guru/design-patterns/observer
18. Gamma, E., Helm, R., Johnson, R., & Vlissides, J. (n.d.). Strategy Design Pattern. Retrieved from https://refactoring.guru/design-patterns/strategy
19. Fowler, M. (n.d.). Template Method Design Pattern. Retrieved from https://refactoring.guru/design-patterns/template-method
20. Gamma, E., Helm, R., Johnson, R., & Vlissides, J. (n.d.). Singleton Design Pattern. Retrieved from https://refactoring.guru/design-patterns/singleton
21. Freeman, E., & Freeman, S. (n.d.). Decorator Design Pattern. Retrieved from https://www.oreilly.com/library/view/head-first-design/0596007124/ch03.html
22. Shalloway, A., & Trott, J. R. (n.d.). MVC Design Pattern. Retrieved from https://www.netobjectives.com/mvc-design-pattern
23. Freeman, E., & Freeman, S. (n.d.). Command Design Pattern. Retrieved from https://www.oreilly.com/library/view/head-first-design/0596007124/ch06.html
24.  Seemann, M. (2013). Dependency Injection in .NET. Manning Publications.
25. Ziegler, D. (2013). Professional ASP.NET MVC 5. John Wiley & Sons.
26. Nielsen, N. (2017). Building Evolutionary Architectures: Support Constant Change. O'Reilly Media.
27. Cockburn, A. (2001). Agile Software Development: The Cooperative Game. Addison-Wesley Professional.
28. O'Reilly, T. (2006). Web 2.0: Compact Definition?, O'Reilly Media.
29. Fowler, M., & Scott, K. (2009). Domain-Specific Languages. Addison-Wesley Professional.
