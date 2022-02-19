import { BeerQuote } from "./beerq/beerq.js"

let beerQuote = BeerQuote("eng");

let randomQuote = beerQuote.getRandomQuote();

console.log(randomQuote.quote);

