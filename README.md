# Beverage-Marketing-AR-app
A beverage marketing app trying to market it’s new products using latest Augmented Reality  technology giving users a refreshing wave of air. It allows users to visualize the new products  and read about it within app and interact with it. 
![screenshot](https://github.com/khushboogupta17/Beverage-Marketing-AR-app/blob/main/BeverageMarketing/SSBuilding.png)
![screenshot](https://github.com/khushboogupta17/Beverage-Marketing-AR-app/blob/main/BeverageMarketing/SSCoffee.png)

# Test
FInd the apk at [here](Beverage-Marketing-AR-app/tree/main/BeverageMarketing/Builds)
and use given images for image recognition
# Technologies Used
Arcore, Unity 2019.4, Visual Studio, DoTween, Blender

# Prototype description 
It is a prototype for any product marketing app. It has various features like  

• _3D Image Target_ – On clicking the coffee model at the top of cafe it will ask for an image and on detecting that image ,a 3D model will be placed on top of that image target .Clicking that model will lead to it’s description. 

• _3D Object on Plane Detection_ – On detection of plane, if clicked anywhere on the  detected plane a 3d model will be placed on the detected plane. 

• _Interaction with 3D object_ – All the 3D models placed in the scene can be rotated and  scaled according to user’s needs. User can do one finger swipe to rotate the building  and two finger pinch in and pinch out to scale the building. 

• _Hotspots_- On clicking the two coffee models, information regarding them can be read.  We can use this space to show information regarding ingredients or customer  feedback of that product. 

# Images for Image Recognition


# How to use it for creating your own bevarage Marketing app
  -Go to Assets -> Scenes -> Main Scene
 - Add your buidling in root object in heirarchy and set it to building in building manager
 - Change the menu options prefab under menu controller to whatevers products you want to market
 - Add the information 
 - Build the app


Ps. It will work for Android greater than 7.0 only that supports ArCore.
