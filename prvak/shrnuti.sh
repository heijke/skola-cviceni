#!/bin/bash

VAR="BBB"

func1()
{
if [[ $# -eq 4 ]]; then
	printf "$(((2*$2+11*$3)-$4))\n"
else
	printf "Příliš mnoho/málo argumentů\n"; return 1
exit
fi
}

func2()
{
if [[ $# -eq 3 ]]; then
	printf "$2 \\ $3 \$\n"
	printf "Success\n"; return 0
elif [[ $# -lt 3 ]]; then 
	printf "Too few arguments\n"; return 1
elif [[ $# -gt 3 ]]; then 
	printf "Too many arguments\n"; return 2 
fi
}

func3()
{
	printf "\"VAR\" called gloablly = $VAR\n"
	local VAR="AAA"
	printf "\"VAR\" called locally = $VAR\n"
}  

if [[ $1 -ge 1 && $1 -le 3 ]]; then 
	func$1 $@
else 
	printf "Špatná hodnota prvního argumentu $# \n" 
	exit	
fi
