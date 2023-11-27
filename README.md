The master branch will include the concise version, while the dev branch will serve as an integration branch for features. In this repository, credentials and sensitive information like .json files with content will be stored in the simple .gitignore file to prevent them from being committed accidentally.

An ASP.NET Core MVC Web Application project named 'EcoPower_Logistics' has been uploaded for enhancement and improvement. The purpose of this project is to demonstrate the skill of adapting and using existing code instead of rewriting it repeatedly. This .NET Core MVC Web Application will then be hosted on the cloud.

For the Product Repository and Product Controller, I implemented the basic-level tier 1 repository pattern. For the remaining repository classes, an advanced-level tier 2 is implemented.

In the class diagram image, note that 'data layer' should be "data layer & Repository layer" only.


 
![diagram drawio](https://github.com/Bongani-4/CMPG-323-Project-3_35016752/assets/140083292/e058a270-2d04-4060-9c33-2f68e7c76d6c)

How data access is divided is as follows:

ProductsController requires the _productRepository.
OrdersController uses the _orderRepository to communicate with order data.
CustomersController interacts with customer data via the _customerRepository.
As a result, the controllers handle HTTP requests, control the data flow between the view classes and repository classes, and provide pertinent responses. The repository classes, on the other hand, access and update the database's data. This separation of data access logic into the repository classes allows for changing the data access strategy without impacting the controllers and follows the SOLID principle of single responsibility.



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



The app is hosted on Microsoft azure,accessed via https://ecopowerlogistics35016752.azurewebsites.net/



reference list
1. Atlassian. "Gitflow Workflow." Atlassian. https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow (Accessed September 6, 2023)
2. Gamma, E., Helm, R., Johnson, R., & Vlissides, J. (1994). Design Patterns: Elements of Reusable Object-Oriented Software. Addison-Wesley.
3. Freeman, E., Robson, E., Bates, B., & Sierra, K. (2004). Head First Design Patterns. O'Reilly Media.

