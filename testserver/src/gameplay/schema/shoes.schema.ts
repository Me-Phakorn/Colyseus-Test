import { Schema, type } from "@colyseus/schema";
import { getCardNumericValue, SUITS, VALUES } from "../config/deck.config";
import { Card } from "./card.schema";
import { Shoe } from "./shoe.schema";
import { Tier } from "./tier.schema";

export class Shoes extends Schema {
    @type(Shoe) shoe: Shoe;

    private tableID: string;

    private cards: Card[] = [];
    private discardPile: Card[] = [];

    constructor(tableID: string, tierData: Tier) {
        super();

        this.tableID = tableID;
    }
}
