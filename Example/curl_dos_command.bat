:LOOP
curl --request POST --data-binary "@D:\your_folder\sample.jpg" http://127.0.0.1:8592/sendjpeg
@ping 127.0.0.1 -n 1 > NUL
@goto :LOOP
