# Overview

In this project you will find

* How to start the application
* What you can "Do" with the application
* Tests that you can explore
* How the application works


# How to start the application

## 0. Prerequisites

Make sure you have [Visual Studio installed.](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019) 

Make sure you have .NET Core 2.2 as part of your install (2.1 LTS will work fine too).

## 1. Turning on the API Layer

Run the application on Visual Studio using IIS Express. 

This will make the API accessible at http://localhost:44300/api/users


# What you can "Do" with the application?

The application allows you to save and delete users to a database, but is without a frontend client. The frontend client is substituted by **Postman**.

## Checkout the overview documentation


1. [Follow this Postman link to be invited into the project's API collections](https://app.getpostman.com/join-team?invite_code=4bb20642af835a89d5f6d32f6eca676b)

2. Navigate to Team workspaces or [press this link](https://speeding-crater-8783.postman.co/collections/8805870-79a315fb-9f53-45e7-913e-0b067c42ff88?version=latest&workspace=05213688-04f5-4973-86ee-91f2be3e7826) to go there directly to view the documentation overview.

3. On the top, Select the Environment to `Development` to set the variables
![Set Environment Image](https://i.imgur.com/XfVBowh.png)



## Postman? 
![Postman icon](https://assets.getpostman.com/common-share/postman-logo-horizontal-white.svg)
Postman provides a convenient interface to call APIs, run tests and persists your arguments in a beautified box, so you don't lose what you were typing when switching between APIs.

## Is there more? 
> You can only view the documentation in the online interface, download the Postman app next!

**Be sure to [download the app](https://www.getpostman.com/downloads/) to proceed.**
We will use Postman to run our tests and interact with the application.

## Setting up the testing environment

So that you can run the tests, and have a convenient place from which call the database, we need to set up your local testing environment.

Now that you have Postman installed,

1. Log in and find the Users Collections in the Team Workspace 

2. Set the Environment. On the top left, Select the Environment to `Development` to set the variables. This allows the tests to run properly.
![Set Environment App Image](https://i.imgur.com/y3v2CuN.png)

3. Turn off your SSL certificate verification in Settings. (Turn this on again after you've using the application!)


## Running your first test!

Assuming the application has been ran on VS using IIS, go ahead and run the `GET Users` request. 

> `GET Users` pulls all the users in the database.

> `GET User by Id` pulls an individual user by the Id.

> `POST New User` creates a new user in the database.

> ...


## API Tests

When you have `POST New User` selected, you will notice that theres a *Tests* tab. This shows the API tests that the application runs everytime its posted.

Written in javascript, to see the results of the tests attempt to create the user, and review the Response section.

![Tests successful Image](https://i.imgur.com/pxPxa7w.png)

> If any of the tests fail, make sure you have the environment selected to "Development" at the top.
