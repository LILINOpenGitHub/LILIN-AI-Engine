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
* Download cURL (HTTP) client at https://www.oracle.com/webfolder/technetwork/tutorials/obe/cloud/objectstorage/restrict_rw_accs_cntainers_REST_API/files/installing_curl_command_line_tool_on_windows.html.

Connect all these devices to the network switch.

![alt tag](https://github.com/LILINOpenGitHub/LILIN-AI-Engine/blob/master/diagram.jpg?raw=true)

# Prerequisites

* Knowledge of HTTP client sending JPEG to a HTTP server (AI Engine)
* HTTP AiEngine SDK

# Installing

* Install Cuda 9.2 at https://developer.nvidia.com/cuda-92-download-archive?target_os=Windows&target_arch=x86_64

# Setup

### AI Engine
* Install LILIN AI Engine
* Get a license key at https://www.ddnsipcam.com
* Copy & paste the license key by clicking on ? button.
* Run AiEngine.exe
* You will see a GyNet.exe server running in the background.

# Examples

### The DOS command, curl_dos_command.bat
You can use cURL (HTTP client) sending sample.jpg to AI Engine
Go to Example and download curl_dos_command.bat file.
Download sample.jpg into your PC.
Modify the directory of "your_folder" if necessary.

curl --request POST --data-binary "@D:\your_folder\sample.jpg" http://127.0.0.1:8592/sendjpeg
@ping 127.0.0.1 -n 1 > NUL
@goto :LOOP

### The HTTP page, example.htm
Download sample.htm into C:\Program Files\AI Engine.
You can also find sample.html at C:\Program Files\AI Engine.
Load sample.htm as private mode in your browser.
Click Choose button for loading a JPEG file with a number plate.
Click Submit button for sending the JPEG to GyNet.exe.

![alt tag](https://github.com/LILINOpenGitHub/LILIN-AI-Engine/blob/master/loadfile.jpg?raw=true)

You will see the recognition reply (HTTP) in the browser.

The result:

![alt tag](https://github.com/LILINOpenGitHub/LILIN-AI-Engine/blob/master/return.jpg?raw=true)

Visit http://www.meritlilin.com/en/solution/LSolution_AiEngine for more detail.


