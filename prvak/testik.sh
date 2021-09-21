#!/bin/bash

#Connection
echo "Verifying internet connection..."
ping -c 3 ssps.cz &> /dev/null 
if  [[ $? -eq 0 ]];
then 
	echo "OK"
else
	echo "Connect to the internet in order to continue..." #is it worth trying to figure out offline install??
	exit
fi

case $1 in 
	-h)
	 printf "Help\n"
	 ;;
	 *)
	 printf "to print usage type \"-help\"\n":
	 ;;
esac
