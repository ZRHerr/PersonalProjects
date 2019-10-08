import random

try:
    # python 2 users
    from Tkinter import *
except ImportError:
    # python 3 users
    from tkinter import *

# Upper Limit
MAX = 100
# Lower Limit
MIN = 1


class Application(Frame):
    # GUI part of the app

    def __init__(self, master):

        Frame.__init__(self, master)
        master.minsize(width=500, height=200)
        self.grid()

        self.create_widgets()

        # Random number for guessing.
        self.number = random.randrange(MIN, MAX + 1)

        self.tries = 0

    def create_widgets(self):

        Label(self,
              text="I'm thinking of a number between: " + str(MIN) +
                   " and" + str(MAX)
              ).grid(row=0, column=0, columnspan=2, sticky=W)
        Label(self,
              text="Try to guess the number: "
              ).grid(row=1, column=0, columnspan=2, sticky=W)
        Label(self,
              text="Number of tries: "
              ).grid(row=0, column=2, columnspan=2, sticky=W)
        Label(self,
              text="Guess "
              ).grid(row=2, column=0, sticky=W)

        self.guess_ent = Entry(self)
        self.guess_ent.grid(row=2, column=1, sticky=W)

        Button(self,
               text="Enter",
               command=self.get_guess
               ).grid(row=2, column=2, columnspan=4, sticky=W)
        Button(self,
               text="Reset",
               command=self.reset
               ).grid(row=1, column=2, columnspan=4, sticky=W)

        self.results_txt = Text(self, width=40, height=5, wrap=WORD)
        self.results_txt.grid(row=3, column=0, columnspan=3)

        # fetching guess

    def get_guess(self):
        try:
            guess = int(self.guess_ent.get())
        except ValueError:
            self.display_message("Invalid Entry")
        else:
            self.tries += 1
            Label(self,
                  text="Number of tries: " + str(self.tries)
                  ).grid(row=0, column=2, columnspan=1, sticky=W)
            self.check_guess(guess)

    def check_guess(self, guess):
        if guess < MIN or guess > MAX:
            self.display_message("Invalid input, out of range")
            self.tries -= 1
            return
        if guess == self.number:
            self.resetgame()
            return
        if guess < self.number:
            self.display_message("Guess Higher...")
            return
        elif guess > self.number:
            self.display_message("Guess Lower...")
            return

    def display_message(self, message):

        self.results_txt.delete(0.0, END)
        self.results_txt.insert(0.0, message)

    def reset(self):

        self.number = random.randrange(MIN, MAX + 1)
        self.display_message("Game reset try again with a new number")
        self.tries = 0
        Label(self,
              text="Number of tries: " + str(self.tries)
              ).grid(row=0, column=2, columnspan=4, sticky=W)

    def resetgame(self):
        self.display_message("Congrats! took you long enough. The number was " + \
                             str(self.number) + ". and it only took you " + \
                             str(self.tries) + " Tries!")


# similar to main method in VS c#

def main():
    root = Tk()
    root.title("Guess game C# - python remake")
    app = Application(root)
    root.mainloop()


main()
