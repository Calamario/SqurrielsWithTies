# Squrriels with Ties
ecomagmn.azurewebsites.net

Create a E-Commerce Website built using sprints and agile programming. ASP.NET core was used as a framework for building out the application

## What do we sell?
Our E-commerce site sells an assortment of squirrel based merchendise. From unsual squrriel mints to squirrel masks, we try to gather as many squrriel 
based goodies for purchase to the general public.

## Claims Captured and Why
We are currently capturing Name, Email, and their favorite animal. The name is captured so that we are able to display a personalized experience 
as soon as the user registers or logs in. The favoirte animal is captured for users to access a animal-lover page where they are able to vote on
the next animal merchnendise we are going to sell. (The Page is under construction) Finally, Email is captured and not currently used but we forsee 
its use in the future to verify purchases(Perhaps).

## Policy we are enforcing
We are enforcing two policies at the monment. AdminOnly and HasFavAnimal. AdminOnly policy allows access to the admin controller only if your role
is admin. There, admins are currently able to create, update, get, delete any of the products in the inventory. The HasFavAnimal checks for the claim
FavoriteAnimal for the user. If there the user has a favorite animal they have access to the feedback controller where we hope to include a feedback
form in the future where user can vote/comment on future profucts.

## Getting Started
Go to the Website

# Authors
Anthony Green
Mario Nisho
