#!/bin/bash

printf "Pocet argumentu je: $#\n"

case $1 in 
	cast1)
	if [[ $# -lt 5 || $# -gt 10 ]];
	then 
		printf "Spatny pocet argumentu, zadej jich 5-10\n"
		exit
	else
		a=0
		for i in $@; do
		printf "$((++a)) arg: $i\n"
		done
	fi
	;;
	cast2)
	for i; do
	case $i in 
		win|winner|won)
		printf "$i is a HIT\n"
		;;
		*)
		printf "$i is a MISS\n"
		;;
	esac
	done
	;;
	*)
	printf "Pro 1. cast ukolu zadej \"case1\" pro 2. cast \"cast2\"\n"
	;;
esac

