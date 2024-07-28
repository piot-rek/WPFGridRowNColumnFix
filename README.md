# WPFGridRowNColumnFix
## The background
How many times did you need to shift a WPF grid items, by 1 or more columns or rows, after you carefully crafted all the design?\
It's pain to renumber all the `Grid.Row` and `Grid.Column` properties manually, and the designer doesn't help too much.
## The motivation
Too many times indeed. It's always been "ah, that's only 30 places to change, won't write the app this time".\
Now I said "enough" and came up with this.
## The app
It's not a masterpiece, however it gets the job done. It's just simple find & replace scenario everyone needed and rarely one bothers to write.\
Just paste the XAML to the textbox (it does it itself when the app opens) and use four buttons to adjust the Grid.Columns' and .Rows' value with a step of one.\
The app doesn't care if there is enough columns or rows defined, it's up to user to take care of it.\
It's intentional: the user knows this best and i decided it's not this app's job.\
And of course that keeps the app ridiculously simple as it is.\
\
![wfp_grid_fix](https://github.com/user-attachments/assets/0b4e7209-3785-4ee0-adaa-4961159ad51f)

## The plans
Maybe in some predictable future i'll merge a few of such "tools" into one toolbox instead of having tens of mini-apps laying around.\
It'll be what it'll be.
