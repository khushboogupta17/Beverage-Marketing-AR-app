# Beverage-Marketing-AR-app
A beverage marketing app trying to market it’s new products using latest Augmented Reality  technology giving users a refreshing wave of air. It allows users to visualize the new products  and read about it within app and interact with it. 
You can find the video here 
<div align="left">
      <a href="https://www.youtube.com/watch?v=ByGgxsjGyMU">
         <img src="https://github.com/khushboogupta17/Beverage-Marketing-AR-app/blob/main/BeverageMarketing/Builds/SS_3.png" style="width:100%;">
      </a>
</div>
<p>
<img src="https://github.com/khushboogupta17/Beverage-Marketing-AR-app/blob/main/BeverageMarketing/SSBuilding.png" width="20%" height="20%">
<img src="https://github.com/khushboogupta17/Beverage-Marketing-AR-app/blob/main/BeverageMarketing/SSCoffee.png" width="20%" height="20%">
</p>

# Test
FInd the apk [here](https://github.com/khushboogupta17/Beverage-Marketing-AR-app/blob/main/BeverageMarketing/Builds/test1.apk)
and use given image for image recognition
<p>
<img src="https://github.com/khushboogupta17/Beverage-Marketing-AR-app/blob/main/BeverageMarketing/Assets/GoogleARCore/Examples/AugmentedImage/Images/000.jpg" width="20%" height="20%">
</p>

# Technologies Used
Arcore, Unity 2019.4, Visual Studio, DoTween, Blender

# Prototype description 
It is a prototype for any product marketing app. It has various features like  

• _3D Image Target_ – On clicking the coffee model at the top of cafe it will ask for an image and on detecting that image ,a 3D model will be placed on top of that image target .Clicking that model will lead to it’s description. 

• _3D Object on Plane Detection_ – On detection of plane, if clicked anywhere on the  detected plane a 3d model will be placed on the detected plane. 

• _Interaction with 3D object_ – All the 3D models placed in the scene can be rotated and  scaled according to user’s needs. User can do one finger swipe to rotate the building  and two finger pinch in and pinch out to scale the building. 

• _Hotspots_- On clicking the two coffee models, information regarding them can be read.  We can use this space to show information regarding ingredients or customer  feedback of that product. 


# How to use it for creating your own bevarage Marketing app
  -Go to Assets -> Scenes -> Main Scene
 - Add your buidling in root object in heirarchy and set it to building in building manager
 - Change the menu options prefab under menu controller to whatevers products you want to market
 - Add the information inside Beverages option in hierarchy and change the models to your need.
 - Build the app


Ps. It will work for Android greater than 7.0 only that supports ArCore.
