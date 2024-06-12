import { ArraySchema, Schema, type } from "@colyseus/schema";

export class Shoe extends Schema {
    @type("string") shoeID: string;
    @type("string") tableID: string;
    @type("boolean") isDrawRedCard: boolean = false;
    @type("number") totalCards: number;
    @type("number") redCardPosition: number;
    @type("number") numberOfDecks: number;
    @type("number") cutCardsCount: number;
}