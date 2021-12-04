#!/bin/bash

start_date=$(date +%H%M%S)
while :
do
curl --silent http://www.abzone.cz/cgi-bin/nph-count?link=www.22229.cz&increase="${start_date}"&show=YES" align="absmiddle" hspace="10" > ./file.html
sleep 1
curl --silent http://www.abzone.cz/cgi-bin/nph-count?link=www.22229.cz&increase="-${start_date}"&show=YES" align="absmiddle" hspace="10" > ./file.html
new_date=$(date +%H%M%S)
start_date=${new_date}
done
