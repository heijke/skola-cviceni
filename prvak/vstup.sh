#!/bin/bash

VAR1="~ Uživatelský vstup je : "
VAR2="# Obsah souboru :\n"
VAR4=$(cat ./textfile.txt)
YELLOW="\e[33m"
MAGENTA="\e[35m"
END="\e[0m"

cti()
{
printf "${YELLOW}Zadejte uživatelský vstup : ${END}"
read VAR3
}
vypis()
{
printf "${MAGENTA}%s${END}%s\n" "$VAR1" "$VAR3"
printf "${MAGENTA}$VAR2${END}$VAR4\n" 
}

cti; vypis
