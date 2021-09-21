#!/bin/bash
case $1 in
  pocitej)
    printf "$((((10*$2)+($3-5))/(2*$4)))\n"
    ;;
  *)
    printf "Zadej moznost \"pocitej\" a za ni 3 ciselne argumenty \"a\", \"b\", \"c\"\n"
    ;;
esac
