Exercise
https://www.youtube.com/watch?v=33rjD9lJCrM&list=PLp1Emx1rT4z8ERpI_4tKnV3ZOqnA5mjpU&index=2

solution
we will see -
how to create database setup for creating pagination?(check #1) 
how to create pagination in asp.net web application with help of mvc ? (check #2)


--------------------------------------------------------------------------------------------------------------------#1
how to create database ? 

first downlaod mongobooster and then connect to the mongodb

Q-how to create database?
step-1
create database name (i taken productmanagementdb)

Q-how to insert raw data into instant created collection (collection create and sampledata insertion both will be on same time) 
step-2
In previous step databse has been created on your left panel and click on database (productmanagementdb) we will insert some test(sample-data) for veiwing purpose

On top right panel you can see "Test Data"  option click on this for inserting data(raw sample-data) 
>one panel will popup(test data generator) 
>Insert data for 3 only (name username email) for other close sign is there use that
> on the same panel below choose database "productmanagementdb" and in collection "userinfo" and Doc count "100"
collection has been created 1M> document has been inserted. i aborted script in between ,if time is taking so much you can do same as well
for security purpose you can create user (i have created user )

Q-how to create user
step-3
right click on database name (productmanagementdb) and "User and Role"> "Add User">add user 

one script file will genrate and then change "username" and "pwd"& role ""as "whatever(but this username have to put in to project web.config file)" 

username = "mr"
pwd = "gautam"
role = "readWrite"
----------------------------------------------------------------------------------------------------------------------#1


----------------------------------------------------------------------------------------------------------------------#2
how to create pagination in asp.net web application with help of mvc ?

step-1
first create database in mongodb name as "productmanagementdb"  check out how to create above 

step-2
open web config file and add key under app setting in my project already has been setup
 <add key="MongoDBHost" value="mongodb://username:pwd@localhost:27017/DatabaseName" />
 <add key="MongoDBName" value="DatabaseName" />

step-3
open controllers and right click on it , select controller and select MVC5 controller with read write action and click on add
name - UserInfoController.cs


write all logic inside it >for veiwing logic go into my github account manishgautam120

on index create veiw page by add veiw , by right clicking on index  
step-4
build code and go for localhost : 5000/userinfo

step-5
right click on project and click on manage nuget manager to install PagedList.MVC

step-6
write code on UserInfoController.cs  
----------------------------------------------------------------------------------------------------------------------#2

run on browser localhost://portnumber/userinfo



WrittenBy- Darkness
emailid-manishgautam120@gmail.com
