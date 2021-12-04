# Augmented Reality App for Wild Animal Mental Emotions –– Animality

Video link: https://youtu.be/lFrE6MkDrZY

1  Project Description

「Animality」 is an AR app about presenting the mental emotions of wild animals, visualizing these mental emotions through augmented reality technology so that people can feel the plight of wild animals in a more visual way. I superimposed virtual animal scenes generated by Unity3D onto the real environment through the Vuforia augmented reality plugin, overlaid with audio, and the user can observe the animal in 15 different negative emotions from the app. Animal behaviour and emotional changes are presented in real time in the real environment, and users will feel the suffering of wild animals, thus drawing the attention of society and triggering people to care for and protect this group.

2  Project Development Process

The project is based on Unity3D + Vuforia augmented reality technology to develop an app with interactive features to superimpose the generated virtual animal scenes onto the real environment. 3DS Max is mainly used for pre-set modelling, animal modelling and animal animation design, and later I will use the Vuforia SDK integrated with the Unity engine to create AR applications.

3  Algorithm Theory

The algorithm used for the image feature recognition technique in this project is AKAZE (accelerated-KAZE). The AKAZE feature extraction algorithm based on the construction of a non-linear scale space is highly accurate and more optimised. The whole matching process is based on feature extraction plus kmeans tree for approximate nearest neighbour matching, and then the key pairs are mapped for uni-responsiveness and finally scored according to the inlier point set to determine the final target. There is more than one algorithm used for image recognition, including how to determine image features to get comparison information, and tracking recognition based on image features, for example.

4  Project Outcomes

This project is based on the release of an application in apk format for the ios platform. The released apk file will be sent to the mobile phone, which can be downloaded and installed to test the results of its use.
