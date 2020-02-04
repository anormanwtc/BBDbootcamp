#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <string.h>

void inputchar(char c, char **lines, int len) {
    int i;
    int b = 128;

    i = 0;
    if (c == ' ')
        c = 0;
    if (c == '\n') {
        printf("\n");
        return;
    }
    while(i < 4){
        if (c > b) {
            lines[i][len * 3 + 0] = 'o';
            c -= b;
        }
        else
            lines[i][len * 3 + 0] = ' ';
        b /= 2;
        if (c > b) {
            lines[i][len * 3 + 1] = 'o';
            c -= b;
        }
        else
            lines[i][len * 3 + 1] = ' ';
        b /= 2;
        lines[i][len * 3 + 2] = '|';
        i++;
    }
}

int braille(char *ln) { //converts a line into a pseudo braille and prints it
    int i;
    int len;
    char *lines[4];

    i = 0;
    len = strlen(ln);
    while(i < 4) {                  //each line contains 2 parts of each char and | inbetween
        lines[i] = malloc(len * 3 + 1);
        lines[i++][len * 3] = '\0';
    }
    i = 0;
    while(ln[i]) {          //spreads the char into the lines in a sort of binary style
        inputchar(ln[i], lines, i);
        i++;
    }
    i = 0;
    printf("%s\n%s\n%s\n%s\n", lines[0], lines[1], lines[2], lines[3]);
    while(i < 4) {
        free(lines[i++]);
    }
    return (0);
}