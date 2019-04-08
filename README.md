# LILIN AI Engine Sample Code & SDK
LILIN Windows AI Engine SDK

# The Video
Visit the demo video at 
https://www.youtube.com/watch?v=GaY2qOO1Bvs

# Getting Started
Prepare the following:

* Download LILIN AI Engine
* Have a Windows 10 OS machine
* LILIN IP camera

Connect all these devices to the network switch.

![alt tag](https://github.com/LILINOpenGitHub/LILIN-AI-Engine/blob/master/diagram.jpg?raw=true)

# Prerequisites

* Knowledge of HTTP client sending JPEG to a HTTP server (AI Engine)
* HTTP AiEngine SDK

# Installing

* Install Cuda 9.2 at https://developer.nvidia.com/cuda-92-download-archive?target_os=Windows&target_arch=x86_64

# Setup

### Raspberry Pi
* Install paho-mqtt
* Copy and paste my Python code
* Run the Python code as 

sudo python app.py

### The NVR
* Make sure that the NVR is within the same subnet as your Raspberry Pi.
* Modify gv_ipaddress, gv_username, gv_password accordingly for the NVR in app.py.

After above steps, you can start to talk to your Alexa to operate your NVR by saying:

# Examples

Alexa, ask my NVR go channel 1
