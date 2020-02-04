#include <stdio.h>

int main(void) {
    int exit;
    char line[300];

    exit = 0;
    while (!exit) {
        fgets(line, 299, stdin);
        braille(line);
        if (!strcmp(line, "exit\n"))
            exit = 1;
    }
    return (0);
}