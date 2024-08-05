#include <SFML/Graphics.hpp>
#include <iostream>
#include <vector>
#include <cstdlib>
#include <ctime>

class MinesweeperGame {
public:
    MinesweeperGame() : window(sf::VideoMode(800, 600), "Minesweeper"), GRID_WIDTH(10), GRID_HEIGHT(10), NUM_MINES(20), CELL_SIZE(40) {
        generateBoard();
        run();
    }

private:
    sf::RenderWindow window;
    const int GRID_WIDTH;
    const int GRID_HEIGHT;
    const int NUM_MINES;
    const int CELL_SIZE;

    enum class CellState { Hidden, Revealed, Flagged };

    struct Cell {
        bool hasMine = false;
        int adjacentMines = 0;
        CellState state = CellState::Hidden;
    };

    std::vector<std::vector<Cell>> board;

    void generateBoard() {
        // Initialize the board with empty cells
        board.resize(GRID_HEIGHT, std::vector<Cell>(GRID_WIDTH));

        // Randomly place mines on the board
        int minesPlaced = 0;
        while (minesPlaced < NUM_MINES) {
            int x = std::rand() % GRID_WIDTH;
            int y = std::rand() % GRID_HEIGHT;

            if (!board[y][x].hasMine) {
                board[y][x].hasMine = true;
                minesPlaced++;
            }
        }

        // Calculate the number of adjacent mines for each cell
        for (int y = 0; y < GRID_HEIGHT; y++) {
            for (int x = 0; x < GRID_WIDTH; x++) {
                if (board[y][x].hasMine)
                    continue;

                for (int dy = -1; dy <= 1; dy++) {
                    for (int dx = -1; dx <= 1; dx++) {
                        int ny = y + dy;
                        int nx = x + dx;

                        if (ny >= 0 && ny < GRID_HEIGHT && nx >= 0 && nx < GRID_WIDTH) {
                            if (board[ny][nx].hasMine)
                                board[y][x].adjacentMines++;
                        }
                    }
                }
            }
        }
    }

    void revealCell(int x, int y) {
        if (x < 0 || x >= GRID_WIDTH || y < 0 || y >= GRID_HEIGHT)
            return;

        Cell& cell = board[y][x];
        if (cell.state == CellState::Hidden) {
            cell.state = CellState::Revealed;
            if (cell.adjacentMines == 0) {
                for (int dy = -1; dy <= 1; dy++) {
                    for (int dx = -1; dx <= 1; dx++) {
                        revealCell(x + dx, y + dy);
                    }
                }
            }
        }
    }

    void handleInput() {
        sf::Event event;
        while (window.pollEvent(event)) {
            if (event.type == sf::Event::Closed) {
                window.close();
            }
            else if (event.type == sf::Event::MouseButtonPressed) {
                if (event.mouseButton.button == sf::Mouse::Left) {
                    int x = event.mouseButton.x / CELL_SIZE;
                    int y = event.mouseButton.y / CELL_SIZE;
                    if (x >= 0 && x < GRID_WIDTH && y >= 0 && y < GRID_HEIGHT) {
                        if (board[y][x].hasMine) {
                            // TODO: Handle game over
                        }
                        else {
                            revealCell(x, y);
                        }
                    }
                }
                else if (event.mouseButton.button == sf::Mouse::Right) {
                    int x = event.mouseButton.x / CELL_SIZE;
                    int y = event.mouseButton.y / CELL_SIZE;
                    if (x >= 0 && x < GRID_WIDTH && y >= 0 && y < GRID_HEIGHT) {
                        if (board[y][x].state == CellState::Hidden) {
                            board[y][x].state = CellState::Flagged;
                        }
                        else if (board[y][x].state == CellState::Flagged) {
                            board[y][x].state = CellState::Hidden;
                        }
                    }
                }
            }
        }
    }

    void drawBoard() {
        window.clear(sf::Color::White);

        for (int y = 0; y < GRID_HEIGHT; y++) {
            for (int x = 0; x < GRID_WIDTH; x++) {
                Cell& cell = board[y][x];
                sf::RectangleShape cellShape(sf::Vector2f(CELL_SIZE, CELL_SIZE));
                cellShape.setPosition(x * CELL_SIZE, y * CELL_SIZE);
                cellShape.setOutlineThickness(1);
                cellShape.setOutlineColor(sf::Color::Black);

                if (cell.state == CellState::Hidden) {
                    cellShape.setFillColor(sf::Color::Magenta);
                }
                else if (cell.state == CellState::Revealed) {
                    if (cell.hasMine) {
                        cellShape.setFillColor(sf::Color::Red);
                    }
                    else {
                        cellShape.setFillColor(sf::Color::White);
                        if (cell.adjacentMines > 0) {
                            sf::Text text(std::to_string(cell.adjacentMines), sf::Font(), 20);
                            text.setPosition(x * CELL_SIZE + CELL_SIZE / 2 - text.getLocalBounds().width / 2,
                                y * CELL_SIZE + CELL_SIZE / 2 - text.getLocalBounds().height / 2);
                            window.draw(text);
                        }
                    }
                }
                else if (cell.state == CellState::Flagged) {
                    cellShape.setFillColor(sf::Color::Yellow);
                }

                window.draw(cellShape);
            }
        }

        window.display();
    }

    void run() {
        std::srand(static_cast<unsigned>(std::time(nullptr)));

        while (window.isOpen()) {
            handleInput();
            drawBoard();
        }
    }
};

int main() {
    MinesweeperGame game;
    return 0;
}
 
