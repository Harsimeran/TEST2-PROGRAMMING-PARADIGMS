let director1 = { Name = "Sian Heder"; Movies = 9 }
let director2 = { Name = "Kenneth Branagh"; Movies = 23 }
let director3 = { Name = "Adam McKay"; Movies = 27 }
let director4 = { Name = "Ryusuke Hamaguchi"; Movies = 16 }
let director5 = { Name = "Denis Villeneuve"; Movies = 24 }
let director6 = { Name = "Reinaldo Marcus Green"; Movies = 15 }
let director7 = { Name = "Paul Thomas Anderson"; Movies = 49 }
let director8 = { Name = "Guillermo Del Toro"; Movies = 22 }

let movie1 = { Name = "CODA"; RunLength = 111; Genre = Drama; Director = director1; IMDBRating = 8.1 }
let movie2 = { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = director2; IMDBRating = 7.3 }
let movie3 = { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = director3; IMDBRating = 7.2 }
let movie4 = { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = director4; IMDBRating = 7.6 }
let movie3 = { Name = "Dune"; RunLength = 155; Genre = Comedy; Director = director3; IMDBRating = 7.2 }
let movie3 = { Name = "King Richard"; RunLength = 144; Genre = Comedy; Director = director3; IMDBRating = 7.2 }
let movie3 = { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = director3; IMDBRating = 7.2 }
let movie3 = { Name = "Nightmare Alley"; RunLength = 150; Genre = Comedy; Director = director3; IMDBRating = 7.2 }

// Display movie instances
printfn "Movie 1: %s, %d minutes, Genre: %A, Director: %s, Rating: %f" movie1.Name movie1.RunLength movie1.Genre movie1.Director.Name movie1.IMDBRating
printfn "Movie 2: %s, %d minutes, Genre: %A, Director: %s, Rating: %f" movie2.Name movie2.RunLength movie2.Genre movie2.Director.Name movie2.IMDBRating
printfn "Movie 3: %s, %d minutes, Genre: %A, Director: %s, Rating: %f" movie3.Name movie3.RunLength movie3.Genre movie3.Director.Name movie3.IMDBRating