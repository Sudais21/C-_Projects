#include <stdio.h>
#include <time.h>
#include <SDL2/SDL.h>
//#include <SDL.h>
// Screen dimensions
const int SCREEN_WIDTH = 640;
const int SCREEN_HEIGHT = 480;

// Calendar dimensions
const int CELL_SIZE = 40;
const int WEEK_DAYS = 7;
const int WEEK_ROWS = 6;

// Function to draw the calendar
void drawCalendar(SDL_Renderer* renderer, int month, int year)
{
    // Initialize the timeinfo struct
    struct tm timeinfo = { 0 };
    timeinfo.tm_year = year - 1900;
    timeinfo.tm_mon = month - 1;
    timeinfo.tm_mday = 1;
    mktime(&timeinfo);

    // Determine the starting day of the week for the given month and year
    int startDay = timeinfo.tm_wday;

    // Draw the calendar
    int x = 0, y = 0;
    for (int i = 0; i < WEEK_ROWS; i++) {
        for (int j = 0; j < WEEK_DAYS; j++) {
            if ((i == 0 && j < startDay) || timeinfo.tm_mon != month - 1) {
                // Draw empty cells for previous and following months
                SDL_SetRenderDrawColor(renderer, 200, 200, 200, 255);
                SDL_Rect cellRect = { x, y, CELL_SIZE, CELL_SIZE };
                SDL_RenderFillRect(renderer, &cellRect);
                SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
            }
            else {
                // Draw cell for current month
                SDL_Rect cellRect = { x, y, CELL_SIZE, CELL_SIZE };
                SDL_RenderDrawRect(renderer, &cellRect);

                // Draw the day number
                char dayText[3];
                snprintf(dayText, sizeof(dayText), "%d", timeinfo.tm_mday);
                SDL_Color textColor = { 0, 0, 0, 255 };
                SDL_Surface* textSurface = SDL_CreateRGBSurface(0, CELL_SIZE, CELL_SIZE, 32, 0, 0, 0, 0);
                SDL_FillRect(textSurface, NULL, SDL_MapRGB(textSurface->format, 255, 255, 255));
                SDL_Texture* texture = SDL_CreateTextureFromSurface(renderer, textSurface);
                SDL_FreeSurface(textSurface);

                SDL_Rect textRect;
                textRect.x = x + (CELL_SIZE - textSurface->w) / 2;
                textRect.y = y + (CELL_SIZE - textSurface->h) / 2;
                textRect.w = textSurface->w;
                textRect.h = textSurface->h;

                SDL_RenderCopy(renderer, texture, NULL, &textRect);
                SDL_DestroyTexture(texture);

                // Increment the day
                timeinfo.tm_mday++;
                mktime(&timeinfo);
            }
            x += CELL_SIZE;
        }
        x = 0;
        y += CELL_SIZE;
    }
}

int main(int argc, char* args[])
{
    SDL_Window* window = NULL;
    SDL_Renderer* renderer = NULL;

    // Initialize SDL
    if (SDL_Init(SDL_INIT_VIDEO) < 0) {
        printf("SDL could not initialize! SDL_Error: %s\n", SDL_GetError());
        return 1;
    }

    // Create window
    window = SDL_CreateWindow("Calendar", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, SCREEN_WIDTH, SCREEN_HEIGHT, SDL_WINDOW_SHOWN);
    if (window == NULL) {
        printf("Window could not be created! SDL_Error: %s\n", SDL_GetError());
        return 1;
    }

    // Create renderer
    renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (renderer == NULL) {
        printf("Renderer could not be created! SDL_Error: %s\n", SDL_GetError());
        return 1;
    }

    // Set renderer color
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Draw the calendar
    int month = 5;  // May
    int year = 2023;
    drawCalendar(renderer, month, year);

    // Update the screen
    SDL_RenderPresent(renderer);

    // Main loop
    SDL_Event e;
    int quit = 0;
    while (!quit) {
        while (SDL_PollEvent(&e) != 0) {
            if (e.type == SDL_QUIT) {
                quit = 1;
            }
        }
    }

    // Cleanup and quit
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
